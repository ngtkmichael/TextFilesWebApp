using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TextFilesWebApp.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));

            return View(files);
        }

        // /Files/FileContent/File3.txt
        public ActionResult FileContent(String fileName)
        {

            // FileContent(string fileName)
            // 

            var strPath = AppDomain.CurrentDomain.BaseDirectory;
            var strPathTextFiles = strPath + "TextFiles\\";
            var strFileFullName = strPathTextFiles + fileName;

            //// Read the file as one string.
            var strText = System.IO.File.ReadAllText(@strFileFullName);

            ViewBag.FileContent = strText;

            return View();
        }

        // /Files/Display/File5.txt
        public ActionResult Display(String id)
        {


            var textFiles = Directory.GetFiles(Server.MapPath("~/TextFiles/"));
            
            var strPath = AppDomain.CurrentDomain.BaseDirectory;
            var strPathTextFiles = strPath + "TextFiles\\";
            var strTextFileFullName = strPathTextFiles + id + ".txt";
            var strText = "";
            int intCount = 0;

            // Read the file as one string.
            foreach (String strFileName in textFiles)
            {
                if (strFileName == strTextFileFullName)
                {
                    strText = System.IO.File.ReadAllText(textFiles[intCount]);
                    break;
                }
                intCount += 1;
            }

            ViewBag.Text = strText;

            return View();
        }
    }

}

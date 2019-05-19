using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WAPI.docx;
using Xceed.Words.NET;

// https://www.c-sharpcorner.com/article/word-automation-using-C-Sharp/


namespace WAPI.cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageFolderPath = @"c:\temp\image\koty";

            var imageFiles = new List<string>();
            string[] filePaths = Directory.GetFiles(imageFolderPath, "*.*");                       
            foreach (var fp in filePaths)
            {
                if (Regex.IsMatch(fp.ToLower(), @".jpg|.png|.gif$"))
                    imageFiles.Add(fp);
            }

            
            foreach (var fp in imageFiles.OrderBy(fp=>fp)) Console.WriteLine(fp);


            using (DocX document = DocX.Create(@"c:\temp\image\test.docx"))
            {
                document.SetTitle("dupa");
                document.SetPageMargins();

                foreach (var fp in imageFiles.OrderBy(fp => fp)) 
                    document.AddPicture(fp,title:$"{fp}\r\n");

                document.Save();
            }
        }
    }
}

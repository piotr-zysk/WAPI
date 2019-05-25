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
            var imageFolderPath = @"c:\temp\image\z1";

            var imageFiles = new List<string>();
            string[] filePaths = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.AllDirectories);                       
            foreach (var fp in filePaths)
            {
                if (Regex.IsMatch(fp.ToLower(), @".jpg|.png|.gif$"))
                    imageFiles.Add(fp);
            }

            
            using (DocX document = DocX.Create(@"c:\temp\image\test.docx"))
            {
                document.SetTitle("tytuł");
                document.SetPageMargins();

                int imageIndex = 1;
                int imageCount = imageFiles.Count;

                foreach (var fp in imageFiles.OrderBy(fp => fp))
                {
                    //document.AddPicture(fp, title: $"{fp}\r\n");
                    document.AddPicture(fp);
                    Console.WriteLine($"Added image {imageIndex++} / {imageCount} ({fp}).");
                }

                document.Save();
            }
        }
    }
}

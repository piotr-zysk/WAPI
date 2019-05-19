using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


            using (DocX document = DocX.Create(@"c:\temp\image\test.docx"))
            {
                document.SetTitle("dupa");
                document.SetPageMargins();

                var path = @"c:\temp\image\balloon.jpg";
                document.AddPicture(path);

                document.Save();
            }
        }
    }
}

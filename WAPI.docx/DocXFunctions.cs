using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace WAPI.docx
{
    public class DocXFunctions
    {
        public bool MakeFileWithImages(string imageFolderPath, string outputFilePath, string title, Action<int> progressPercentage, Action<string> fail, int maxImages = 50)
        {   
            var imageFiles = new List<string>();
            string[] filePaths = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.AllDirectories).Take(maxImages).ToArray();
            foreach (var fp in filePaths)
            {
                if (Regex.IsMatch(fp.ToLower(), @".jpg|.png|.gif$"))
                    imageFiles.Add(fp);
            }


            using (DocX document = DocX.Create(outputFilePath))
            {

                int imageIndex = 1;
                int imageCount = imageFiles.Count;

                if (imageCount == 0)
                {
                    fail("No images. Is the image location correct?");
                    return false;
                }

                                

                document.SetTitle(title);
                document.SetPageMargins();


                try
                {
                    foreach (var fp in imageFiles.OrderBy(fp => fp))
                    {
                        document.AddPicture(fp);
                        progressPercentage((int)Math.Round((decimal)100 * imageIndex++ / imageCount));
                    }
                }
                catch(Exception e)
                {
                    fail(e.Message);
                    return false;
                }

                document.Save();
                return true;
            }
        }
    }
}

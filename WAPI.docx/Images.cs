using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPI.docx
{
    public class Images
    {
        public static Size CalculateImageResolution(string imageFilePath, int documentWidth=770)
        {
            var img = System.Drawing.Image.FromFile(imageFilePath);            

            int docImgWidth;
            int docImgHeight;

            if (img.Width > img.Height)
            {
                docImgWidth = documentWidth;
                docImgHeight = (int)documentWidth * img.Height / img.Width;
            }
            else
            {
                docImgHeight = documentWidth;
                docImgWidth = (int)documentWidth * img.Width / img.Height;

            }

            var size = new Size() { Width = docImgWidth, Height = docImgHeight };
            return size;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace WAPI.docx
{
    public static class DocxExtension
    {
        public static void SetPageMargins(this DocX document, Single left = 10f, Single right = 10f, Single top = 0f, Single bottom = 10f)
        {
            document.MarginLeft = left;
            document.MarginRight = right;
            document.MarginTop = top;
            document.MarginBottom = bottom;
        }

        public static void SetTitle(this DocX document, string title, double fontSize=15d)
            => document.InsertParagraph(title).FontSize(fontSize).SpacingAfter(10d).Alignment = Alignment.center;

        public static void AddPicture(this DocX document, string imageFilePath, string title="", Alignment alignment=Alignment.center, double spacingAfter=10, int documentWidth=770)
        {
            var imgSize = Images.CalculateImageResolution(imageFilePath,documentWidth);
            var image = document.AddImage(imageFilePath);
            var picture = image.CreatePicture(imgSize.Height, imgSize.Width);            
            var p = document.InsertParagraph(title);
            p.AppendPicture(picture);
            p.SpacingAfter(spacingAfter);
            p.Alignment = alignment;
        }
    }
}

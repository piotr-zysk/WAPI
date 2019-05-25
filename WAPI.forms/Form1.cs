using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAPI.docx;
using Xceed.Words.NET;

namespace WAPI.forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
            RefreshImageLocationCaption();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var imageFolderPath = this.folderBrowserDialog.SelectedPath;

            var imageFiles = new List<string>();
            string[] filePaths = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.AllDirectories);
            foreach (var fp in filePaths)
            {
                if (Regex.IsMatch(fp.ToLower(), @".jpg|.png|.gif$"))
                    imageFiles.Add(fp);
            }


            using (DocX document = DocX.Create(textBoxOutputFile.Text))
            {
                document.SetTitle(textBoxTitle.Text);
                document.SetPageMargins();

                int imageIndex = 1;
                int imageCount = imageFiles.Count;

                foreach (var fp in imageFiles.OrderBy(fp => fp))
                {
                    //document.AddPicture(fp, title: $"{fp}\r\n");
                    document.AddPicture(fp);
                    progressBar.Value = (int)Math.Round((decimal)100 * imageIndex++ / imageCount);
                    //Console.WriteLine($"Added image {imageIndex++} / {imageCount} ({fp}).");
                }

                document.Save();
            }
        }

        private void RefreshImageLocationCaption()
            => this.buttonImageLocation.Text = $"Image location: {this.folderBrowserDialog.SelectedPath}";

        private void ProgressBarReset()
            => progressBar.Value = 0;

        private void Button2_Click(object sender, EventArgs e)
        {
            //
            // This event handler was created by double-clicking the window in the designer.
            // It runs on the program's startup routine.
            //
            ProgressBarReset();

            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                RefreshImageLocationCaption();
                //string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

        private void TextBoxOutputFile_TextChanged(object sender, EventArgs e)
        {
            ProgressBarReset();
        }

        private void TextBoxTitle_TextChanged(object sender, EventArgs e)
        {
            ProgressBarReset();
        }
    }
}

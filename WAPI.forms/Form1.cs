﻿using System;
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

            new DocXFunctions().MakeFileWithImages(
                this.folderBrowserDialog.SelectedPath,
                textBoxOutputFile.Text,
                textBoxTitle.Text,
                x => progressBar.Value = x,
                error => MessageBox.Show(error, "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Information),
                50,
                checkBox_cutFilePrefixes.Checked
                );

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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System.IO;

namespace WAPI.forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonImageLocation = new System.Windows.Forms.Button();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(13, 93);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(588, 44);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate File";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE";
            // 
            // buttonImageLocation
            // 
            this.buttonImageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonImageLocation.Location = new System.Drawing.Point(12, 12);
            this.buttonImageLocation.Name = "buttonImageLocation";
            this.buttonImageLocation.Size = new System.Drawing.Size(589, 23);
            this.buttonImageLocation.TabIndex = 1;
            this.buttonImageLocation.Text = "Change images location";
            this.buttonImageLocation.UseVisualStyleBackColor = true;
            this.buttonImageLocation.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOutputFile.Location = new System.Drawing.Point(12, 41);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(589, 20);
            this.textBoxOutputFile.TabIndex = 2;
            this.textBoxOutputFile.Text = "c:\\temp\\test.docx";
            this.textBoxOutputFile.TextChanged += new System.EventHandler(this.TextBoxOutputFile_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 143);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(588, 23);
            this.progressBar.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTitle.Location = new System.Drawing.Point(13, 67);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(589, 20);
            this.textBoxTitle.TabIndex = 4;
            this.textBoxTitle.Text = "tytuł";
            this.textBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 172);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.buttonImageLocation);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Form1";
            this.Text = "WAPI - images to .docx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonImageLocation;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}


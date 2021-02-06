namespace FiveM_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browseFile = new System.Windows.Forms.Button();
            this.renameFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // browseFile
            // 
            this.browseFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseFile.Location = new System.Drawing.Point(363, 214);
            this.browseFile.Name = "browseFile";
            this.browseFile.Size = new System.Drawing.Size(75, 23);
            this.browseFile.TabIndex = 0;
            this.browseFile.Text = "Browse";
            this.browseFile.UseVisualStyleBackColor = true;
            this.browseFile.Click += new System.EventHandler(this.browseFile_Click);
            // 
            // renameFile
            // 
            this.renameFile.Location = new System.Drawing.Point(363, 276);
            this.renameFile.Name = "renameFile";
            this.renameFile.Size = new System.Drawing.Size(75, 23);
            this.renameFile.TabIndex = 1;
            this.renameFile.Text = "Rename";
            this.renameFile.UseVisualStyleBackColor = true;
            this.renameFile.Click += new System.EventHandler(this.renameFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renameFile);
            this.Controls.Add(this.browseFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FiveM EUP Conversion Master";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseFile;
        private System.Windows.Forms.Button renameFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog selectFolderDialog;
    }
}


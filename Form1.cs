using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace FiveM_Converter
{
    public partial class Form1 : Form
    {
        string folderPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void browseFile_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                folderPath = dialog.FileName;
            }
        }

        private void renameFile_Click(object sender, EventArgs e)
        {
            renameAllFiles(folderPath);
            MessageBox.Show("Successfully renamed files", "Success", MessageBoxButtons.OK);
        }

        private void renameAllFiles(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            DirectoryInfo[] dirs = dirInfo.GetDirectories();

            foreach (FileInfo file in files)
            {
                if (file.FullName.Contains(".ytd") || file.FullName.Contains(".ydd"))
                {
                    File.Move(file.FullName, file.Directory.FullName + "\\" + file.Directory.Name + "^" + file.Name);
                    File.Delete(file.FullName);
                }
            }

            foreach(DirectoryInfo dir in dirs)
            {
                renameAllFiles(dir.FullName);
            }
        }
    }
}
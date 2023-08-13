using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audacity_Recovery_Tool
{
    public partial class ART : Form
    {
        public string path;
        public bool stereo;
        public ART()
        {
            InitializeComponent();
            openFolder.FileOk += openFolder_FileOk;
        }

        private void btn_searchFolder_Click(object sender, EventArgs e)
        {
            openFolder.FileName = "Select folder";
            openFolder.ValidateNames = false;
            openFolder.CheckFileExists = false;
            openFolder.CheckPathExists = true;
            openFolder.Filter = "SessionData|folder";
            
            openFolder.ShowDialog();
        }

        private void openFolder_FileOk(object sender, CancelEventArgs e)
        {
            string selectedPath = Path.GetDirectoryName(openFolder.FileName);
            

            if (Path.GetFileName(selectedPath) == "SessionData")
            {
                path = selectedPath;
                txt_path.Text = path;
            }
            else
            {
                MessageBox.Show("Please select the folder 'SessionData'.");
                e.Cancel = true;
            }
        }

        private void btn_v3_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string recoveryFolderPath = Path.Combine(desktopPath, "Recovered");

            if (!Directory.Exists(recoveryFolderPath))
            {
                Directory.CreateDirectory(recoveryFolderPath);
            }

            string[] sourceExtensions = { ".aup3unsaved", ".aup3unsaved-shm", ".aup3unsaved-wal" };
            string targetName = "recovered-project";

            try
            {
                foreach (string sourceExtension in sourceExtensions)
                {
                    string[] sourceFiles = Directory.GetFiles(path, $"*{sourceExtension}");

                    foreach (string sourceFilePath in sourceFiles)
                    {
                       string targetExtension = Path.GetExtension(sourceFilePath).Replace("aup3unsaved", "aup3");
                       string targetFilePath = Path.Combine(recoveryFolderPath, $"{targetName}{targetExtension}");

                       File.Copy(sourceFilePath, targetFilePath, true);
                    }
                }
                MessageBox.Show("The project has been saved to the desktop in the 'Recovered' folder.");
            }
            catch
            {
                MessageBox.Show("Make sure the path to the folder and the version is correct and try again.\nIf the error persists it means that the recovery is not possible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btn_v2_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;

            try
            {

                string[] subDirectories = Directory.GetDirectories(path);
                string mostRecentSubDirectory = subDirectories.OrderByDescending(d => Directory.GetLastWriteTime(d)).FirstOrDefault();

                if (mostRecentSubDirectory != null)
                {
                    string allFolderPath = Path.Combine(mostRecentSubDirectory, "all");
                    Directory.CreateDirectory(allFolderPath);

                    foreach (string filePath in Directory.GetFiles(mostRecentSubDirectory, "*.au", SearchOption.AllDirectories))
                    {
                        string fileName = Path.GetFileName(filePath);
                        string destinationPath = Path.Combine(allFolderPath, fileName);
                        try
                        {
                            File.Copy(filePath, destinationPath);
                        }
                        catch
                        {
                            Console.WriteLine("Skipped");
                        }
                    }

                    var allFiles = Directory.GetFiles(allFolderPath);
                    Array.Sort(allFiles, (a, b) => File.GetLastWriteTime(a).CompareTo(File.GetLastWriteTime(b)));

                    string recoveredFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Recovered");
                    Directory.CreateDirectory(recoveredFolderPath);

                    if (!stereo)
                    {
                        string recoveredAllFolderPath = Path.Combine(recoveredFolderPath, "all");
                        Directory.CreateDirectory(recoveredAllFolderPath);
                        for (int i = 0; i < allFiles.Length; i++)
                        {
                            string fileName = Path.GetFileName(allFiles[i]);
                            string destinationPath = Path.Combine(recoveredAllFolderPath, $"file{i + 1:D5}.au");
                            File.Copy(allFiles[i], destinationPath);
                        }
                    }
                    else
                    {
                        string channel1FolderPath = Path.Combine(recoveredFolderPath, "channel1");
                        string channel2FolderPath = Path.Combine(recoveredFolderPath, "channel2");
                        Directory.CreateDirectory(channel1FolderPath);
                        Directory.CreateDirectory(channel2FolderPath);

                        for (int i = 0; i < allFiles.Length; i++)
                        {
                            string fileName = Path.GetFileName(allFiles[i]);
                            string destinationFolder = i % 2 == 0 ? channel2FolderPath : channel1FolderPath;
                            string destinationPath = Path.Combine(destinationFolder, $"file{i + 1:D5}.au");
                            File.Move(allFiles[i], destinationPath);
                        }
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Import the .au into audacity, select all with CTRL+A and go to Tracks > Align Trucks > Align End to End.", "Recovered Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Make sure the path to the folder and the version is correct and try again.\nIf the error persists it means that the recovery is not possible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Make sure the path to the folder and the version is correct and try again.\nIf the error persists it means that the recovery is not possible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void check_stereo_CheckedChanged(object sender, EventArgs e)
        {
            stereo = check_stereo.Checked;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'SessionData' is usually located on C:/Users/User/AppData/Local/audacity/SessionData", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


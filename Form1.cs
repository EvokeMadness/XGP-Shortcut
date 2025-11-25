using IWshRuntimeLibrary;
using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace XGP_Shortcut
{
    public partial class Form1 : Form
    {
        string gamePath;
        string contentPath;
        string configPath;
        string targetPath;
        string logoPath;

        string Argument;
        new string Name;
        new string Icon;
        string Shortcut;

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string tempFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp");

        bool validPath = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Cleanup()
        {
            if (System.IO.File.Exists(Icon))
            {
                System.IO.File.Delete(Icon);
            }

            validPath = false;
            textBoxGamePath.Clear();
            logOutput.Items.Clear();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            Cleanup();

            folderBrowserDialog1.ShowDialog();

            if (!string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                gamePath = folderBrowserDialog1.SelectedPath;
                contentPath = System.IO.Directory.Exists(Path.Combine(gamePath, "Content")) ? Path.Combine(gamePath, "Content") : string.Empty;
                configPath = System.IO.File.Exists(Path.Combine(contentPath, "MicrosoftGame.config")) ? Path.Combine(contentPath, "MicrosoftGame.config") : string.Empty;

                ValidatePath();
            }
            else
            {
                logOutput.Items.Add("No folder selected.");
            }
        }

        private void buttonAddArgument_Click(object sender, EventArgs e)
        {
            Argument = comboBoxCommonArguments.Text;
            textBoxArguments.Text += (textBoxArguments.Text.Length > 0 ? " " : "") + Argument;

            logOutput.Items.Add($"Added `{Argument}` to arguments.");
        }

        private void buttonCreateShortcut_Click(object sender, EventArgs e)
        {
            if (validPath)
            {
                ConvertLogo(logoPath);
                logOutput.Items.Add("Logo converted to icon.");

                CreateShortcut();
                logOutput.Items.Add("Shortcut created on desktop.");
            }
            else
            {
                logOutput.Items.Add("Invalid game path. Shortcut not created.");
            }
        }

        private void ValidatePath()
        {
            string[] paths = { gamePath, contentPath, configPath };
            if (paths.All(path => !string.IsNullOrEmpty(path)))
            {
                validPath = true;
                textBoxGamePath.Text = gamePath;

                ReadConfig();
                logOutput.Items.Add("MicrosoftGame.config found.");
            }
            else
            {
                logOutput.Items.Add("MicrosoftGame.config not found in Content folder.");
            }
        }

        private void ReadConfig()
        {
            using XmlReader reader = XmlReader.Create(configPath);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Executable")
                {
                    targetPath = Path.Combine(contentPath, reader.GetAttribute("Name"));
                }
                else if (reader.NodeType == XmlNodeType.Element && reader.Name == "ShellVisuals")
                {
                    Name = reader.GetAttribute("DefaultDisplayName");
                    logoPath = Path.Combine(contentPath, reader.GetAttribute("Square44x44Logo"));
                    shortcutPreview.Image = Image.FromFile(logoPath);
                }
            }
        }

        private string ConvertLogo(string logoPath)
        {
            string input = logoPath;
            string output = Path.Combine(tempFolder, Path.GetFileNameWithoutExtension(input) + ".ico");

            try
            {
                using (Process myProcess = new())
                {
                    myProcess.StartInfo.FileName = Path.Combine(Environment.CurrentDirectory, "./ImageMagick/magick.exe");
                    myProcess.StartInfo.Arguments = $"\"{input}\" \"{output}\"";
                    myProcess.Start();
                }

                Icon = output;
            }
            catch (Exception)
            {
                validPath = false;

                logOutput.Items.Add("ImageMagick/magick.exe failed to start");
            }
            return Icon;
        }

        private void CreateShortcut()
        {
            Type shellType = Type.GetTypeFromProgID("WScript.Shell");
            dynamic shell = Activator.CreateInstance(shellType);
            dynamic shortcut = shell.CreateShortcut(Path.Combine(desktopPath, Name + ".lnk"));

            shortcut.IconLocation = Icon;
            shortcut.TargetPath = Path.Combine(contentPath, "gamelaunchhelper.exe");
            shortcut.Arguments = textBoxArguments.Text;
            shortcut.Save();
        }

        private void toolStripButtonLicenses_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cleanup();
        }
    }
}

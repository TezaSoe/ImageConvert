using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows;

namespace ImageConvert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderPicker();

            //if (FolderNameLabel.Content == null)
            if (string.IsNullOrEmpty(FolderNameLabel.Text))
                dialog.InputPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                dialog.InputPath = FolderNameLabel.Text.ToString();

            if (dialog.ShowDialog() == true)
            {
                FolderNameLabel.Text = dialog.ResultPath;
                OutPutFolderNameLabel.Text = string.Empty;
                PngFileCount.Content = string.Empty;
            }
        }

        private void ConvertJPG_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FolderNameLabel.Text))
            {
                MessageBox.Show("Please select the directory first!");
                return;
            }

            try
            {
                string outputDirectory = FolderNameLabel.Text.Trim() + "-JPG";
                int i = 1;
                string tempOutputDirectory = outputDirectory;
                while (Directory.Exists(tempOutputDirectory))
                {
                    tempOutputDirectory = outputDirectory + i++;
                }
                outputDirectory = tempOutputDirectory;
                Directory.CreateDirectory(outputDirectory);
                OutPutFolderNameLabel.Text = outputDirectory;

                string[] patterns = new[] { "*.png", "*.PNG", "*.Png" };
                string[] files = GetFiles(FolderNameLabel.Text, patterns);
                PngFileCount.Content = string.Format("PNG File Count : {0}", files.Length);
                int count = 0;
                foreach (string file in files)
                {
                    string name = Path.GetFileNameWithoutExtension(file);
                    Image png = Image.FromFile(file);

                    png.Save(outputDirectory + @"/" + name + ".jpg", ImageFormat.Jpeg);
                    png.Dispose();

                    count++;
                }
                MessageBox.Show("Png to Jpg Converted.\nJpg File Count : " + count, "Message");
            }
            catch (Exception ex)
            {
                var errmsg = ex.Message;
                MessageBox.Show(errmsg, "Message");
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = OutPutFolderNameLabel.Text;
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        private string[] GetFiles(string path, string[] patterns = null, SearchOption options = SearchOption.TopDirectoryOnly)
        {
            if (patterns == null || patterns.Length == 0)
                return Directory.GetFiles(path, "*", options);
            if (patterns.Length == 1)
                return Directory.GetFiles(path, patterns[0], options);
            return patterns.SelectMany(pattern => Directory.GetFiles(path, pattern, options)).Distinct().ToArray();
        }
    }
}

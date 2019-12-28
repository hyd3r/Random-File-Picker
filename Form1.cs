using ErikE.Shuriken;
using Microsoft.WindowsAPICodePack.Shell;
using NReco.VideoConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_File_Picker
{
    public partial class Form1 : Form
    {
        DirectoryInfo selectedDir;
        FolderSelectDialog folder;
        FileInfo[] files;
        Random randomIndex = new Random();
        FFMpegConverter ffMpeg = new NReco.VideoConverter.FFMpegConverter();
        Stream stream;
        Timer t = new Timer();
        int currentFileIndex;
        int frameCounter=1;
        String[] video =
        {
            ".mp4",".webm",".mkv",".flv",".avi",".wmv",".m4v",".mpg",".mpeg",".wav",".mov",".webm",".3gp"
        };
        String[] image =
        {
           ".JPG",".JPEG",".GIF",".BMP",".PNG",".WebP"
        };

        public Form1()
        {
            InitializeComponent();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Stop();
            folder = new FolderSelectDialog();
            if (folder.Show())
            {
                selectedDir = new DirectoryInfo(folder.FileName);
                files = selectedDir.GetFiles();
                fileNameLabel.Focus();
                if (files.Length == 0){
                    MessageBox.Show("Doesn't contain any files");
                    randomizeButton.Enabled = false;
                }
                else randomizeButton.Enabled = true;
                openButton.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
            openButton.Enabled = true;
            fileNameLabel.Focus(); fileNameLabel.Focus();
            int rnd = randomIndex.Next(0, files.Length-1);

            while (files[rnd].Attributes.HasFlag(FileAttributes.Hidden))
            {
                rnd = randomIndex.Next(0, files.Length);
            }
            string format = checkExtension(files[rnd].Extension);
            if (format.Equals("video"))
            {
                currentFileIndex = rnd;
                fileNameLabel.Text = files[currentFileIndex].Name;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                t.Start();
                frameCounter = 1;

            }
            else if (format.Equals("image"))
            {
                currentFileIndex = rnd;
                fileNameLabel.Text = files[currentFileIndex].Name;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(files[currentFileIndex].FullName);
            }
            else
            {
                currentFileIndex = rnd;
                fileNameLabel.Text = files[currentFileIndex].Name;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                ShellFile shellFile = ShellFile.FromFilePath(files[currentFileIndex].FullName);
                Bitmap shellThumb = shellFile.Thumbnail.ExtraLargeBitmap;
                pictureBox1.Image = shellThumb;
            }

        }
        void t_Tick(object sender, EventArgs e)
        {
            stream = new MemoryStream();
            ffMpeg.GetVideoThumbnail(files[currentFileIndex].FullName, stream, frameCounter);
            if (stream.Length == 0)
            {
                frameCounter = 1;
            }
            else
            {
                pictureBox1.Image = Image.FromStream(stream);
            }
            frameCounter += new Random().Next(1, 1000);

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            fileNameLabel.Focus();
            t.Stop();
            Process.Start(files[currentFileIndex].FullName);
        }

        private string checkExtension(string ext)
        {
            if(video.Any(s => s.IndexOf(ext, StringComparison.CurrentCultureIgnoreCase) > -1))
                return "video";
            else if(image.Any(s => s.IndexOf(ext, StringComparison.CurrentCultureIgnoreCase) > -1))
                return "image";
            else return "";

        }
    }

}

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace imgResize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            string path = txt_folder.Text; // 대상 폴더 경로
            string[] files = Directory.GetFiles(path, "*.png");
            string new_path = txt_folder.Text + "\\output";
            if (Directory.Exists(new_path) == false)
            {
                Directory.CreateDirectory(new_path);
            }

            foreach (string file in files)
            {
                using (Bitmap bmp = new Bitmap(file))
                {
                    int _x = int.Parse(txt_x.Text);
                    int _y = int.Parse(txt_y.Text);
                    int _x_dbl = int.Parse(txt_x.Text) * 2; // 212 x 2 --> 424
                    int _y_dbl = int.Parse(txt_y.Text) * 2;
                    int _x_cut = int.Parse(txt_x.Text) / 2;
                    int _y_cut = int.Parse(txt_y.Text) / 2;
                    Bitmap resized = new Bitmap(bmp, new Size(_x_dbl, _y_dbl)); // 이미지 확대
                    Bitmap cropped = resized.Clone(
                        new Rectangle(_x_cut, _y_cut, _x, _y), resized.PixelFormat); // 이미지 자르기
                    string output = file.Replace(path, path + "\\output");
                    txt_log.AppendText("\r\n" + output);
                    cropped.Save(output, ImageFormat.Png); // PNG로 저장
                }
            }
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_folder.Text = fbd.SelectedPath;
            }
        }

        private void btn_make17_Click(object sender, EventArgs e)
        {
            string sourceFolder = txt_folder.Text; // 이미지 파일이 저장된 폴더 경로
            string destinationFolder = sourceFolder + "\\output2"; // 결과 이미지 파일이 저장될 폴더 경로
            string[] imageFiles = { "skeleton-Walk_0.png", "skeleton-Walk_1.png", "skeleton-Walk_2.png", "skeleton-Walk_3.png" };
            if (Directory.Exists(destinationFolder) == false)
            {
                Directory.CreateDirectory(destinationFolder);
            }
            int count = 0;
            for (int i = 0; i < 18; i++)
            {
                string sourceFilePath = Path.Combine(sourceFolder, imageFiles[count]);
                string destfile = "skeleton-Walk_" + i + ".png";
                string destinationFilePath = Path.Combine(destinationFolder, destfile);
                txt_log.AppendText("\r\n" + destfile);
                File.Copy(sourceFilePath, destinationFilePath, true);

                count++;
                if (count == 4)
                {
                    count = 0;
                }
            }
        }

        private void btn_chgSize_Click(object sender, EventArgs e)
        {
            string sourceFolder = txt_folder.Text; // 이미지 파일이 저장된 폴더 경로
            string destinationFolder = txt_folder.Text + "\\resized";
            int newWidth = int.Parse(txt_x2.Text); // 변경할 이미지의 가로 크기
            int newHeight = int.Parse(txt_y2.Text); // 변경할 이미지의 세로 크기

            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            foreach (string filePath in Directory.GetFiles(sourceFolder, "*.png"))
            {
                string fileName = Path.GetFileName(filePath);
                string destinationFilePath = Path.Combine(destinationFolder, fileName);
                ResizeImage(filePath, destinationFilePath, newWidth, newHeight);
                txt_log.AppendText("\r\n" + destinationFilePath);
            }
        }

        private static void ResizeImage(string sourceFilePath, string destinationFilePath, int newWidth, int newHeight)
        {
            using (Image sourceImage = Image.FromFile(sourceFilePath))
            {
                using (Bitmap bitmap = new Bitmap(newWidth, newHeight))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(sourceImage, 0, 0, newWidth, newHeight);
                        bitmap.Save(destinationFilePath, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
        }

        private void btn_NameChange_Click(object sender, EventArgs e)
        {
            string sourceFolder = txt_folder.Text; // 파일이 저장된 폴더 경로
            string prefix = txt_newFileName.Text;  // 새 파일명의 앞부분
            string suffix = ".png"; // 새 파일명의 뒷부분
            string destinationFolder = txt_folder.Text + "\\rename";
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }
            foreach (string filePath in Directory.GetFiles(sourceFolder, "*.png"))
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                txt_log.AppendText("\r\n" + fileName);
                int numberStartIndex = fileName.Length - 3; // 최대 999
                string numberString = fileName.Substring(numberStartIndex);
                numberString = Regex.Replace(numberString, @"[^0-9]", "");
                //txt_log.AppendText("\r\n" + numberString);
                int number;
                if (int.TryParse(numberString, out number))
                {
                    string newFileName = prefix + numberString + suffix;
                    string newFilePath = Path.Combine(destinationFolder, newFileName);
                    File.Copy(filePath, newFilePath, true);
                    txt_log.AppendText("\r\n" + newFilePath);
                }
            }
        }

        private void btn_make26_Click(object sender, EventArgs e)
        {
            string sourceFolder = txt_folder.Text; // 이미지 파일이 저장된 폴더 경로
            string destinationFolder = sourceFolder + "\\output26"; // 결과 이미지 파일이 저장될 폴더 경로
            string[] imageFiles = { "death0.png", "death1.png", "death2.png", "death3.png" };
            if (Directory.Exists(destinationFolder) == false)
            {
                Directory.CreateDirectory(destinationFolder);
            }
            int count = 0;
            for (int i = 0; i < 26; i++)
            {
                switch (i)
                {
                    case 0 or 1 or 2 or 3 or 4 or 5 or 6: count = 0; break;
                    case 7 or 8 or 9 or 10 or 11 or 12 or 13: count = 1; break;
                    case 14 or 15 or 16 or 17 or 18 or 19 or 20: count = 2; break;
                    case 21 or 22 or 23 or 24 or 25: count = 3; break;
                }

                string sourceFilePath = Path.Combine(sourceFolder, imageFiles[count]);
                string destfile = "skeleton-Walk_" + i + ".png";
                string destinationFilePath = Path.Combine(destinationFolder, destfile);
                txt_log.AppendText("\r\n" + destfile);
                File.Copy(sourceFilePath, destinationFilePath, true);
            }

        }
    }
}
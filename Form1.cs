using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Net.Mime.MediaTypeNames;

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
            string path = txt_folder.Text; // ��� ���� ���
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
                    Bitmap resized = new Bitmap(bmp, new Size(_x_dbl, _y_dbl)); // �̹��� Ȯ��
                    Bitmap cropped = resized.Clone(
                        new Rectangle(_x_cut, _y_cut, _x, _y), resized.PixelFormat); // �̹��� �ڸ���
                    string output = file.Replace(path, path + "\\output");
                    txt_log.AppendText("\r\n" + output);
                    cropped.Save(output, ImageFormat.Png); // PNG�� ����
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
            string sourceFolder = txt_folder.Text; // �̹��� ������ ����� ���� ���
            string destinationFolder = sourceFolder + "\\output2"; // ��� �̹��� ������ ����� ���� ���
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
            string sourceFolder = txt_folder.Text; // �̹��� ������ ����� ���� ���
            string destinationFolder = txt_folder.Text + "\\resized";
            int newWidth = int.Parse(txt_x2.Text); // ������ �̹����� ���� ũ��
            int newHeight = int.Parse(txt_y2.Text); // ������ �̹����� ���� ũ��

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
            using (System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(sourceFilePath))
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
            string sourceFolder = txt_folder.Text; // ������ ����� ���� ���
            string prefix = txt_newFileName.Text;  // �� ���ϸ��� �պκ�
            string suffix = ".png"; // �� ���ϸ��� �޺κ�
            string destinationFolder = txt_folder.Text + "\\rename";
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }
            foreach (string filePath in Directory.GetFiles(sourceFolder, "*.png"))
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                txt_log.AppendText("\r\n" + fileName);
                int numberStartIndex = fileName.Length - 3; // �ִ� 999
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
            string sourceFolder = txt_folder.Text; // �̹��� ������ ����� ���� ���
            string destinationFolder = sourceFolder + "\\output26"; // ��� �̹��� ������ ����� ���� ���
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

        /// <summary>
        /// skeleton-Walk_.png  �� 0����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NameChangeP1_Click(object sender, EventArgs e)
        {
            string sourceFolder = txt_folder.Text; // ������ ����� ���� ���
            string prefix = txt_newFileName.Text;  // �� ���ϸ��� �պκ�
            string suffix = ".png"; // �� ���ϸ��� �޺κ�
            string destinationFolder = txt_folder.Text + "\\rename2";
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }
            foreach (string filePath in Directory.GetFiles(sourceFolder, "*.png"))
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                txt_log.AppendText("\r\n" + fileName);
                int numberStartIndex = fileName.Length - 3; // �ִ� 999
                string numberString = fileName.Substring(numberStartIndex);
                numberString = Regex.Replace(numberString, @"[^0-9]", "");
                //txt_log.AppendText("\r\n" + numberString);
                int number;
                if (int.TryParse(numberString, out number))
                {
                    int numberString_Minus = Int32.Parse(numberString) - 1;
                    string newFileName = prefix + numberString_Minus + suffix;
                    string newFilePath = Path.Combine(destinationFolder, newFileName);
                    File.Copy(filePath, newFilePath, true);
                    txt_log.AppendText("\r\n" + newFilePath);
                }
            }
        }

        private void Btn_ImgFlip_Click(object sender, EventArgs e)
        {
            string sourceFolder = txt_folder.Text; // ���� �̹����� �ִ� ���� ���
            string destinationFolder = txt_folder.Text + "\\flip"; ; // ����� �̹����� ������ ���� ���
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }
            // �ҽ� ������ �ִ� ��� PNG ������ �����ɴϴ�.
            string[] files = Directory.GetFiles(sourceFolder, "*.png");

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string targetPath = Path.Combine(destinationFolder, fileName);

                // �̹����� �¿�� �������ϴ�.
                using (System.Drawing.Image image = System.Drawing.Image.FromFile(file))
                {
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    image.Save(targetPath, ImageFormat.Png);
                }
                //Console.WriteLine("��ȯ �Ϸ�: " + targetPath);
            }
            txt_log.AppendText("\r\n��� ���� ��ȯ �Ϸ�.");
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {

            string sourceFolder = txt_folder.Text; // ���� �̹����� �ִ� ���� ���
            string destinationFolder = txt_folder.Text + "\\split"; ; // ����� �̹����� ������ ���� ���
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            int n = 0; // �� �࿡ �� �̹��� ����

            // �������� �̹��� ���� ��� ��������
            string[] imageFiles = Directory.GetFiles(sourceFolder, "*.png");
            if (imageFiles.Length == 0)
            {
                txt_log.AppendText("\r\n������ �̹��� ������ �����ϴ�.");
                return;
            }

            int imageWidth,imageHeight, canvasWidth,canvasHeight = 0;

            // �̹��� ������ ũ��� �� �࿡ �� �̹��� ���� ���
            using (var image = new Bitmap(imageFiles[0]))
            {
                imageWidth = image.Width;
                imageHeight = image.Height;

                canvasWidth = imageWidth * imageFiles.Length;
                canvasHeight = imageHeight;

                // ĵ���� ũ��� �� �࿡ �� �̹��� ���� ���
                n = canvasWidth / imageWidth;
            }

            // �̹��� ���� ����� n���� ������ n�� ���� ������ ����
            if (imageFiles.Length < n)
            {
                n = imageFiles.Length;
            }

            // ĵ���� ����
            Bitmap canvas = new Bitmap(n * imageWidth, canvasHeight);
            Graphics graphics = Graphics.FromImage(canvas);

            // �̹��� ���� ������ŭ �ݺ��Ͽ� �ռ�
            for (int i = 0; i < n; i++)
            {
                // �̹��� ���� �ε�
                Bitmap image = new Bitmap(imageFiles[i]);

                // �̹����� ĵ������ �׸���
                graphics.DrawImage(image, i * imageWidth, 0);

                // ����� �̹��� ��ü ����
                image.Dispose();
            }

            // ĵ������ ���Ϸ� ����
            string outputFilePath = destinationFolder+"\\split.png";
            canvas.Save(outputFilePath);

            // ����� ���ҽ� ����
            graphics.Dispose();
            canvas.Dispose();
            txt_log.AppendText("\r\n�̹��� �ռ��� �Ϸ�Ǿ����ϴ�.");
        }
    }
}
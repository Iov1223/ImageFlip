using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ImageFlip
{
    public partial class Form1 : Form
    {
        private string path;

        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChoice_Click(object sender, EventArgs e)
        {
            SelectDirectory selectDirectory = new SelectDirectory();
            path = selectDirectory.select();
            MessageBox.Show("Вывбран: " + path + "\nKонечный результат будет по этому пути в папке \"После\".");
        }

        private void buttonParallel_Click(object sender, EventArgs e)
        {
            try
            {
                sw.Reset();
                this.Text = "Идёт работа";
                FlipPicture flipPicture = new FlipPicture(path);
                sw.Start();
                flipPicture.flip_parallel();
                sw.Stop();
                this.Text = "Работа завершена";
                richTextBox1.Text += $"\nВремя работы класса <<Parallel>> = {sw.Elapsed}";
            }
            catch
            {
                MessageBox.Show("Нужно выбрать папку!");
            }
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            try
            {
                sw.Reset();
                this.Text = "Идёт работа";
                FlipPicture flipPicture = new FlipPicture(path);
                sw.Start();
                flipPicture.flip_task();
                sw.Stop();
                this.Text = "Работа завершена";
                richTextBox1.Text += $"\nВремя работы класса <<Task>> = {sw.Elapsed}";
            }
            catch
            {
                MessageBox.Show("Нужно выбрать папку!");
            }
        }

        private void buttonThread_Click(object sender, EventArgs e)
        {
            try
            {
                sw.Reset();
                this.Text = "Идёт работа";
                FlipPicture flipPicture = new FlipPicture(path);
                sw.Start();
                flipPicture.flip_thread();
                sw.Stop();
                this.Text = "Работа завершена";
                richTextBox1.Text += $"\nВремя работы класса <<Thread>> = {sw.Elapsed}";
            }
            catch
            {
                MessageBox.Show("Нужно выбрать папку!");
            }
        }
    }

    public class SelectDirectory
    {
        public string select()
        {
            string path = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            folderBrowserDialog1.SelectedPath = "C:\\";
            folderBrowserDialog1.ShowNewFolderButton = false;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                return path;
            }
            else
            {
                MessageBox.Show("Файл не выбран.");
                return null;
            }

        }
    }
    public class FlipPicture
    {
        private string afterDirectory;

        private string[] files;

        public FlipPicture(string _path)
        {
            afterDirectory = Path.Combine(Directory.GetParent(_path).FullName, "После");
            files = Directory.GetFiles(_path, "*.jpg", SearchOption.AllDirectories);
        }
        private void delete_create()
        {
            if (Directory.Exists(afterDirectory))
            {
                Directory.Delete(afterDirectory, true);
            }
            Directory.CreateDirectory(afterDirectory);

        }

        public void flip_parallel()
        {
            delete_create();
            try
            {
                Parallel.ForEach(files,
                    filename =>
                    {
                        using (Bitmap bitmap = new Bitmap(filename))
                        {
                            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            string modFile = Path.Combine(afterDirectory, Path.GetFileName(filename) + ".new.jpg");
                            bitmap.Save(modFile);
                        }
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так: " + ex.Message);
            }
        }

        private void _task()
        {
            try
            {
                foreach (string item in files)
                {
                    string filename = Path.GetFileName(item);
                    using (Bitmap bitmap = new Bitmap(item))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        string modFile = Path.Combine(afterDirectory, filename);
                        bitmap.Save(modFile);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так: " + ex.Message);
            }
        }
        public void flip_task()
        {
            delete_create();

            _task();
        }

        public void flip_thread()
        {
            delete_create();

            try
            {
                Thread thread = new Thread(new ThreadStart(_task));
                thread.Priority = ThreadPriority.Highest;
                thread.Start();
                if (thread.IsAlive)
                {
                    thread.Join();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так: " + ex.Message);
            }
        }
    }

}


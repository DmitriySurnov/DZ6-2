using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace DZ6_2
{
    public partial class Form1 : Form
    {
        List<string> path;
        public Form1()
        {
            InitializeComponent();
            path = new List<string>();
            serchDisk();
            Razmer();
        }

        private void Razmer()
        {
            listBox1.Width = (Width / 2) - 5;
            listBox2.Width = (Width / 2) - 5;
            int left = listBox2.Width - 90;
            pathToolStripTextBox.Size = new Size(Width - 150, 28);
            col2ElementToolStripLabel.Margin = new Padding(left, 1, 0, 2);
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Razmer();
        }

        public void serchDisk()
        {
            DriveInfo[] drive = DriveInfo.GetDrives();
            colElementToolStripLabel.Text = $"Элементов: {drive.Length}";
            col2ElementToolStripLabel.Text = $"Элементов: 0";
            foreach (DriveInfo item in drive)
            {
                listBox1.Items.Add(item);
            }
        }

        private string GetAdress(ListBox LB)
        {
            string adress;
            if (pathToolStripTextBox.Text == ".")
                adress = pathToolStripTextBox.Text;
            else if (pathToolStripTextBox.Text == "")
                adress = LB.Text;
            else
            {
                if (pathToolStripTextBox.Text.Length == 3)
                    adress = pathToolStripTextBox.Text + LB.Text;
                else
                    adress = pathToolStripTextBox.Text + "\\" + LB.Text;
            }
                
            return adress;
        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            if (path.Count > 0)
                pathToolStripTextBox.Text = path[path.Count - 1];
            else
            {
                pathToolStripTextBox.Text = "";
                pathToolStripTextBox.Visible = false;
            }
            try
            {
                if (listBox1.SelectedIndex == -1)
                    return;
                string adress = GetAdress(listBox1);
                listBox2.Items.Clear();
                string[] Content = Directory.GetDirectories(adress);
                foreach (var item in Content)
                {
                    string[] s = item.Split('\\');
                    listBox2.Items.Add(s[s.Length - 1]);
                }
                Content = Directory.GetFiles(adress);
                foreach (var item in Content)
                {
                    string[] s = item.Split('\\');
                    listBox2.Items.Add(s[s.Length - 1]);
                }
                col2ElementToolStripLabel.Text = $"Элементов: {listBox2.Items.Count}";
            }
            catch (Exception)
            {
                col2ElementToolStripLabel.Text = $"Элементов: {listBox2.Items.Count}";
                MessageBox.Show("Невозможно открыть директорию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex == -1 || pathToolStripTextBox.Text == ".")
                    return;
                OpenDirectories(listBox1);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно открыть директорию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path.Count == 0)
                return;
            if (path.Count == 1)
            {
                path.RemoveAt(path.Count - 1);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                serchDisk();//поиск дисков
                pathToolStripTextBox.Visible = false;
                pathToolStripTextBox.Text = "";
            }
            else
            {
                path.RemoveAt(path.Count - 1);
                SerchFile(path[path.Count - 1]);
            }
        }

        private void SerchFile(string adress)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Add(".");
            string[] Content = Directory.GetDirectories(adress);
            if (!pathToolStripTextBox.Visible)
                pathToolStripTextBox.Visible = true;
            pathToolStripTextBox.Text = adress;
            foreach (var item in Content)
            {
                string[] s = item.Split('\\');
                listBox2.Items.Add(s[s.Length - 1]);
                listBox1.Items.Add(s[s.Length - 1]);
            }
            Content = Directory.GetFiles(adress);
            foreach (var item in Content)
            {
                string[] s = item.Split('\\');
                listBox2.Items.Add(s[s.Length - 1]);
            }
            col2ElementToolStripLabel.Text = $"Элементов: {listBox2.Items.Count}";
            colElementToolStripLabel.Text = $"Элементов: {listBox1.Items.Count - 1}";
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            backContextToolStripItem.Enabled = path.Count != 0;
            openToolStripItem.Enabled = (listBox1.SelectedIndex != -1 || listBox2.SelectedIndex != -1) && listBox1.Text != ".";
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backToglToolStripMenuItem.Enabled = path.Count != 0;
            openToolStripMenuItem.Enabled = (listBox1.SelectedIndex != -1 || listBox2.SelectedIndex != -1) && listBox1.Text != ".";
        }

        private void ListBox2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || listBox1.Text == ".")
                return;
            if (!pathToolStripTextBox.Visible)
                pathToolStripTextBox.Visible = true;
            pathToolStripTextBox.Text = GetAdress(listBox1);
            listBox1.ClearSelected();
        }

        private void OpenDirectories(ListBox LB)
        {
            string adress = GetAdress(LB);
            SerchFile(adress);
            path.Add(adress);
        }

        private void OpenDirectoriesAndFille()
        {
            try
            {
                string adress = GetAdress(listBox2);
                if (File.Exists(adress))//проверка на файл или папку
                    Process.Start(adress);//запуск файла
                else
                {
                    path.Add(pathToolStripTextBox.Text);
                    OpenDirectories(listBox2);//поиск файлов, папок
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно открыть директорию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListBox2_DoubleClick(object sender, EventArgs e)
        {
            OpenDirectoriesAndFille();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                OpenDirectories(listBox1);
            else
                OpenDirectoriesAndFille();
        }
    }
}

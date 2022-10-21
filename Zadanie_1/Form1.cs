using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDz_4
{
    public partial class Form1 : Form
    {
        private string path { get; set; }
        private bool Change = false;
        public Form1()
        {
            InitializeComponent();

            //fontToolStripButton.Click += FontToolStripButton_Click;
            //fontToolStripMenuItem.Click += FontToolStripButton_Click;
        }

        private void FontToolStripButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = dialog.Font;
            }

        }

        private void ColorBackToolStripButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.BackColor = dialog.Color;
            }
        }

        private void ColorFontToolStripButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = dialog.Color;
            }
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void CancelContextToolStrip_Click(object sender, EventArgs e)
        {
            if (textBox.CanUndo == true)
            {
                textBox.Undo();
                textBox.ClearUndo();
            }
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void InsertToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            if (textBox.TextLength > 0)
                textBox.Copy();
        }

        private void SaveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Text = $"Текстовый редактор - {dialog.FileName}";
                path = dialog.FileName;
                StreamWriter writing = new StreamWriter(dialog.FileName, false, Encoding.Default);
                writing.Write(textBox.Text);
                writing.Close();
                Change = false;
            }
        }
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                StreamWriter writing = new StreamWriter(path, false, Encoding.Default);
                writing.Write(textBox.Text);
                writing.Close();
            }
            else
                SaveFileAsToolStripMenuItem_Click(sender, e);
            Text = $"Текстовый редактор - {path}";
            Change = false;
        }

        private void IsChange(object sender, EventArgs e)
        {
            if (!Change)
                return;
            var otvet = MessageBox.Show("Хотите сохранить изменеия", 
                "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (otvet == DialogResult.Yes)
                SaveFileToolStripMenuItem_Click(sender, e);
            Change = false;
        }

        private void Enable()
        {
            if (insertToolStripButton.Enabled)
                return;
            textBox.ReadOnly = false;
            contextMenuStrip.Enabled = true;
            saveFileAsToolStripMenuItem.Enabled = true;
            saveFileToolStripMenuItem.Enabled = true;
            cutToolStripMenuItem.Enabled = true;
            copyToolStripMenuItem.Enabled = true;
            insertToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            selectAllToolStripMenuItem.Enabled = true;
            saveToolStripButton.Enabled = true;
            copyToolStripButton.Enabled = true;
            cutToolStripButton.Enabled = true;
            insertToolStripButton.Enabled = true;
            copyContextToolStrip.Enabled = true;
            cutContextToolStrip.Enabled = true;
            insertContextToolStrip.Enabled = true;
            cancelContextToolStrip.Enabled = true;
            insertToolStripButton.Enabled = true;
            cancelToolStripButton.Enabled = true;
        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsChange(sender, e);
            path = "";
            textBox.Text = "";
            Enable();
            Text = $"Новый текстовый документ";
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
         {
            IsChange(sender, e);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            dialog.FilterIndex = 2;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Enable();
                path = dialog.FileName;
                Text = $"Текстовый редактор - {path}";
                StreamReader reading = new StreamReader(dialog.FileName, Encoding.Default);
                textBox.Text = reading.ReadToEnd();
                reading.Close();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Change)
                return;
            Change = true;
            Text += "*";
        }
    }
}

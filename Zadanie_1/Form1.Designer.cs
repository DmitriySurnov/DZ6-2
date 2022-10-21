namespace WindowsFormsDz_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.insertToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorFontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorBackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyContextToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cutContextToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.insertContextToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelContextToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openFileToolStripButton,
            this.saveToolStripButton,
            this.copyToolStripButton,
            this.cutToolStripButton,
            this.insertToolStripButton,
            this.cancelToolStripButton,
            this.colorFontToolStripButton,
            this.colorBackToolStripButton,
            this.fontToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 674);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip.Size = new System.Drawing.Size(1416, 39);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(94, 36);
            this.newToolStripButton.Text = "Новый";
            this.newToolStripButton.Click += new System.EventHandler(this.NewFileToolStripMenuItem_Click);
            // 
            // openFileToolStripButton
            // 
            this.openFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripButton.Image")));
            this.openFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileToolStripButton.Name = "openFileToolStripButton";
            this.openFileToolStripButton.Size = new System.Drawing.Size(112, 36);
            this.openFileToolStripButton.Text = "Открыть";
            this.openFileToolStripButton.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(135, 36);
            this.saveToolStripButton.Text = "Сохранить";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.copyToolStripButton.Enabled = false;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(150, 36);
            this.copyToolStripButton.Text = "Копировать";
            this.copyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cutToolStripButton.Enabled = false;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(122, 36);
            this.cutToolStripButton.Text = "Вырезать";
            this.cutToolStripButton.Click += new System.EventHandler(this.CutToolStripButton_Click);
            // 
            // insertToolStripButton
            // 
            this.insertToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.insertToolStripButton.Enabled = false;
            this.insertToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("insertToolStripButton.Image")));
            this.insertToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertToolStripButton.Name = "insertToolStripButton";
            this.insertToolStripButton.Size = new System.Drawing.Size(115, 36);
            this.insertToolStripButton.Text = "Вставить";
            this.insertToolStripButton.Click += new System.EventHandler(this.InsertToolStripButton_Click);
            // 
            // colorFontToolStripButton
            // 
            this.colorFontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorFontToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colorFontToolStripButton.Image")));
            this.colorFontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorFontToolStripButton.Name = "colorFontToolStripButton";
            this.colorFontToolStripButton.Size = new System.Drawing.Size(165, 36);
            this.colorFontToolStripButton.Text = "Цвет шрифта";
            this.colorFontToolStripButton.Click += new System.EventHandler(this.ColorFontToolStripButton_Click);
            // 
            // colorBackToolStripButton
            // 
            this.colorBackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.colorBackToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colorBackToolStripButton.Image")));
            this.colorBackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorBackToolStripButton.Name = "colorBackToolStripButton";
            this.colorBackToolStripButton.Size = new System.Drawing.Size(136, 36);
            this.colorBackToolStripButton.Text = "Цвет фона";
            this.colorBackToolStripButton.Click += new System.EventHandler(this.ColorBackToolStripButton_Click);
            // 
            // fontToolStripButton
            // 
            this.fontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripButton.Image")));
            this.fontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontToolStripButton.Name = "fontToolStripButton";
            this.fontToolStripButton.Size = new System.Drawing.Size(96, 36);
            this.fontToolStripButton.Text = "Шрифт";
            this.fontToolStripButton.Click += new System.EventHandler(this.FontToolStripButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1416, 44);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveFileAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.newFileToolStripMenuItem.Text = "Новый";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.NewFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.openFileToolStripMenuItem.Text = "Открыть";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Enabled = false;
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveFileToolStripMenuItem.Text = "Сохранить";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Enabled = false;
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveFileAsToolStripMenuItem.Text = "Сохранить как";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 38);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.cutToolStripMenuItem.Text = "Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripButton_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Enabled = false;
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.insertToolStripMenuItem.Text = "Вставить";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripButton_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Enabled = false;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.cancelToolStripMenuItem.Text = "Отменить";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelContextToolStrip_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(347, 38);
            this.selectAllToolStripMenuItem.Text = "Выделить все";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorFontToolStripMenuItem,
            this.colorBackToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.formatToolStripMenuItem.Text = "Формат";
            // 
            // colorFontToolStripMenuItem
            // 
            this.colorFontToolStripMenuItem.Name = "colorFontToolStripMenuItem";
            this.colorFontToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.colorFontToolStripMenuItem.Text = "Цвет шрифта";
            this.colorFontToolStripMenuItem.Click += new System.EventHandler(this.ColorFontToolStripButton_Click);
            // 
            // colorBackToolStripMenuItem
            // 
            this.colorBackToolStripMenuItem.Name = "colorBackToolStripMenuItem";
            this.colorBackToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.colorBackToolStripMenuItem.Text = "Цвет фона";
            this.colorBackToolStripMenuItem.Click += new System.EventHandler(this.ColorBackToolStripButton_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.fontToolStripMenuItem.Text = "Шрифт";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripButton_Click);
            // 
            // textBox
            // 
            this.textBox.ContextMenuStrip = this.contextMenuStrip;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(0, 44);
            this.textBox.Margin = new System.Windows.Forms.Padding(6);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(1416, 630);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Enabled = false;
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyContextToolStrip,
            this.cutContextToolStrip,
            this.insertContextToolStrip,
            this.cancelContextToolStrip});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip.Size = new System.Drawing.Size(305, 148);
            // 
            // copyContextToolStrip
            // 
            this.copyContextToolStrip.Enabled = false;
            this.copyContextToolStrip.Name = "copyContextToolStrip";
            this.copyContextToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyContextToolStrip.Size = new System.Drawing.Size(304, 36);
            this.copyContextToolStrip.Text = "Копировать";
            this.copyContextToolStrip.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // cutContextToolStrip
            // 
            this.cutContextToolStrip.Enabled = false;
            this.cutContextToolStrip.Name = "cutContextToolStrip";
            this.cutContextToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutContextToolStrip.Size = new System.Drawing.Size(304, 36);
            this.cutContextToolStrip.Text = "Вырезать";
            this.cutContextToolStrip.Click += new System.EventHandler(this.CutToolStripButton_Click);
            // 
            // insertContextToolStrip
            // 
            this.insertContextToolStrip.Enabled = false;
            this.insertContextToolStrip.Name = "insertContextToolStrip";
            this.insertContextToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.insertContextToolStrip.Size = new System.Drawing.Size(304, 36);
            this.insertContextToolStrip.Text = "Вставить";
            this.insertContextToolStrip.Click += new System.EventHandler(this.InsertToolStripButton_Click);
            // 
            // cancelContextToolStrip
            // 
            this.cancelContextToolStrip.Enabled = false;
            this.cancelContextToolStrip.Name = "cancelContextToolStrip";
            this.cancelContextToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cancelContextToolStrip.Size = new System.Drawing.Size(304, 36);
            this.cancelContextToolStrip.Text = "Отменить";
            this.cancelContextToolStrip.Click += new System.EventHandler(this.CancelContextToolStrip_Click);
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelToolStripButton.Enabled = false;
            this.cancelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelToolStripButton.Image")));
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(127, 36);
            this.cancelToolStripButton.Text = "Отменить";
            this.cancelToolStripButton.Click += new System.EventHandler(this.CancelContextToolStrip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 713);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton openFileToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton insertToolStripButton;
        private System.Windows.Forms.ToolStripButton colorFontToolStripButton;
        private System.Windows.Forms.ToolStripButton colorBackToolStripButton;
        private System.Windows.Forms.ToolStripButton fontToolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyContextToolStrip;
        private System.Windows.Forms.ToolStripMenuItem cutContextToolStrip;
        private System.Windows.Forms.ToolStripMenuItem insertContextToolStrip;
        private System.Windows.Forms.ToolStripMenuItem cancelContextToolStrip;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
    }
}


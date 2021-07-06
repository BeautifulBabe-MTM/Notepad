using System.Globalization;
using System.Windows.Forms;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace WindowsFormsApp19
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private System.ComponentModel.ComponentResourceManager resources;

        private void InitializeComponent()
        {
            resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.zhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripMenuItem3,
            this.closeAppToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // saveFileToolStripMenuItem
            // 
            resources.ApplyResources(this.saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Click += ToolStripMenuItem1_Click;
            // 
            // openFileToolStripMenuItem
            // 
            resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Click += OpenFileToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // closeAppToolStripMenuItem
            // 
            resources.ApplyResources(this.closeAppToolStripMenuItem, "closeAppToolStripMenuItem");
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.Click += CloseAppToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Click += ClearToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            resources.ApplyResources(this.colorToolStripMenuItem, "colorToolStripMenuItem");
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Click += ColorToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            resources.ApplyResources(this.fontToolStripMenuItem, "fontToolStripMenuItem");
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deDEToolStripMenuItem,
            this.ruToolStripMenuItem,
            this.toolStripMenuItem4,
            this.zhToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // deDEToolStripMenuItem
            // 
            resources.ApplyResources(this.deDEToolStripMenuItem, "deDEToolStripMenuItem");
            this.deDEToolStripMenuItem.Name = "deDEToolStripMenuItem";
            this.deDEToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ruToolStripMenuItem
            // 
            resources.ApplyResources(this.ruToolStripMenuItem, "ruToolStripMenuItem");
            this.ruToolStripMenuItem.Name = "ruToolStripMenuItem";
            this.ruToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // zhToolStripMenuItem
            // 
            resources.ApplyResources(this.zhToolStripMenuItem, "zhToolStripMenuItem");
            this.zhToolStripMenuItem.Name = "zhToolStripMenuItem";
            this.zhToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CloseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                    this.textBox1.Text = File.ReadAllText(openDialog.FileName);
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    this.textBox1.Font = dialog.Font;
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                    this.textBox1.BackColor = dialog.Color;
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "text|*.txt";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                    using (StreamWriter streamWriter = new StreamWriter(saveDialog.FileName))
                        streamWriter.WriteLine(this.textBox1.Text);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo((sender as ToolStripMenuItem).Text);
            foreach (Control c in this.Controls)
                resources.ApplyResources(c, c.Name, ci);

            foreach (ToolStripItem c in menuStrip1.Items)
            {
                foreach (ToolStripItem item in toolStripMenuItem1.DropDownItems)
                    resources.ApplyResources(item, item.Name, ci);
                resources.ApplyResources(c, c.Name, ci);
            }
        }
       
        private string LastTab = string.Empty;
        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem deDEToolStripMenuItem;
        private ToolStripMenuItem ruToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem zhToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem closeAppToolStripMenuItem;
    }
}


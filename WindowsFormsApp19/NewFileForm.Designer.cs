using System.Windows.Forms;

namespace WindowsFormsApp19
{
    partial class NewFileForm
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 50);
            this.Text = "NewFileForm";

            textBox = new TextBox();
            textBox.Dock = DockStyle.Bottom;
            textBox.TextChanged += (sender, args) =>
            {
                this.fileName = textBox.Text;
                //this.Dispose();
            };

            textLabel = new Label();
            textLabel.Size = new System.Drawing.Size(50, 50);
            //textLabel.Dock = DockStyle.Top;
            textLabel.Text = "File Name:";

            createButton = new Button();
            createButton.Size = new System.Drawing.Size(50, 25);
            createButton.Location = new System.Drawing.Point(150, 0);
            createButton.Text = "Create";
            createButton.Click += (sender, args) =>
            {
                this.fileName = textBox.Text;
                this.Dispose();
            };

            this.Controls.Add(textBox);
            this.Controls.Add(textLabel);
            this.Controls.Add(createButton);

        }

        private Label textLabel;
        private TextBox textBox;
        private Button createButton;

        #endregion
    }
}
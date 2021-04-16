using System.Drawing;
using System.Windows.Forms;

namespace Notepad
{
    partial class Form3
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
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Color";

            comboSize = new ComboBox();
            comboSize.Location = new Point(10, 10);
            comboSize.SelectedIndexChanged += changeSize;
            comboSize.Text = "Size";
            for (int i = 0; i < 24; i++)
            {
                comboSize.Items.Add(i);
            }
            comboSize.DropDownStyle = ComboBoxStyle.DropDown;


            comboStyle = new ComboBox();
            comboStyle.Location = new Point(10, 50);
            comboStyle.SelectedIndexChanged += changeStyle;
            comboStyle.Text = "Style";
            comboStyle.Items.Add("Bold");
            comboStyle.Items.Add("Italic");
            comboStyle.Items.Add("Strikeout");
            comboStyle.Items.Add("Underline");
            comboStyle.Items.Add("Regular");
            comboStyle.DropDownStyle = ComboBoxStyle.DropDown;

            comboShrift = new ComboBox();
            comboShrift.Location = new Point(10, 90);
            comboShrift.SelectedIndexChanged += changeShrift;
            comboShrift.Text = "Shrift";
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
               comboShrift.Items.Add(font.Name);
            }
            comboShrift.DropDownStyle = ComboBoxStyle.DropDown;

            this.Controls.Add(comboSize);
            this.Controls.Add(comboStyle);
            this.Controls.Add(comboShrift);
        }


        private ComboBox comboShrift;
        private ComboBox comboSize;
        private ComboBox comboStyle;

        #endregion
    }
}
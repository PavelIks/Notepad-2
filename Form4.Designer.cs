using System.Drawing;
using System.Windows.Forms;

namespace Notepad
{
    partial class Form4
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
            this.ClientSize = new System.Drawing.Size(500,500);
            this.Text = "Color";

            comboBackColor = new ComboBox();
            comboBackColor.Location = new Point(10, 10);
            comboBackColor.SelectedIndexChanged += changeBackground;
            comboBackColor.Text = "Background color";
            comboBackColor.Items.Add("Aquamarine");
            comboBackColor.Items.Add("BlueViolet");
            comboBackColor.Items.Add("DeepPink");
            comboBackColor.Items.Add("Red");
            comboBackColor.Items.Add("Orange");
            comboBackColor.Items.Add("Chartreuse");
            comboBackColor.DropDownStyle = ComboBoxStyle.DropDown;


            comboForeColor = new ComboBox();
            comboForeColor.Location = new Point(10, 50);
            comboForeColor.SelectedIndexChanged += changeForeground;
            comboForeColor.Text = "Foreground color";
            comboForeColor.Items.Add("Aquamarine");
            comboForeColor.Items.Add("BlueViolet");
            comboForeColor.Items.Add("DeepPink");
            comboForeColor.Items.Add("Red");
            comboForeColor.Items.Add("Orange");
            comboForeColor.Items.Add("Chartreuse");
            comboForeColor.DropDownStyle = ComboBoxStyle.DropDown;

            this.Controls.Add(comboBackColor);
            this.Controls.Add(comboForeColor);
        }



        private ComboBox comboBackColor;
        private ComboBox comboForeColor;
        #endregion
    }
}
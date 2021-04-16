using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form2
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
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Form2";

            button1 = new Button();
            button1.Size = new Size();
            button1.Click += text_changed;
            button1.KeyDown += press;

            infolabel = new Label();
            infolabel.Location = new Point(10, 10);
            infolabel.Size = new Size(300, 50);
            infolabel.Text = "Enter 1 - open text in file; 2 - put text in begin of files;\n3.put text in end of files; 4.nothing;\n5. save only text in textbox.";
            
            this.Controls.Add(infolabel);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);
            this.Controls.Add(button5);
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;

        private Label infolabel;
        #endregion
    }
}
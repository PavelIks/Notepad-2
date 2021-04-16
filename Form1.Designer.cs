using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace WindowsFormsApp1
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300,300);
            this.Text = "Troshchylo";
            this.MinimumSize =this.MaximumSize= this.Size =new Size(300, 300);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;


            //
            //Button open
            //
            buttonOpen = new Button();
            buttonOpen.Location = new Point(210, 10);
            buttonOpen.Size = new Size(60,40);
            buttonOpen.Text = "open";
            buttonOpen.Click += open_button;

            //
            //Button save
            //
            buttonSave = new Button();
            buttonSave.Location = new Point(210, 60);
            buttonSave.Size = new Size(60, 40);
            buttonSave.Text = "save";
            buttonSave.Click += save_button;
            buttonSave.Visible = false;


            //
            //Button save as
            //
            buttonSaveAs = new Button();
            buttonSaveAs.Location = new Point(210, 110);
            buttonSaveAs.Size = new Size(60, 40);
            buttonSaveAs.Text = "save as";
            buttonSaveAs.Click += save_as_button;

            //
            //Button Color
            //
            buttonColor = new Button();
            buttonColor.Location = new Point(210, 160);
            buttonColor.Size = new Size(60, 40);
            buttonColor.Text = "color";
            buttonColor.Click += color_button;

            //
            //Button Font
            //
            buttonFont = new Button();
            buttonFont.Location = new Point(210, 210);
            buttonFont.Size = new Size(60, 40);
            buttonFont.Text = "font";
            buttonFont.Click += font_button;

            //
            // textbox 
            //
            textbox = new TextBox();
            textbox.Location = new Point(0, 0);
            textbox.Size = new Size(200,300);
            textbox.Multiline = true;
            

            //
            // Controls
            //
            this.Controls.Add(textbox);
            this.Controls.Add(buttonSaveAs);
            this.Controls.Add(buttonOpen);
            this.Controls.Add(buttonSave);
            this.Controls.Add(buttonFont);
            this.Controls.Add(buttonColor);


        }


        private TextBox textbox;


        private Button buttonOpen;
        private Button buttonSave;
        private Button buttonSaveAs;
        private Button buttonFont;
        private Button buttonColor;






        #endregion
    }
}


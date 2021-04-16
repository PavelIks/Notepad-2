using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        string path = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void open_button(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text file (*txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                MessageBox.Show(File.ReadAllText(open.FileName));
                buttonSaveAs.Visible = false;
                buttonSave.Visible = true;
                this.Text = path;
            }
            if (textbox.Text.ToString() != "")
            {
                Form2 form = new Form2();
                form.ShowDialog();
                string ch = form.Local_text;
                if (ch == "1")
                {
                    string text = textbox.Text.ToString();
                    string[] str = text.Split('\n');
                    File.AppendAllLines(path, str);
                    MessageBox.Show(File.ReadAllText(open.FileName));

                }
                if (ch == "2")
                {
                    string str1 = File.ReadAllText(path);
                    string text = textbox.Text.ToString();
                    string[] str = text.Split('\n');
                    File.WriteAllLines(path, str);
                    File.AppendAllText(path, str1);
                    MessageBox.Show(File.ReadAllText(open.FileName));
                }
                if (ch == "3")
                {
                    string text = textbox.Text.ToString();
                    string[] str = text.Split('\n');
                    File.AppendAllLines(path, str);
                    MessageBox.Show(File.ReadAllText(open.FileName));
                }
                if (ch == "4")
                {
                    Application.Restart();
                }
                if (ch == "5")
                {
                    string text = textbox.Text.ToString();
                    string[] str = text.Split('\n');
                    File.WriteAllLines(path, str);
                    MessageBox.Show(File.ReadAllText(open.FileName));
                }


            }
        }

        private void save_button(object sender, EventArgs e)
        {
            if (Directory.Exists(path))
            {
                string text = textbox.Text.ToString();
                string[] str = text.Split('\n');
                File.AppendAllLines(path, str);
            }
        }

        private void save_as_button(object sender, EventArgs e)
        {
                SaveFileDialog save = new SaveFileDialog();
                string text = textbox.Text.ToString();
                string[] str = text.Split('\n');
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(save.FileName, str);
                }
        }

        private void font_button(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            int size = Convert.ToInt32(form.size);
                if (form.style == "0")
                {
                    this.Font = new Font(form.shrift, size, FontStyle.Bold);
                    textbox.Font = new Font(form.shrift, size, FontStyle.Bold);
                }
                if (form.style == "1")
                {
                    this.Font = new Font(form.shrift, size, FontStyle.Italic);
                    textbox.Font = new Font(form.shrift, size, FontStyle.Italic);
                }
                if (form.style == "2")
                {
                    this.Font = new Font(form.shrift, size, FontStyle.Strikeout);
                    textbox.Font = new Font(form.shrift, size, FontStyle.Strikeout);
                }
                if (form.style == "3")
                {
                    this.Font = new Font(form.shrift, size, FontStyle.Underline);
                    textbox.Font = new Font(form.shrift, size, FontStyle.Underline);
                }
                if (form.style == "4")
                {
                    this.Font = new Font(form.shrift, size, FontStyle.Regular);
                    textbox.Font = new Font(form.shrift, size, FontStyle.Regular);
                }
        }

        private void color_button(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            form1.ShowDialog();

                string changedBcolor = form1.backcolor;
                string changedFcolor = form1.forecolor;
            if (changedBcolor != null && changedFcolor != null)
            {
                textbox.BackColor = Color.FromName(changedBcolor);
                this.BackColor = Color.FromName(changedBcolor);
                textbox.ForeColor = Color.FromName(changedFcolor);
                this.ForeColor = Color.FromName(changedFcolor);
            }
        }
    }
}


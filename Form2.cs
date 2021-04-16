using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form2 : Form
    {
        public string Local_text { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        private void press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
        private void text_changed(object sender, EventArgs e)
        {
            Local_text = Text;
        }
    }
}

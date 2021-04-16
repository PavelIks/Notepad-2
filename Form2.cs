using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

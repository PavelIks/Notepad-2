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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string backcolor { get; set; }
        public string forecolor { get; set; }
        private void changeBackground(object sender, EventArgs e)
        {
            backcolor = comboBackColor.Items[comboBackColor.SelectedIndex].ToString();
        }

        private void changeForeground(object sender, EventArgs e)
        {
           forecolor = comboForeColor.Items[comboForeColor.SelectedIndex].ToString();
        }
    }
}

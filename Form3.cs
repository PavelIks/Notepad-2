using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string shrift { get; set; }
        public string size { get; set; }
        public string style { get; set; }
        private void changeShrift(object sender, EventArgs e)
        {
            shrift = comboShrift.Items[comboShrift.SelectedIndex].ToString();
        }

        private void changeSize(object sender, EventArgs e)
        {
            size = comboSize.SelectedIndex.ToString();
        }

        private void changeStyle(object sender, EventArgs e)
        {
            style = comboStyle.SelectedIndex.ToString();
        }
    }
}

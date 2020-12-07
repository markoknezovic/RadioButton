using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAvion.Checked) { textBox1.Text = "Odabrao si prijevoz avionom"; }
            if (radioButtonAutobus.Checked) { textBox1.Text = "Odabrao si prijevoz autobusom"; }
            if (radioButtonVlastiti.Checked) { textBox1.Text = "Odabrao si vlastiti prijevoz"; }
            
        }
    }
}

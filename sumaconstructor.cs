using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suma SUMA = new suma();
            SUMA.V1 = double.Parse(textBox1.Text);
            SUMA.V2 = double.Parse(textBox2.Text);

            textBox3.Text = SUMA.sumar().ToString();
        }
    }
}

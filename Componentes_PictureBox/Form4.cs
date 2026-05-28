using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_PictureBox
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.Text == "Procarionte")
            {
                pictureBox1.Image = Properties.Resources.download__4_;
            }
            else if(listBox1.Text == "Eucarionte Animal")
            {
                pictureBox1.Image = Properties.Resources.download__3_;
            }
            else if(listBox1.Text == "Eucarionte Vegetal")
            {
                pictureBox1.Image = Properties.Resources.download__5_;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

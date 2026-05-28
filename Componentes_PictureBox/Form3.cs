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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.icon;

            if(checkBox1.Checked == false)
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.icon__1_;

            if(checkBox2.Checked == false)
            {
                pictureBox2.Image = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.icon__2_;
            if(checkBox3.Checked == false)
            {
                pictureBox3.Image = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

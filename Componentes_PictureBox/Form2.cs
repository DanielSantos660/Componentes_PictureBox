using Componentes_PictureBox.Properties;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.pedal;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.amp;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.pedaleira;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

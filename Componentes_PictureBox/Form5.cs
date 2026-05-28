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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "O Incrível Mundo de Gumball":
                    pictureBox2.Image = Properties.Resources.upscalemedia_transformed__4_;
                    break;

                case "Hora de Aventura":
                    pictureBox2.Image = Properties.Resources.upscalemedia_transformed;
                    break;

                case "Apenas um Show":
                    pictureBox2.Image = Properties.Resources.upscalemedia_transformed__3_;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

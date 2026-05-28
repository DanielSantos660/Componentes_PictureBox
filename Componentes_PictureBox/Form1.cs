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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Show();  
            this.Hide();
            form2.Show();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.FormClosed += (s, args) => this.Show();
            this.Hide();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.FormClosed += (s, args) => this.Show();
            this.Hide();
            form4.Show();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.FormClosed += (s, args) => this.Show();
            this.Hide();
            form5.Show();
        }
    }
}

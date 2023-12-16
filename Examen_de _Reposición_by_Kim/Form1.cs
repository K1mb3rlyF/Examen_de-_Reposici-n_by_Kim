using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_de__Reposición_by_Kim
{
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }
        int N = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            N++;
            lblCargando.Text = "Cargando" + N.ToString() + "%";
            progressBar1.Value = N;
            if (N == 100)
            {
                timer1.Stop();
                this.Hide();
                Form2 ig = new Form2();
                ig.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            N++;
            lblCargando.Text = "Cargando" + N.ToString() + "%";
            progressBar1.Value = N;
            if (N == 100)
            {
                timer1.Stop();
                this.Hide();
                Form2 ig = new Form2();
                ig.Show();
            }
    }
}
        }

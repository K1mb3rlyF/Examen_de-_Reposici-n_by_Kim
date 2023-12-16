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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_parque_vehicular_Funes_KimberlyDataSet.tbl_vehiculos' Puede moverla o quitarla según sea necesario.
            this.tbl_vehiculosTableAdapter.Fill(this.db_parque_vehicular_Funes_KimberlyDataSet.tbl_vehiculos);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            if (btnNuevoVehiculo.Text == "Nuevo")
            {
                btnNuevoVehiculo.Text = "Guardar";
                btnModificarVehiculo.Text = "Cancelar";
              
            }
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            if (btnModificarVehiculo.Text == "Modificar")
            {
                btnNuevoVehiculo.Text = "Guardar";
                btnModificarVehiculo.Text = "Cancelar";
               
            }
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void jeepCompassSportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ig = new Form3();
            ig.Show();
        }

        private void jeepRenegadeLatitudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ig = new Form4();
            ig.Show();
        }

        private void jeepCherokeeTrailhawkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ig = new Form5();
            ig.Show();
        }

        private void jeepGrandCherokeeLimitedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 ig = new Form6();
            ig.Show();
        }

        private void jeepWranglerSportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 ig = new Form7();
            ig.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

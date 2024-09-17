using LanzamientoDadosEj1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace LanzamientoDadosEj1
{
    public partial class Form1 : Form
    {
        SimulDados simulacion = new SimulDados();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            simulacion.SimularTiradas(36000);
            int[] frecuencias = simulacion.GetFrecuencias();
            
            // Limpiar los resultados pasados
            LimpiarElementos();

            // Encabezado del formato tabular
            // Asegurar que el DataGridView tenga las columnas configuradas
            if (dgvResultados.Columns.Count == 0)
            {
                dgvResultados.Columns.Add("Suma", "Suma");
                dgvResultados.Columns.Add("Frecuencia", "Frecuencia");
            }

            // Agregar los resultados de las sumas al DataGridView
            for (int i = 2; i < frecuencias.Length; i++)
            {
                dgvResultados.Rows.Add(i, frecuencias[i]);
            }

            // se compruebe si la suma 7 se aproxima al 16.67% de las tiradas
            double probabilidad7 = (double)frecuencias[7] / 36000;
            tbProbabilidad.Text = $"\nFrecuencia estimada de la suma 7: {frecuencias[7]} veces.\n";
            tbProb7.Text = $"\nProbabilidad estimada de la suma 7: {probabilidad7:P2} (Debe ser aprox. 16.67%)";
        }

        public void LimpiarElementos()
        {
            dgvResultados.Rows.Clear();
            tbProbabilidad.Clear();
            tbProb7.Clear();
        }
    }
}

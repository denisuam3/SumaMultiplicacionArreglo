using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class SalesForm : Form
    {
        private Ventasresu salesSummary = new Ventasresu();
        public SalesForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                int Vendedor = int.Parse(tbVendor.Text);
                int Producto = int.Parse(tbProduct.Text);
                double amount = double.Parse(tbAmount.Text);

                salesSummary.AdVendedor(Vendedor, Producto, amount);
                MessageBox.Show("Venta añadida exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            dgvReportedeventas.Rows.Clear();

            // Configura las columnas del DataGridView
            dgvReportedeventas.Columns.Clear();
            dgvReportedeventas.Columns.Add("Product", "Producto");
            for (int j = 1; j <= 4; j++) 
            {
                dgvReportedeventas.Columns.Add($"Vendor{j}", $"Vendedor {j}");
            }
            dgvReportedeventas.Columns.Add("TotalProduct", "Total Producto");

            double[,] salesData = salesSummary.GetSalesData();
            double[] totalventasxvendedor = salesSummary.Ge();
            double[] totalventasporproducto = salesSummary.Getgrandtotal();

            
            for (int i = 0; i < salesData.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvReportedeventas);

                
                row.Cells[0].Value = $"Producto {i + 1}";

                
                for (int j = 0; j < salesData.GetLength(1); j++)
                {
                    row.Cells[j + 1].Value = salesData[i, j].ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                }

                row.Cells[salesData.GetLength(1) + 1].Value = totalventasporproducto[i].ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                // Añade la fila al DataGridView
                dgvReportedeventas.Rows.Add(row);
            }

            // Añadir la fila de totales por vendedor
            DataGridViewRow totalRow = new DataGridViewRow();
            totalRow.CreateCells(dgvReportedeventas);

            totalRow.Cells[0].Value = "Total";
            for (int j = 0; j < t.Length; j++)
            {
                totalRow.Cells[j + 1].Value = totalventasxvendedor[j].ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
            totalRow.Cells[totalventasxvendedor.Length + 1].Value = salesSummary.GetGrandTotal().ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            dgvReportedeventas.Rows.Add(totalRow);
        }
    }
}

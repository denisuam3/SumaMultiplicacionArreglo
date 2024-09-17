using Ejercicio_2.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        private Numlugar avion;

        public Form1()
        {
            InitializeComponent();
            avion = new Numlugar();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int seccion = rdoSmoking.Checked ? 1 : 2;
            int seleccionarNum = avion.AsignarAsiento(seccion);

            if (seleccionarNum == -1)
            {
                string OtraSeccion = (seccion == 1) ? "No Fumar" : "Fumar";
                if (MessageBox.Show($"La sección está llena. ¿Te cambiarias a la  {OtraSeccion}?",
                    "Sección llena", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    seccion = (seccion == 1) ? 2 : 1;
                    seleccionarNum = avion.AsignarAsiento(seccion);
                }
            }

            if (seleccionarNum != -1)
            {
                string NombreSeccion = (seccion == 1) ? "Fumar" : "No Fumar";
                lblBoardingPass.Text = $"Asiento asignado: {seleccionarNum}\nSección: {NombreSeccion}";
            }
            else
            {
                lblBoardingPass.Text = "El próximo vuelo sale en 3 horas.";
            }
        }
    }
}
using Cuadrilateros.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrilateros.Presentacion
{
    public partial class FrmCuadrilaterosAE : MetroFramework.Forms.MetroForm
    {
        public FrmCuadrilaterosAE()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        Cuadrilatero cuadrilatero;
        internal Cuadrilatero GetCuadrilatero()
        {
            return cuadrilatero;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cuadrilatero == null)
                {
                    cuadrilatero = new Cuadrilatero();
                }
                cuadrilatero.LadoA = double.Parse(txtLadoA.Text);
                cuadrilatero.LadoB = double.Parse(txtLadoB.Text);
                this.DialogResult = DialogResult.OK;
            }


            
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;

            double LadoA;
            if (!double.TryParse(txtLadoA.Text, out LadoA))
            {
                valido = false;
                errorProvider1.SetError(txtLadoA, "valor NO permitido, ingrese un Numero!");
            }
            else if (LadoA <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLadoA, "El Número debe ser MAYOR que 0(cero)");
            }


            double LadoB;
            if (!double.TryParse(txtLadoB.Text, out LadoB))
            {
                valido = false;
                errorProvider1.SetError(txtLadoB, "valor NO permitido, ingrese un Numero!");
            }
            else if (LadoB <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLadoB, "El Número debe ser MAYOR que 0(cero)");
            }
            return valido;
        }

        private void FrmCuadrilaterosAE_Load(object sender, EventArgs e)
        {
            if (cuadrilatero != null)
            {
                txtLadoA.Text = Convert.ToString(cuadrilatero.LadoA);
                txtLadoB.Text = Convert.ToString(cuadrilatero.LadoB);

            }
        }

        internal void SetTriangulo(Cuadrilatero c)
        {
            cuadrilatero = c;
        }
    }
}

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
    public partial class FrmCuadrilaterosAE : Form
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
            if (cuadrilatero == null)
            {
                cuadrilatero = new Cuadrilatero();
            }
            cuadrilatero.LadoA = double.Parse(txtLadoA.Text);
            cuadrilatero.LadoB = double.Parse(txtLadoB.Text);


            this.DialogResult = DialogResult.OK;
        }



        private void FrmCuadrilaterosAE_Load(object sender, EventArgs e)
        {
            if (cuadrilatero != null)
            {
                txtLadoA.Text = Convert.ToString(cuadrilatero.LadoA);
                txtLadoB.Text = Convert.ToString(cuadrilatero.LadoB);

            }
        }
    }
}

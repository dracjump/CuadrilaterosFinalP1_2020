
using Cuadrilateros.Datos;
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
    public partial class frmMenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        RepositorioCuadrilateros repositorio = new RepositorioCuadrilateros();
        private List<Cuadrilatero> lista;
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var cuadrilatero in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, cuadrilatero);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
             dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cuadrilatero cuadrilatero)
        {
            r.Cells[cmnLadoA.Index].Value = cuadrilatero.LadoA;
            r.Cells[cmnLadoB.Index].Value = cuadrilatero.LadoB;
            r.Cells[cmnLadoC.Index].Value = cuadrilatero.LadoA;
            r.Cells[cmnLadoD.Index].Value = cuadrilatero.LadoB;
            r.Cells[cmnArea.Index].Value = cuadrilatero.CalcularArea();
            r.Cells[cmnPerimetro.Index].Value = cuadrilatero.CalcularPerimetro();
            r.Tag = cuadrilatero;
        }
        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FrmCuadrilaterosAE frm = new FrmCuadrilaterosAE();
            frm.Text = "Agregar Cuadrilatero";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                Cuadrilatero cuadrilatero = frm.GetCuadrilatero();
                repositorio.Agregar(cuadrilatero);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, cuadrilatero);
                AgregarFila(r);
                MessageBox.Show("Cuadrilatero agregado", "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvDatos.SelectedRows[0];
                Cuadrilatero c = (Cuadrilatero)r.Tag;
                FrmCuadrilaterosAE frm = new FrmCuadrilaterosAE();
                frm.Text = "Editar Cuadrilatero";
                frm.SetTriangulo(c);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    c = frm.GetCuadrilatero();
                    repositorio.Editar(c);
                    SetearFila(r, c);

                    MessageBox.Show("Registro Editado", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }



        private void tsbOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            if (repositorio.Check)
            {
                repositorio.GuardarDatosEnArchivo();
            }
            Application.Exit();
        }

        private void mayMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenada();

            MostrarDatosEnGrilla();
        }

        private void perimetroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetPerOrdenada();
            MostrarDatosEnGrilla();
        }
    }
}

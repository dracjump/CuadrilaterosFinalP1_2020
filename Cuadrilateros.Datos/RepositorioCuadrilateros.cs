using Cuadrilateros.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;




namespace Cuadrilateros.Datos
{
    public class RepositorioCuadrilateros
    {
        public List<Cuadrilatero> listaCuadrilateros { get; set; } = new List<Cuadrilatero>();

        private string RutaDelArchivo = Application.StartupPath + @"\DatosCuadrilatero.txt";

        public RepositorioCuadrilateros()
        {
            this.LeerDelArchivo();
        }
        private void LeerDelArchivo()
        {
            var lector = new StreamReader(RutaDelArchivo);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var campos = linea.Split(';');
                var cuadrilatero = new Cuadrilatero
                {
                    LadoA = double.Parse(campos[0]),
                    LadoB = double.Parse(campos[1]),

                };
                listaCuadrilateros.Add(cuadrilatero);
            }
            lector.Close();
            lector.Dispose();
        }
        public bool Check { get; set; } = false;
        public void Agregar(Cuadrilatero cuadrilatero)
        {
            Check = true;
            listaCuadrilateros.Add(cuadrilatero);
        }

        public List<Cuadrilatero> GetLista()
        {
            return listaCuadrilateros;
        }


        Cuadrilatero cuadrilatero = new Cuadrilatero();

        public void Editar(Cuadrilatero cuadrilatero)
        {
            Check = true;
        }
        public void GuardarDatosEnArchivo()
        {
            var escritor = new StreamWriter(RutaDelArchivo);
            foreach (var c in listaCuadrilateros)
            {
                var linea = $"{c.LadoA};{c.LadoB}";
                escritor.WriteLine(linea);
            }
            escritor.Close();
            escritor.Dispose();
        }

        public List<Cuadrilatero> GetPerOrdenada()
        {
            return listaCuadrilateros.OrderBy(c => c.CalcularPerimetro()).ToList();
        }

        public List<Cuadrilatero> GetListaOrdenada()
        {
            return listaCuadrilateros.OrderByDescending(c => c.LadoA).ToList();
        }
    }

}

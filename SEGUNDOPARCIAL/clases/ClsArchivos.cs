using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEGUNDOPARCIAL.clases
{
    class ClsArchivos
    {
        /// <summary>
        /// variables para controlar la apertura y almacenamiento del archvio
        /// </summary>
        public string Abrir {get; private set;}
 
        public string[] lineas { get; private set; }

        /// <summary>
        /// Constructor de la clase cls archvio 
        /// </summary>
        public ClsArchivos() {
            this.abrir();
        }
/// <summary>
/// funcion que nos abrira el archivo
/// </summary>
/// <returns></returns>
        private string abrir()
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Title = "Seleccione su Archivo Plano!";
            archivo.InitialDirectory = "C:\\Users\anner";
            archivo.Filter = "Archivos CSV|*.csv";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                Abrir = archivo.FileName;

            }
            return Abrir;
        }

/// <summary>
/// Funcion que nos guardara en un arreglo las lineas que obtenga del archivo plano
/// </summary>
/// <returns></returns>
        public string[] obtenerFilas()
        {
            string[] filas = File.ReadAllLines(Abrir);
            return filas;
        }
    }
}

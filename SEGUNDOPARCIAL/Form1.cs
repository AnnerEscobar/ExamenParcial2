using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEGUNDOPARCIAL.clases;

namespace SEGUNDOPARCIAL
{
    public partial class Form1 : Form
    {
        public string[,] ArregloDosD;//declaracion global del arreglo para poder usarlo en cualquier parte del codigo
        ClsArreglos ArregloNotoas = new ClsArreglos();//variable global de tipo clsArreglo para poder manipular los metodos de ordenamiento burbuja
        ClsPromedios Promedio = new ClsPromedios();//VAriable global de tipo cls promedio para poder manipular todas las funciones dentro de nuestra clase cls promediios
        public Form1()
        {
            InitializeComponent();
        }

//*******************************************************************************************************************************************************************
//Boton cargar a travez del cual cargamos el archivo a la pantalla y tambien convertimos nuetro archivo a un array y luego ese array a una matriz
        private void button1_Click(object sender, EventArgs e)
        {

            ClsArchivos SelecArchivo = new ClsArchivos();
            string[] filas = SelecArchivo.obtenerFilas();


            foreach (string linea in filas)
            {
                listBoxCarga.Items.Add(linea);
            }

            ArregloDosD = ArregloNotoas.DosDimensiones(filas, 7);


        }
//******************************************************************************************************************************************************************
//Funcion para ordenar los nombres alfabeticamente


        private void btnOrdenNombre_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();

            string[] OrdenNombres = ArregloNotoas.MetodoBurbujaTexto(ArregloDosD, 1);
            for (int i = 0; i < OrdenNombres.Length; i++)
            {
                ListBoxResultados.Items.Add(OrdenNombres[i]);
            }
        }

//******************************************************************************************************************************************************************
//Boton que ordena las notas del tercer parcal

        private void btnOrdenP1_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            int[] P1 = ArregloNotoas.MetodoBurbujaInt(ArregloDosD, 2);
            for (int i = 0; i < P1.Length; i++)
            {
                ListBoxResultados.Items.Add(P1[i]);
            }
        }

//******************************************************************************************************************************************************************
//Boton que ordena las notas del tercer parcal

        private void btnOrdenP2_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            int[] P2 = ArregloNotoas.MetodoBurbujaInt(ArregloDosD, 3);
            for (int i = 0; i < P2.Length; i++)
            {
                ListBoxResultados.Items.Add(P2[i]);
            }
        }
//******************************************************************************************************************************************************************
//Boton que ordena las notas del tercer parcal
        private void btnOrdenP3_Click(object sender, EventArgs e)
        {

            ListBoxResultados.Items.Clear();
            int[] P3 = ArregloNotoas.MetodoBurbujaInt(ArregloDosD, 3);
            for (int i = 0; i < P3.Length; i++)
            {
                ListBoxResultados.Items.Add(P3[i]);
            }

        }
//*****************************************************************************************************************************************************************
//Boton que hace referencia a la Clase Cls promedios a la funcion de promedios de todos los alumnos
        private void btnPromediosAlumnos_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();

            for (int i = 0; i < ArregloDosD.GetLength(0); i++)
            {
                ListBoxResultados.Items.Add(ArregloDosD[i, 1] + " - " + ArregloDosD[i, 6]);//Aqui se concatena el nombre del alumno con su promedio en los tres parciales
                // el primero se reifere al nombre y el segundo a la nota del parcial.
            }
        }
//************************************************************************************************************************************************************
//Botones que hacen referencia a la clase ClsPromedios a la funcion de promedios por parcial
        private void btnPromedioP1_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            int PromedioP1 = Promedio.promedios_por_parcial(ArregloDosD, 2);
            ListBoxResultados.Items.Add("Promedio por Parcial Numero 1: " + PromedioP1);
        }

        private void btnPromedioP2_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            int PromedioP2 = Promedio.promedios_por_parcial(ArregloDosD, 3);
            ListBoxResultados.Items.Add("Promedio por Parcial Numero 2: " + PromedioP2);
        }

        private void btnPromedioP3_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            int PromedioP3 = Promedio.promedios_por_parcial(ArregloDosD, 4);
            ListBoxResultados.Items.Add("Promedio por Parcial Numero 3: " + PromedioP3);
        }
//*********************************************************************************************************************************************************************
//Botones que hacen referencia a la clase Cls promedios a la funcion de promedios por seccion nos despliega el promedio general de una seccion en especifico
        private void btnPromediosSeccion_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();

            int PromGPorSeccion = Promedio.promedios_por_seccion(ArregloDosD, 6, "A");
            ListBoxResultados.Items.Add("Promedio General De la Seccion A: " + PromGPorSeccion);
        }

//******************************************************************************************************************************************************************
//Boton que accede a la clase cls promedios por la variable global declarada al inicio y los botones nos muestran el prmedio general de cada seccion en cuanto a un parcial en especifico

        private void button4_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            int PromeGP = Promedio.promedios_por_seccion(ArregloDosD, 2, "A");
            ListBoxResultados.Items.Add("Promedio General Parcial 1 Seccion A: " + PromeGP);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            int PromeGP = Promedio.promedios_por_seccion(ArregloDosD, 3, "A");
            ListBoxResultados.Items.Add("Promedio General Parcial 2 Seccion A: " + PromeGP);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            int PromeGP = Promedio.promedios_por_seccion(ArregloDosD, 4, "A");
            ListBoxResultados.Items.Add("Promedio General Parcial 3 Seccion A: " + PromeGP);
        }


 //******************************************************************************************************************************************************************
 //Boton que nos muestra la sumatoria o zona acumulada por cada alumno en los tres parciales


        private void button8_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            string[,] Zona = Promedio.sumatoria_general_por_alumno(ArregloDosD);
            for (int i = 0; i < Zona.GetLength(0); i++)
            {
                ListBoxResultados.Items.Add(Zona[i, 0] + "--------------------------------------------------=: " + Zona[i, 1]);
            }
        }

//******************************************************************************************************************************************************************
//Boton que clasifica los alulmnos por seccion 

        private void button5_Click(object sender, EventArgs e)
        {
            ListBoxResultados.Items.Clear();
            string[,] Matriz = Promedio.Clasificar_Alumnos(ArregloDosD, "A");
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                ListBoxResultados.Items.Add(Matriz[i, 1] + "-------" + Matriz[i, 5]);
            }
        }

        
    }
}

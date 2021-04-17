using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUNDOPARCIAL.clases
{
    class ClsArreglos
    {

        public string[,] DosDimensiones(string[] arreglo, int Columnas)
        {
            string[,] MatrizDosD = new string[arreglo.Length-1, Columnas];
            int contador = 0;
            foreach (string datoF in arreglo)
            {
                if (contador != 0)
                {
                    string[] columnas = datoF.Split(';');//En cada posicion de la matrizDosD se guarda una columan de nuestro archivo plano
                    MatrizDosD[contador-1, 0] = columnas[0]; 
                    MatrizDosD[contador-1, 1] = columnas[1]; 
                    MatrizDosD[contador-1, 2] = columnas[2];
                    MatrizDosD[contador-1, 3] = columnas[3]; 
                    MatrizDosD[contador-1, 4] = columnas[4]; 
                    MatrizDosD[contador-1, 5] = columnas[5];
                    /**
                     * SE CALCULA EL PROMEDI POR ALUMNO
                     */
                    int p1 = Convert.ToInt16(columnas[2]);
                    int p2 = Convert.ToInt16(columnas[3]);
                    int p3 = Convert.ToInt16(columnas[4]);
                    int promedio = p1+ p2+p3/ 3;

                    MatrizDosD[contador-1, 6] = Convert.ToString(promedio);//Se almacena el promedio de cada alumno en una sexta columna que fue agregada
                }
                contador++;
            }
            return MatrizDosD;
        }
        public string[] MetodoBurbujaTexto(string[,] matriz, int columna)
        {
            string[] arreglo = new string[matriz.GetLength(0)-1];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = matriz[i, columna];
            }
            
            string[] CAdenaTemporal = arreglo;
            string DatoTemporal;

            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                                                                           // = iguales >0 mayor <0 menor
                    if (CAdenaTemporal[i].CompareTo(CAdenaTemporal[j]) > 0)//se utiliza compareTo para comparar 2 cadenas si es mayor la primera retorma +1
                                                                           //si la primera fuera mayor que la segunda retornaria retornaria 0
                    {
                        DatoTemporal = CAdenaTemporal[i];
                        CAdenaTemporal[i] = CAdenaTemporal[j];
                        CAdenaTemporal[j] = DatoTemporal;
                    }
                }
            }
            return arreglo;
        }
        public int[] MetodoBurbujaInt(string[,] matriz, int columna)
        {

            int[] arreglo = new int[matriz.GetLength(0)-1];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(matriz[i , columna]);
            }

            int[] ArregloTemporal = arreglo;
            int DatoTemporal;
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = i + 1; j < arreglo.GetLength(0); j++)
                {
                    if (ArregloTemporal[i] >ArregloTemporal[j])
                    {
                        DatoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = DatoTemporal;
                    }
                }
            }
            return arreglo;
        }
        
       

    }
}

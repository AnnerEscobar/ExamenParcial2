using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUNDOPARCIAL.clases
{
    class ClsPromedios : InterfacePromedios
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            int Contador = 0;
            for(int i=0; i<matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    Contador++;
                }
            }
            string[,] MatrizdeSeccion = new string[Contador, matriz.GetLength(1)];
            int OtroCondador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    MatrizdeSeccion[OtroCondador, 0] = matriz[i, 0];
                    MatrizdeSeccion[OtroCondador, 1] = matriz[i, 1];
                    MatrizdeSeccion[OtroCondador, 2] = matriz[i, 2];
                    MatrizdeSeccion[OtroCondador, 3] = matriz[i, 3];
                    MatrizdeSeccion[OtroCondador, 4] = matriz[i, 4];
                    MatrizdeSeccion[OtroCondador, 5] = matriz[i, 5];
                    MatrizdeSeccion[OtroCondador, 6] = matriz[i, 6];
                    OtroCondador++;
                }
            }
            return MatrizdeSeccion;

        }

        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int Acumulador = 0;
            for(int i=0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion )
                {
                    Acumulador = Acumulador + Convert.ToInt32(matriz[i, columna_parcial]);
                }
            }
            int Promedio = Acumulador / matriz.GetLength(0);
            return Promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
           
            int Acumulador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Acumulador = Acumulador + Convert.ToInt32(matriz[i, columna_parcial]);
            }

            int Promedio = Acumulador / matriz.GetLength(0);

            return Promedio;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            
            int Acumulador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    Acumulador = Acumulador + Convert.ToInt32(matriz[i, columna_parcial]);
                }
            }

            int promedio = Acumulador / matriz.GetLength(0);

            return promedio;
        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            string[,] MatrisZona = new string[matriz.GetLength(0), 2];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                MatrisZona[i, 0] = matriz[i, 1];
                int p1 = Convert.ToInt16(matriz[i, 2]);
                int p2 = Convert.ToInt16(matriz[i, 3]);
                int p3 = Convert.ToInt16(matriz[i, 4]);
                int zona = p1 + p2 + p3;
                MatrisZona[i, 1] = Convert.ToString(zona);
            }
            return MatrisZona;

        }
    }
}

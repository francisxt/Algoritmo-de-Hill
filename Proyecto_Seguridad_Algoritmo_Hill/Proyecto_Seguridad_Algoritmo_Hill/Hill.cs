using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Seguridad_Algoritmo_Hill
{
    public class Hill
    {
        Inverso inverso = new Inverso();
        DeterminanteDeMatriz determinanteM = new DeterminanteDeMatriz();
        ValidarPatron validPat = new ValidarPatron();
        Bloques addBloques = new Bloques();
        Alfabeto alfabeto = new Alfabeto();

        public char[] Cifrado(char[] a, int[][] matrizA, int tamMatriz)
        {

            ///////////////// OBTENER PATRON MODIFICADO /////////
            Console.WriteLine("\nEl Patron es: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("" + a[i]);
            }
            int errorPI = validPat.error(a);
            char[] patronInicial = new char[a.Length];
            patronInicial = validPat.validarPatron2(a);
            int tamPV = patronInicial.Length - errorPI;
            char[] patronvalidado = new char[tamPV];
            for (int i = 0; i < tamPV; i++)
            {
                patronvalidado[i] = patronInicial[i];
            }

            int tamPatron = addBloques.tamBloques(tamMatriz, patronvalidado);
            char[] patron = new char[tamPatron];

            patron = addBloques.bloques2(tamMatriz, patronvalidado, tamPatron);
            Console.WriteLine("\nEl patron Modificado es: ");
            int contad = 0, sumador = 0;
            for (int i = 0; i < patron.Length; i = i + tamMatriz)
            {
                while (contad < tamMatriz)
                {
                    Console.WriteLine("" + patron[sumador]);
                    sumador++;
                    contad++;
                }
                Console.WriteLine(" ");
                contad = 0;
            }
            char[] resul = new char[tamPatron];
            int pos = 0, indice = 0, numPatron = 0, z = 0;
            String r;

            for (int k = 0; k < (tamPatron / tamMatriz); k++)
            {
                for (int i = 0; i < tamMatriz; i++)
                {
                    pos = z;
                    indice = 0;
                    for (int j = 0; j < tamMatriz; j++)
                    {
                        numPatron = alfabeto.numero(Convert.ToString(patron[pos]));
                        indice = indice + (matrizA[i][j] * numPatron);
                        pos++;
                    }
                    indice = indice % 26;
                    r = alfabeto.letra(indice);
                    resul[z + i] = r[0];
                }
                z = z + tamMatriz;
            }

            return resul;
        }


        public char[] Descifrado(char[] a, int[][] matrizA, int tamMatriz)
        {

            ///////////////// OBTENER PATRON MODIFICADO /////////
            Console.WriteLine("\nEl Patron es: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("" + a[i]);
            }
            int errorPI = validPat.error(a);
            char[] patronInicial = new char[a.Length];
            patronInicial = validPat.validarPatron(a);
            int tamPV = patronInicial.Length - errorPI;
            char[] patronvalidado = new char[tamPV];
            for (int i = 0; i < tamPV; i++)
            {
                patronvalidado[i] = patronInicial[i];
            }

            int tamPatron = addBloques.tamBloques(tamMatriz, patronvalidado);
            char[] patron = new char[tamPatron];

            patron = addBloques.bloques2(tamMatriz, patronvalidado, tamPatron);
            Console.WriteLine("\nEl patron Modificado es: ");
            int contad = 0, sumador = 0;
            for (int i = 0; i < patron.Length; i = i + tamMatriz)
            {
                while (contad < tamMatriz)
                {
                    Console.WriteLine("" + patron[sumador]);
                    sumador++;
                    contad++;
                }
                Console.WriteLine(" ");
                contad = 0;
            }

            int[][] matrizCofactores = determinanteM.cofactores(matrizA, tamMatriz);
            Console.WriteLine("\nLa Matriz para Descifrar es:");
            for (int i = 0; i < tamMatriz; i++)
            {
                for (int j = 0; j < tamMatriz; j++)
                {
                    matrizCofactores[i][j] = (matrizCofactores[i][j] * 3);
                    if (matrizCofactores[i][j] >= 0)
                    {
                        matrizCofactores[i][j] = matrizCofactores[i][j] % 26;
                    }
                    else if (matrizCofactores[i][j] >= -26)
                    {
                        matrizCofactores[i][j] = 26 + matrizCofactores[i][j];
                    }
                    else if (matrizCofactores[i][j] < -26)
                    {
                        matrizCofactores[i][j] = 26 - ((matrizCofactores[i][j] * (-1)) % 26);
                    }
                    Console.WriteLine("" + matrizCofactores[i][j] + " ");
                }
                Console.WriteLine("");
            }

            char[] resul = new char[tamPatron];
            int pos = 0, indice = 0, numPatron = 0, z = 0;
            String r;

            for (int k = 0; k < (tamPatron / tamMatriz); k++)
            {
                for (int i = 0; i < tamMatriz; i++)
                {
                    pos = z;
                    indice = 0;
                    for (int j = 0; j < tamMatriz; j++)
                    {
                        numPatron = alfabeto.numero(Convert.ToString(patron[pos]));
                        indice = indice + (matrizCofactores[i][j] * numPatron);
                        pos++;
                    }
                    indice = indice % 26;
                    r = alfabeto.letra(indice);
                    resul[z + i] = r[0];
                }
                z = z + tamMatriz;
            }

            return resul;
        }
    }
}

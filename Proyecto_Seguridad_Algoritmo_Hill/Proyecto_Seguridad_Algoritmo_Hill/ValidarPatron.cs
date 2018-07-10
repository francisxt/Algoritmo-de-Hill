using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Seguridad_Algoritmo_Hill
{
    public class ValidarPatron
    {

        public char[] validarPatron(char[] k)
        {
            String datos = "abcdefghiklmnopqrstuvwxyzABCDEFGHIKLMNOPQRSTUVWXYZ";
            String letra = "ji";
            int tamK = k.Length, contAlf = 0, tamAlf = 25;
            char[] clave1 = new char[tamK];
            char[] clave2 = new char[tamK];

            for (int i = 0; i < tamK; i++)
            {
                if (k[i] == letra[0])
                {
                    clave1[i] = letra[1];
                }
                else
                {
                    clave1[i] = k[i];
                }
                
            }

            Console.WriteLine("\nModificando: ");
            int encontrado = 0, no = 0, contC1 = 0, tamC2 = 0;
            int tamC1 = tamK;
            for (int i = 0; i < tamC1; i++)
            {
                encontrado = 0;
                int j = 0;
                while (j < tamAlf)
                {
                    if (contC1 == tamC1)
                    {
                        j = tamAlf;
                    }
                    else if (clave1[i] == datos[j])
                    {
                        clave2[tamC2] = clave1[i];
                        tamC2++;
                        encontrado = 1;
                        j = tamAlf;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (encontrado == 0)
                {
                    no++;
                }
            }
            for (int i = 0; i < tamC2; i++)
            {
                Console.WriteLine("" + clave2[i]);
            }
            
            return clave2;
        }

        public int error(char[] clave1)
        {
            String datos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int tamK = clave1.Length, contAlf = 0, tamAlf = datos.Length;
            char[] clave2 = new char[tamK];

            int encontrado = 0, no = 0, contC1 = 0, tamC2 = 0;
            int tamC1 = tamK;
            for (int i = 0; i < tamC1; i++)
            {
                encontrado = 0;
                int j = 0;
                while (j < tamAlf)
                {
                    if (contC1 == tamC1)
                    {
                        j = tamAlf;
                    }
                    else if (clave1[i] == datos[j])
                    {
                        clave2[tamC2] = clave1[i];
                        tamC2++;
                        encontrado = 1;
                        j = tamAlf;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (encontrado == 0)
                {
                    no++;
                }
            }
            Console.WriteLine("\nCorrecciones en Patron= " + no);

            return no;
        }

        public char[] validarPatron2(char[] k)
        {
            String datos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int tamK = k.Length, contAlf = 0, tamAlf = datos.Length;
            char[] clave1 = new char[tamK];
            char[] clave2 = new char[tamK];

            for (int i = 0; i < tamK; i++)
            {
                clave1[i] = k[i];
            }

            Console.WriteLine("\nModificando: ");
            int encontrado = 0, no = 0, contC1 = 0, tamC2 = 0;
            int tamC1 = tamK;
            for (int i = 0; i < tamC1; i++)
            {
                encontrado = 0;
                int j = 0;
                while (j < tamAlf)
                {
                    if (contC1 == tamC1)
                    {
                        j = tamAlf;
                    }
                    else if (clave1[i] == datos[j])
                    {
                        clave2[tamC2] = clave1[i];
                        tamC2++;
                        encontrado = 1;
                        j = tamAlf;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (encontrado == 0)
                {
                    no++;
                }
            }
            for (int i = 0; i < tamC2; i++)
            {
                Console.WriteLine("" + clave2[i]);
            }
            
            return clave2;
        }

    }
}

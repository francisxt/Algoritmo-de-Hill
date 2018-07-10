﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Seguridad_Algoritmo_Hill
{
    public class Bloques
    {

        public char[] bloques(int num, char[] patron)
        {

            int tamPatron = tamBloques(num, patron);
            int i = 0, j = 0;
            String letra = "xz";
            char[] nuevoPatron = new char[tamPatron];

            while (i < patron.Length)
            {
                if ((i + 1) == patron.Length)
                {
                    nuevoPatron[j] = patron[i];
                    nuevoPatron[j + 1] = letra[0];
                    i = patron.Length;
                }
                else if (patron[i] != patron[i + 1])
                {
                    nuevoPatron[j] = patron[i];
                    nuevoPatron[j + 1] = patron[i + 1];
                    j = j + 2;
                    i = i + 2;
                }
                else if (patron[i] == patron[i + 1])
                {
                    nuevoPatron[j] = patron[i];
                    nuevoPatron[j + 1] = letra[0];
                    j = j + 2;
                    i++;
                }
            }

            return nuevoPatron;
        }

        public int tamBloques(int num, char[] patron)
        {
            int tamPatron = patron.Length, i = 0;
            while (i < patron.Length)
            {
                if ((i + 1) == patron.Length)
                {
                    i = patron.Length;
                }
                else if (patron[i] != patron[i + 1])
                {
                    i = i + num;
                }
                else if (patron[i] == patron[i + 1])
                {
                    tamPatron++;
                    i++;
                }
            }

            if ((tamPatron % num) != 0)
            {
                tamPatron = tamPatron + (num - (tamPatron % num));
            }

            return tamPatron;
        }

        public char[] bloques2(int num, char[] patron, int tamPat)
        {

            int tamPatron = tamBloques(num, patron);
            int j = 0;
            String letra = "xz";
            char[] nuevoPatron = new char[tamPatron];

            for (int i = 0; i < tamPat; i++)
            {
                if (i < patron.Length)
                {
                    nuevoPatron[i] = patron[i];
                }
                else
                {
                    nuevoPatron[i] = letra[0];
                }
            }

            return nuevoPatron;
        }

    }
}

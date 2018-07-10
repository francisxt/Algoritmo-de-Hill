using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Seguridad_Algoritmo_Hill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hill hill = new Hill();
            int[][] matriz = new int[3][];
            matriz[0] = new int[3] { 1, 2, 3 };
            matriz[1] = new int[3] { 1, 2, 1 };
            matriz[2] = new int[3] { 4, 5, 6 };
            string pal = "CODIGO";
            char[] palabra = pal.ToCharArray();
            int[,] matriz2 = new int[2, 2];

            hill.Cifrado(palabra, matriz, 3);
        }
    }
}

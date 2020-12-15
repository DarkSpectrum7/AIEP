using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burbuja
{
    public partial class Burbuja : Form
    {
        public Burbuja()
        {
            InitializeComponent();
        }

        private void Burbuja_Load(object sender, EventArgs e)
        {

        }

        void OrdenarBurbuja(int [] vector)
        {
            int aux = 0;

            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j+1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }

            textBox_Numeros.Text += "El arreglo esta ordenado de menor a mayor" + Environment.NewLine;

            foreach (int elementos in vector)
            {
                textBox_Numeros.Text += elementos + Environment.NewLine;
            }

        }

        private void Button_Ordenar_Click(object sender, EventArgs e)
        {
            int[] vector = { 3, 5, 7, 34, 67, 22 };

            textBox_Numeros.Text = "El arreglo esta desordenado" + Environment.NewLine;

            foreach (int element in vector)
            {
                textBox_Numeros.Text += element + Environment.NewLine;
            }


            OrdenarBurbuja(vector);


        }
    }
}

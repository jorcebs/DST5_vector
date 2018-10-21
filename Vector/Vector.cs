using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    /// <summary>
    /// Allows you to create and control an int array. 
    /// </summary>
    class Vector
    {
        private int[] vector { get; }

        /// <summary>
        /// Create a new int array by indicating its size.
        /// </summary>
        /// <param name="size"></param>
        public Vector(int size)
        {
            vector = new int[size];
        }

        /// <summary>
        /// Fills the array with numbers starting with the specified number.
        /// </summary>
        /// <param name="num"></param>
        public void llenar(int num)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = num;
                num++;
            }
        }

        /// <summary>
        /// Returns the array's content.
        /// </summary>
        /// <returns></returns>
        public string mostrar()
        {
            string contenido = "";
            for (int i = 0; i < vector.Length; i++)
                contenido += "[" + i.ToString() + "] = " + vector[i].ToString() + Environment.NewLine;
            return contenido;
        }

        public void girarArriba()
        {
            int aux = vector[0];
            for (int i = 0; i < vector.Length - 1; i++)
                vector[i] = vector[i + 1];
            vector[vector.Length - 1] = aux;
        }

        public void girarAbajo()
        {
            int aux = vector[vector.Length - 1];
            for (int i = vector.Length - 1; i > 0; i--)
                vector[i] = vector[i - 1];
            vector[0] = aux;
        }

        public void invertir()
        {
            int aux;
            double x = Math.Round((double)(vector.Length / 2));
            for (int i = 0; i != x; i++)
            {
                aux = vector[i];
                vector[i] = vector[vector.Length - i - 1];
                vector[vector.Length - i - 1] = aux;
            }
        }
    }
}
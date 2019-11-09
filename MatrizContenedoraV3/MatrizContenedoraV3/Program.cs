using System;
using System.Collections.Generic;

namespace MatrizContenedoraV3
{
    class Program
    {
        public static object Collections { get; private set; }

        /// <summary>
        /// Rellena un array de valores en orden ascendente, comenzando por el 1
        /// </summary>
        /// <param name="a">Array de cualquier tamaño</param>
        static void RellenaEnOrdenBi(int[,] a)
        {
            int i, j;
            int valor = 1;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = valor;
                    valor++;
                }
            }
        }

        /// <summary>
        /// Rellena un array 3x3 con números de tipo entero
        /// </summary>
        /// <returns>Devuelve matriz 3x3 con valores ingresados por consola</returns>
        static int[,] RellenaMatriz3x3() //Tenemos que pasar por parámetro un array 3x3
        {
            //Variables
            int[,] array = new int[3, 3];
            int i, j;
            int cont = 5;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array[i, j] = cont;
                    cont++;
                }
            }
            return array;
        }

        /// <summary>
        /// Función que escribe lista por consola.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de la misma.</param>
        static void EscribeLista(List<int> l)
        {
            Console.Write("<");
            int i;
            for (i = 0; i < l.Count - 1; i++)
            {
                Console.Write(l[i] + ", ");
            }
            Console.Write(l[l.Count - 1] + ">");
        }

        /// <summary>
        /// Muestra por consola un array detallado
        /// </summary>
        /// <param name="a">Array de enteros vacío</param>
        static void EscribeArray(int[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.Write(a[a.Length - 1] + "]");
        }

        /// <summary>
        /// Función que imprime por pantalla array multidimensional de cualquier tamaño.
        /// </summary>
        /// <param name="a">Parámetro de la función y array de la misma</param>
        static void EscribeArrayBi(int[,] a)
        {
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("| ");
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        }

        static List<int> CopiaMatrizEnLista(int[,] matriz)
        {
            List<int> lista = new List<int>();           

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    lista.Add(matriz[i, j]);
                }
            }

            return lista;
        }

        /// <summary>
        /// Función que pasa una lista de tipo entero a string
        /// </summary>
        /// <param name="liEnteros">Lista de tipo entero</param>
        /// <returns>String de enteros</returns>
        static string ListaEnterosToString(List<int> liEnteros)
        {
            string liString = "";

            for (int i = 0; i < liEnteros.Count; i++)
            {
                liString = liString + liEnteros[i];
            }

            return liString;
        }

        /// <summary>
        /// Función que marca con un caracter negativo el primer caracter de una subcadena
        /// </summary>
        /// <param name="cadena">Determina el primer parámetro de la función y la cadena a analizar</param>
        /// <param name="subcadena">Determina el segundo parámetro de la función y la subcadena</param>
        /// <returns>Devuelve cadena con subcadena modificada</returns>
        static string MarcaSubCadena(string cadena, string subcadena)
        {
            int i;

            string cacho;
            for (i = 0; i < cadena.Length - (subcadena.Length - 1); i++)
            {
                cacho = cadena.Substring(i, subcadena.Length);
                if (cacho == subcadena)
                {
                    //cadena[i] = '*';
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "-7");
                }

            }

            return cadena;
        }

        static List<int> CharArrayToListInt(char[] charArr)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < charArr.Length; i++)
            {
                lista.Add(charArr[i]);
            }

            return lista;
        }
        
        /// <summary>
        /// Pasa elementos enteros de una lista a una matriz
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        /// <returns>Matriz de enteros</returns>
        static int[,] RellenaMatrizArray(int[] array)
        {
            int[,] matriz = new int[10, 10];
            int cont;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                cont = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = array[cont];
                    cont++;
                }
            }

            return matriz;
        }
      
        static void MatrizContedora()
        {
            //Variable
            int[,] matriz10x10 = new int[10, 10];
            int[,] matriz3x3;
            List<int> lista100 = new List<int>();
            List<int> lista9 = new List<int>();
            string strLista100 = "";
            string strLista9 = "";
            string strConMarca = "";
            char[] charArray;
            List<int> listaFinalEnteros;
            int[,] matrizResultado = new int[10, 10];
            int[] arrayFinal = new int[100];

            //Inicializamos matriz 10x10 y le damos valores
            RellenaEnOrdenBi(matriz10x10);

            //Mostramos por consola matriz10x10
            Console.WriteLine("Array bidimensional de 10x10:");
            Console.WriteLine();
            EscribeArrayBi(matriz10x10);

            //Pedimos al usuario los valores enteros para la submatriz 3x3 y le damos valores
            Console.WriteLine("Array bidimensional de 3x3:");
            Console.WriteLine();
            matriz3x3 = RellenaMatriz3x3();
            EscribeArrayBi(matriz3x3);
            Console.WriteLine();

            //Pasamos a una lista los valores de matriz10x10
            lista100 = CopiaMatrizEnLista(matriz10x10);
            lista9 = CopiaMatrizEnLista(matriz3x3);

            //Pasamos las listas de enteros a cadenas
            strLista100 = ListaEnterosToString(lista100);
            strLista9 = ListaEnterosToString(lista9);

            //Busca la lista9 en lista100 y establece una marca en la posición del elemento correpondiente a 
            //las coordenadas buscadas
            strConMarca = MarcaSubCadena(strLista100, strLista9);

            //Hacemos casting de listas string to char[] 
            charArray = strConMarca.ToCharArray();
            Console.WriteLine(charArray);


            //Pasa el char[] a List<int> para poder obtener tipo de datos enteros
            listaFinalEnteros = CharArrayToListInt(charArray);

            //Pasamos la lista a un array
            arrayFinal = listaFinalEnteros.ToArray();

            //Pasamos los elementos de la lista a la matriz
            matrizResultado = RellenaMatrizArray(arrayFinal);

            //Mostramos la matriz
            EscribeArrayBi(matrizResultado);
        }

        
        static void Main(string[] args)
        {
            MatrizContedora();              
        }
    }
}

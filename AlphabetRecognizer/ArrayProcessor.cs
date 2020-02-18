using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetRecognizer
{
    public static class ArrayProcessor
    {
        public static bool[,] SetArraySize(this bool[,] array)
        {
            bool minFound = false;
            int minX = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j])
                    {
                        minFound = true;
                        minX = i;
                        break;
                    }
                if (minFound)
                    break;
            }

            int maxX = minX;
            for (int i = minX; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j])
                        maxX = i;

            minFound = false;
            int minY = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                    if (array[i, j])
                    {
                        minFound = true;
                        minY = j;
                        break;
                    }
                if (minFound)
                    break;
            }

            int maxY = minY;
            for (int j = 0; j < array.GetLength(1); j++)
                for (int i = 0; i < array.GetLength(0); i++)
                    if (array[i, j])
                        maxY = j;
            bool[,] scaledArray = new bool[maxX - minX + 1, maxY - minY + 1];
            for (int i = 0; i < maxX - minX + 1; i++)
                for (int j = 0; j < maxY - minY + 1; j++)
                    scaledArray[i, j] = array[minX + i, minY + j];
            return scaledArray;
        }

        public static bool[,] MakeSquare(this bool[,] array)
        {
            int scale = Math.Max(array.GetLength(0), array.GetLength(1)) + 1;
            bool[,] squaredArray = new bool[scale, scale];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    squaredArray[(scale / 2) - (array.GetLength(0) / 2) + i, (scale / 2) - (array.GetLength(1) / 2) + j] = array[i, j];
            return squaredArray;
        }

        public static bool[,] Scale(this bool[,] array)
        {
            bool[,] scaledArray = new bool[AlphabetProcessor.AlphabetSize, AlphabetProcessor.AlphabetSize];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (!scaledArray[i * AlphabetProcessor.AlphabetSize/ array.GetLength(0) , j * AlphabetProcessor.AlphabetSize/ array.GetLength(1) ])
                        scaledArray[i * AlphabetProcessor.AlphabetSize/ array.GetLength(0) , j * AlphabetProcessor.AlphabetSize / array.GetLength(1)] = array[i, j];
            using (StreamWriter writer = new StreamWriter("sha.txt", true))
            {
                for (int i = 0; i < AlphabetProcessor.AlphabetSize; i++)
                {
                    for (int j = 0; j < AlphabetProcessor.AlphabetSize; j++)
                    {
                        if (scaledArray[j, i])
                            writer.Write("*");
                        else
                            writer.Write(" ");
                    }
                    writer.WriteLine();  
                }
            }
            return scaledArray;
        }

        internal static int CalculateMax(int[,] alphabet)
        {
            int max = 0;
            for (int i = 0; i < alphabet.GetLength(0); i++)
                for (int j = 0; j < alphabet.GetLength(1); j++)
                    if (alphabet[i, j] > max)
                        max = alphabet[i, j];
            return max;
        }
    }
}

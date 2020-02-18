//# define Initialize
//# define ToImage
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlphabetRecognizer
{

    public class AlphabetProcessor
    {
        public const int AlphabetSize = 20;
        public Dictionary<char, int[,]> Alphabets { get; set; }

        public AlphabetProcessor()
        {
            # if Initialize
            Alphabets = new Dictionary<char, int[,]>();
            Directory.CreateDirectory("Alphabets");
            for (int i = 'A'; i <= 'z'; i++)
            {
                Alphabets.Add((char)i, new int[AlphabetSize, AlphabetSize]);
            }
            foreach (var item in Alphabets)
            {
                using (StreamWriter writer = new StreamWriter(String.Format("Alphabets/{0}.txt", (int)item.Key)))
                {
                    for (int i = 0; i < AlphabetSize; i++)
                    {
                        for (int j = 0; j < AlphabetSize; j++)
                            writer.Write(String.Format("{0} ", item.Value[i, j]));
                        writer.WriteLine();
                    }
                }
            }
            # endif
            # if ToImage
            Directory.CreateDirectory("Images");
            for (int i = 'A'; i <= 'z'; i++)
                DrawAlphabet((char)i).Save(String.Format("Images/{0}.jpg", i), ImageFormat.Jpeg);
            #endif
        }

        public void SaveAlphabet(bool[,] array, char alphabet)
        {
            int[,] alphabetArray = ReadAlphabet(alphabet);
            for (int i = 0; i < alphabetArray.GetLength(0); i++)
                for (int j = 0; j < alphabetArray.GetLength(1); j++)
                    if (array[i, j])
                        alphabetArray[i, j]++;
            using (StreamWriter writer = new StreamWriter(String.Format("Alphabets/{0}.txt", (int)alphabet)))
            {
                for (int i = 0; i < AlphabetSize; i++)
                {
                    for (int j = 0; j < AlphabetSize; j++)
                        writer.Write(String.Format("{0} ", alphabetArray[i, j]));
                    writer.WriteLine();
                }
            }
        }

        private int[,] ReadAlphabet(char p)
        {
            int[,] array = new int[AlphabetSize, AlphabetSize];
            using (StreamReader reader = new StreamReader(String.Format("Alphabets/{0}.txt", (int)p)))
            {
                for (int i = 0; i < AlphabetSize; i++)
                {

                    string line = reader.ReadLine();
                    string[] nums = line.Split(' ');
                    for (int j = 0; j < AlphabetSize; j++)
                        array[i, j] = Int32.Parse(nums[j]);
                }
            }
            return array;
        }

        internal char Recognize(bool[,] coloredPixels)
        {
            double[] percentages = new double[130];
            for (int i = 'A'; i <= 'z'; i++)
            {
                int[,] alphabet = ReadAlphabet((char)i);
                percentages[i] = CalcuteMatchPercent(coloredPixels, alphabet);
            }
            return (char)percentages.ToList().IndexOf(percentages.Max());
        }

        private double CalcuteMatchPercent(bool[,] coloredPixels, int[,] alphabet)
        {
            int sum = 0;
            for (int i = 0; i < AlphabetSize; i++)
                for (int j = 0; j < AlphabetSize; j++)
                    if (coloredPixels[i, j])
                        sum += alphabet[i, j];
            int max = ArrayProcessor.CalculateMax(alphabet);
            if (max == 0)
                return 0;
            else
                return ((double)sum) / (max);
                
            
        }

        internal Bitmap DrawAlphabet(char p)
        {
            int[,] alphabet = ReadAlphabet(p);
            return ImageProcessor.FromArray(alphabet);
        }
    }
}

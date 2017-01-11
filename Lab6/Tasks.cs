using System;
using System.Linq;

namespace Lab6
{
    public class Tasks
    {
        public static char[][] SortIt(char[][] array)
        {
            char[][] result = new char[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = new char[array[i].Length];
                array[i].CopyTo(result[i], 0);

                Array.Sort(result[i]);
                for (int j = 0; j < result[i].Length/2; j++)
                {
                    var temp = result[i][j];
                    result[i][j] = result[i][result[i].Length - j - 1];
                    result[i][result[i].Length - j - 1] = temp;
                }
            }

            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result.Length-1; j++)
                    if (result[j].Length > result[j + 1].Length)
                    {
                        var temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }

            return result;
        }


        #region randomise

        static readonly Random Rand = new Random();
        private const int ReasonableSize = 17;
        private const int MinChar = 32;
        private const int MaxChar = 128;

        public static void Randomise(ref char[] array)
        {
            if (array == null)
                array = new char[Rand.Next(ReasonableSize) + 1];

            for (int i = 0; i < array.Length; i++)
                do
                {
                    array[i] = (char) Rand.Next(MinChar,MaxChar);
                } while (char.IsWhiteSpace(array[i]));
        }

        public static void Randomise(ref char[][] array)
        {
            if (array == null)
                array = new char[Rand.Next(ReasonableSize) + 1][];

            for (int i = 0; i < array.Length; i++)
            {
                Randomise(ref array[i]);
            }
        }
        
        #endregion randomise
        
        #region input

        public static char[] StringToArray(string input)
        {
            char[] result = new char[0];
            
            for (int i = 0,j = 0; i < input.Length; i++)
            {
                if (!char.IsWhiteSpace(input[i]))
                {
                    char[] array = new char[result.Length + 1];
                    result.CopyTo(array, 0);
                    array[j++] = input[i];
                    result = array;
                }

            }
            return result;
        }

        public static char[][] StringToArray(string[] input)
        {
            char[][] array = new char[0][];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != string.Empty)
                {
                    char[][] temp = new char[array.Length + 1][];
                    array.CopyTo(temp, 0);
                    temp[i] = StringToArray(input[i]);
                    array = temp;
                }
            }
            return array;
        }
        
        #endregion input

        #region output

        public const string OutputFormat = "{0} {1}";

        public static string ArrayToString(char[] array)
        {
            string output = String.Empty;
            if (array.Length == 0)
                output = " Пустой массив";
            else
                foreach (var item in array)
                    output = String.Format(OutputFormat, output, item);
            output = output + "\r\n";

            return output;
        }

        public static string ArrayToString(char[][] array)
        {
            string output = String.Empty;

            if (array.Length == 0)
                output = " Пустой массив\n";
            else
                foreach (var item in array)
                {
                    output = output + ArrayToString(item);
                }
            return output;
        }
        
        #endregion output

    }
}
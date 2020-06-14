using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryForAlgLab
{
    public static class GraphHelper
    {
        /// <summary>
        /// Выдает матрицу из файла, в котором она записана по строкам, а элементы столбцов разделены запятой.
        /// Матрица должна быть квадратной.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static int[][] GetMatrixFromFile(string fileName)
        {
            int[][] matrix = null;
            if (!File.Exists(fileName))
            {
                throw new Exception("Файл не существует или не найден");
            }

            string[] tmp = File.ReadAllLines(fileName);

            try
            {
                matrix = new int[tmp.Length][];

                string[] fromStringOfTmp;
                for (int i = 0; i < tmp.Length; i++)
                {
                    fromStringOfTmp = tmp[i].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    matrix[i] = new int[fromStringOfTmp.Length];

                    for (int j = 0; j < fromStringOfTmp.Length; j++)
                    {
                        matrix[i][j] = Convert.ToInt32(fromStringOfTmp[j]);
                    }
                }
                return matrix;
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так. Нажмите что-нибудь...");
                Console.ReadKey(true);
            }
            return matrix;
        }

        public static void SaveMatrixToFile(string fileName ,int[][] matrix)
        {
            StreamWriter writer = new StreamWriter(fileName);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    writer.Write(matrix[i][j] + ", ");
                }
                writer.WriteLine();
            }
            writer.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_TEST
{
    public class Calc
    {
        public static T[,] CsvRead<T>(string FilePath)
        {
            List<T[]> ReadArray = new List<T[]>();
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lines = line.Split(',');

                    T[] ConvertedLine = Array.ConvertAll(lines, xx => (T)Convert.ChangeType(xx,typeof(T)));
                    ReadArray.Add(ConvertedLine);
                }         
            }           

            T[,] ReadArray2D = new T[ReadArray.Count, ReadArray[0].Length];

            for (int y = 0; y < ReadArray.Count; y++)
            {
                for (int x = 0; x < ReadArray[0].Length; x++)
                {
                    ReadArray2D[y, x] = ReadArray[y][x];
                }
            }
            return ReadArray2D;
        }
        public static T[] Convert1Dfrom2D<T>(T[,] InputArray)
        {
            int RowNum = InputArray.GetLength(0);
            int ColNum = InputArray.GetLength(1);

            T[] OutputArray = new T[RowNum*ColNum];

            int index = 0;
            for (int y = 0; y < RowNum; y++)
            {
                for (int x = 0; x < ColNum; x++)
                {
                    index = y * ColNum + x;
                    OutputArray[index] = InputArray[y,x];
                }
            }
            return OutputArray;
        }

        public static T[,] SubAfromB<T>(T[,] A, T[,] B)
        {
            int RowNum = A.GetLength(0); int ColNum = A.GetLength(1);

            T[,] OutArray = new T[RowNum,ColNum];

            for (int y = 0; y < RowNum; y++)
            {
                for (int x = 0; x < ColNum; x++)
                {
                    dynamic ValA = A[y, x];
                    dynamic ValB = B[y, x];
                    OutArray[y,x] = ValA - ValB;
                }
            }
            return OutArray;
        }
    }
}

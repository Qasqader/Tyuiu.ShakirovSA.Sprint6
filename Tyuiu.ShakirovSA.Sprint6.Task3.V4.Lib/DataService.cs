using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakirovSA.Sprint6.Task3.V4.Lib
{
 
    public class DataService : ISprint6Task3V4
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[1, j] % 2 == 0)
                    {
                        matrix[1, j] = 0;
                    }
                }

                return matrix;
            }
    }
}

 
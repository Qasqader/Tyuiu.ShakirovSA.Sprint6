using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakirovSA.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
            public int[,] GetMatrix(string path)
            {
                string[] strings = File.ReadAllLines(path);

                int rows = strings.GetUpperBound(0) + 1;
                int cols = strings[0].Split(';').GetUpperBound(0) + 1;

                int[,] matrix = new int[rows, cols];

                for (int r = 0; r < rows; r++)
                {
                    string[] values = strings[r].Split(';');
                    for (int c = 0; c < cols; c++)
                    {
                        int value = int.Parse(values[c]);

                        if (r == 4 && value < 0)
                        {
                            matrix[r, c] = -1;
                        }
                        else
                        {
                            matrix[r, c] = value;
                        }
                    }
                }

                return matrix;
            }
        }
    }


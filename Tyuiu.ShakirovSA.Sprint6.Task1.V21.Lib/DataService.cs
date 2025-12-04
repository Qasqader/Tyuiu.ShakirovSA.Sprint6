using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakirovSA.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass;
            int len = (stopValue - startValue) + 1;
            mass = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(Math.Cos(i) + ((Math.Sin(i)) / (2 + 2 * i)) - 4 * i, 2);
                if (i == 1)
                {
                    y = 0;
                }
                mass[count] = y;
                count++;
            }
            return mass;
        }
    }
}

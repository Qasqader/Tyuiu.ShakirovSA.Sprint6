using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakirovSA.Sprint6.Task2.V29.Lib
{
    public class DataService : ISprint6Task2V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;
            int len = (stopValue - startValue) + 1;
            array = new double[len];
            int count = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
                array[count] = y;
                count++;
            }
            return array;
        }
    }
}

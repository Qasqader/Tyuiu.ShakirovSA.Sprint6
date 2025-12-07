using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakirovSA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] array = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    array[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            array = array.Where(x => x % 5 != 0 ).ToArray();
            return array;
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakirovSA.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using StreamReader reader = new StreamReader(path);
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split();
                    foreach(string word in words)
                    {
                        if (word.Contains('s'))
                        {
                            res = res + " " + word;
                        }
                    }
                }
            }
            return res;
        }
    }
}

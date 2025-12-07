using Tyuiu.ShakirovSA.Sprint6.Task5.V27.Lib;
namespace Tyuiu.ShakirovSA.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V27.txt");
        private void buttonResult_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 20;
            dataGridViewResult.Columns[1].Width = 75;
            this.chartDiagram.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagram.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDiagram.Series[0].Points.Clear();
            double[] niggers = new double[ds.len];
            niggers = ds.LoadFromDataFile(path);
            for (int i = 0; i < niggers.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(niggers[i]));
                chartDiagram.Series[0].Points.AddXY(i, niggers[i]);
            }
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-25-1 Шакиров Сергей Александрович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using Tyuiu.ShakirovSA.Sprint6.Task2.V29.Lib;
namespace Tyuiu.ShakirovSA.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxImportStart.Text);
                int stop = Convert.ToInt32(textBoxImportStop.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] array;
                array = new double[len];
                array = ds.GetMassFunction(start, stop);
                this.chartResult.Titles.Add("График функции");
                this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(start), Convert.ToString(array[i]));
                    this.chartResult.Series[0].Points.AddXY(start, array[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxResult_Enter(object sender, EventArgs e)
        {
            //
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Выполнил студент ИБКСб-25-1 Шакиров Сергей Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

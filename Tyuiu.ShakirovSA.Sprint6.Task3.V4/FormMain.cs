using Tyuiu.ShakirovSA.Sprint6.Task3.V4.Lib;

namespace Tyuiu.ShakirovSA.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { { -14, -7, 18, 12, -20 }, { -2, -15, -19, -19, -3 }, { -18, -5, -10, 14, -17 }, { -1, 2, -10, 0, 11 }, { 6, -18, 0, 19, 16 } };
        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            dataGridViewMatrix.RowCount = rows;
            dataGridViewMatrix.ColumnCount = cols;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int[,] matrix2 = ds.Calculate(matrix);
            int rows = matrix2.GetLength(0);
            int cols = matrix2.GetLength(1);
            dataGridViewResult.RowCount = rows;
            dataGridViewResult.ColumnCount = cols;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(matrix2[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Шакиров С.А. Студент группы ИБКСБ-25-1", "Спрвка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

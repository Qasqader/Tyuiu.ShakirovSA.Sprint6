using Tyuiu.ShakirovSA.Sprint6.Task6.V23.Lib;
namespace Tyuiu.ShakirovSA.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonImportFromFolder_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath);
            groupBoxImportFromFile.Text = groupBoxImportFromFile + " " + openFileDialogTask.FileName;
            buttonResult.Enabled = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void textBoxOut_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}

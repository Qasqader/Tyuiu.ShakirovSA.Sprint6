namespace Tyuiu.ShakirovSA.Sprint6.Task5.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelImport = new Panel();
            buttonHelp = new Button();
            buttonOpenFile = new Button();
            buttonResult = new Button();
            groupBoxHeading = new GroupBox();
            textBox1 = new TextBox();
            panelExport = new Panel();
            groupBoxExport = new GroupBox();
            dataGridViewResult = new DataGridView();
            panelChart = new Panel();
            chartDiagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterMain = new Splitter();
            panelImport.SuspendLayout();
            groupBoxHeading.SuspendLayout();
            panelExport.SuspendLayout();
            groupBoxExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagram).BeginInit();
            SuspendLayout();
            // 
            // panelImport
            // 
            panelImport.Controls.Add(buttonHelp);
            panelImport.Controls.Add(buttonOpenFile);
            panelImport.Controls.Add(buttonResult);
            panelImport.Controls.Add(groupBoxHeading);
            panelImport.Dock = DockStyle.Top;
            panelImport.Location = new Point(0, 0);
            panelImport.Name = "panelImport";
            panelImport.Size = new Size(800, 128);
            panelImport.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(665, 33);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(97, 62);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(527, 33);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(97, 62);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "Открыть Файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(399, 33);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(96, 62);
            buttonResult.TabIndex = 1;
            buttonResult.Text = "Решить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // groupBoxHeading
            // 
            groupBoxHeading.Controls.Add(textBox1);
            groupBoxHeading.Location = new Point(12, 12);
            groupBoxHeading.Name = "groupBoxHeading";
            groupBoxHeading.Size = new Size(332, 98);
            groupBoxHeading.TabIndex = 0;
            groupBoxHeading.TabStop = false;
            groupBoxHeading.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 76);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView.\r\nВывести все числа не кратные 5. Построить диаграмму по этим значениям.\r\n";
            // 
            // panelExport
            // 
            panelExport.Controls.Add(groupBoxExport);
            panelExport.Dock = DockStyle.Left;
            panelExport.Location = new Point(0, 128);
            panelExport.Name = "panelExport";
            panelExport.Size = new Size(181, 322);
            panelExport.TabIndex = 0;
            // 
            // groupBoxExport
            // 
            groupBoxExport.Controls.Add(dataGridViewResult);
            groupBoxExport.Dock = DockStyle.Fill;
            groupBoxExport.Location = new Point(0, 0);
            groupBoxExport.Name = "groupBoxExport";
            groupBoxExport.Size = new Size(181, 322);
            groupBoxExport.TabIndex = 0;
            groupBoxExport.TabStop = false;
            groupBoxExport.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Dock = DockStyle.Fill;
            dataGridViewResult.Location = new Point(3, 19);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.Size = new Size(175, 300);
            dataGridViewResult.TabIndex = 0;
            // 
            // panelChart
            // 
            panelChart.Controls.Add(chartDiagram);
            panelChart.Controls.Add(splitterMain);
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(181, 128);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(619, 322);
            panelChart.TabIndex = 0;
            // 
            // chartDiagram
            // 
            chartArea2.Name = "ChartArea1";
            chartDiagram.ChartAreas.Add(chartArea2);
            chartDiagram.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartDiagram.Legends.Add(legend2);
            chartDiagram.Location = new Point(3, 0);
            chartDiagram.Name = "chartDiagram";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDiagram.Series.Add(series2);
            chartDiagram.Size = new Size(616, 322);
            chartDiagram.TabIndex = 1;
            chartDiagram.Text = "chart1";
            // 
            // splitterMain
            // 
            splitterMain.Location = new Point(0, 0);
            splitterMain.Name = "splitterMain";
            splitterMain.Size = new Size(3, 322);
            splitterMain.TabIndex = 0;
            splitterMain.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChart);
            Controls.Add(panelExport);
            Controls.Add(panelImport);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 27 | Шакиров Сергей Александрович ";
            panelImport.ResumeLayout(false);
            groupBoxHeading.ResumeLayout(false);
            groupBoxHeading.PerformLayout();
            panelExport.ResumeLayout(false);
            groupBoxExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiagram).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelImport;
        private Panel panelExport;
        private Panel panelChart;
        private Splitter splitterMain;
        private GroupBox groupBoxExport;
        private DataGridView dataGridViewResult;
        private Button buttonHelp;
        private Button buttonOpenFile;
        private Button buttonResult;
        private GroupBox groupBoxHeading;
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram;
    }
}

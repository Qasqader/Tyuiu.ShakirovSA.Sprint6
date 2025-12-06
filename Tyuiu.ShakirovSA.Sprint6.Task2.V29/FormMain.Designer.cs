namespace Tyuiu.ShakirovSA.Sprint6.Task2.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxHeading = new GroupBox();
            label1 = new Label();
            labelHeading = new Label();
            groupBoxImport = new GroupBox();
            labelStop = new Label();
            labelImportData = new Label();
            textBoxImportStop = new TextBox();
            textBoxImportStart = new TextBox();
            buttonResult = new Button();
            buttonHelp = new Button();
            groupBoxResult = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            groupBoxHeading.SuspendLayout();
            groupBoxImport.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxHeading
            // 
            groupBoxHeading.Controls.Add(pictureBox1);
            groupBoxHeading.Controls.Add(label1);
            groupBoxHeading.Controls.Add(labelHeading);
            groupBoxHeading.Location = new Point(12, 12);
            groupBoxHeading.Name = "groupBoxHeading";
            groupBoxHeading.Size = new Size(343, 242);
            groupBoxHeading.TabIndex = 0;
            groupBoxHeading.TabStop = false;
            groupBoxHeading.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(304, 15);
            label1.TabIndex = 1;
            label1.Text = "Результат вывести в DataGridView и построить график";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Location = new Point(6, 19);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(328, 15);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Протабулировать функцию ниже на  заданном диапозоне";
            // 
            // groupBoxImport
            // 
            groupBoxImport.Controls.Add(labelStop);
            groupBoxImport.Controls.Add(labelImportData);
            groupBoxImport.Controls.Add(textBoxImportStop);
            groupBoxImport.Controls.Add(textBoxImportStart);
            groupBoxImport.Location = new Point(12, 273);
            groupBoxImport.Name = "groupBoxImport";
            groupBoxImport.Size = new Size(336, 101);
            groupBoxImport.TabIndex = 1;
            groupBoxImport.TabStop = false;
            groupBoxImport.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(208, 43);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(65, 15);
            labelStop.TabIndex = 5;
            labelStop.Text = "Стоп шага";
            // 
            // labelImportData
            // 
            labelImportData.AutoSize = true;
            labelImportData.Location = new Point(6, 43);
            labelImportData.Name = "labelImportData";
            labelImportData.Size = new Size(69, 15);
            labelImportData.TabIndex = 4;
            labelImportData.Text = "Старт шага";
            // 
            // textBoxImportStop
            // 
            textBoxImportStop.Location = new Point(208, 61);
            textBoxImportStop.Name = "textBoxImportStop";
            textBoxImportStop.Size = new Size(102, 23);
            textBoxImportStop.TabIndex = 3;
            // 
            // textBoxImportStart
            // 
            textBoxImportStart.Location = new Point(6, 61);
            textBoxImportStart.Name = "textBoxImportStart";
            textBoxImportStart.Size = new Size(102, 23);
            textBoxImportStart.TabIndex = 2;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Green;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Location = new Point(224, 412);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(131, 33);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Blue;
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Location = new Point(141, 396);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(53, 49);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(433, 6);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(751, 444);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            groupBoxResult.Enter += groupBoxResult_Enter;
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(334, 19);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(405, 420);
            chartResult.TabIndex = 1;
            chartResult.Text = "chart1";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult.Location = new Point(6, 19);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(292, 430);
            dataGridViewResult.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 78);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonHelp);
            Controls.Add(buttonResult);
            Controls.Add(groupBoxImport);
            Controls.Add(groupBoxHeading);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 29 | Шакиров С.А.";
            groupBoxHeading.ResumeLayout(false);
            groupBoxHeading.PerformLayout();
            groupBoxImport.ResumeLayout(false);
            groupBoxImport.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHeading;
        private Label labelHeading;
        private Label label1;
        private GroupBox groupBoxImport;
        private Label labelStop;
        private Label labelImportData;
        private TextBox textBoxImportStop;
        private TextBox textBoxImportStart;
        private Button buttonResult;
        private Button buttonHelp;
        private GroupBox groupBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private PictureBox pictureBox1;
    }
}

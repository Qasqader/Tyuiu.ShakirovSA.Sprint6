namespace Tyuiu.ShakirovSA.Sprint6.Task1.V21
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
            groupBoxUslovie = new GroupBox();
            buttonResult = new Button();
            buttonSupport = new Button();
            pictureBoxFormula = new PictureBox();
            labelUslovieNext = new Label();
            labelUslovie = new Label();
            groupBoxImport = new GroupBox();
            labelImportData = new Label();
            labelImportDataStop = new Label();
            textBoxDataImportStop = new TextBox();
            textBoxImportData = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxUslovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxImport.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie
            // 
            groupBoxUslovie.AutoSize = true;
            groupBoxUslovie.Controls.Add(buttonResult);
            groupBoxUslovie.Controls.Add(buttonSupport);
            groupBoxUslovie.Controls.Add(pictureBoxFormula);
            groupBoxUslovie.Controls.Add(labelUslovieNext);
            groupBoxUslovie.Controls.Add(labelUslovie);
            groupBoxUslovie.Location = new Point(25, 29);
            groupBoxUslovie.Name = "groupBoxUslovie";
            groupBoxUslovie.Size = new Size(352, 341);
            groupBoxUslovie.TabIndex = 0;
            groupBoxUslovie.TabStop = false;
            groupBoxUslovie.Text = "Условие";
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Green;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Location = new Point(151, 252);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(165, 67);
            buttonResult.TabIndex = 4;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            // 
            // buttonSupport
            // 
            buttonSupport.BackColor = SystemColors.HotTrack;
            buttonSupport.FlatStyle = FlatStyle.Flat;
            buttonSupport.Location = new Point(8, 252);
            buttonSupport.Name = "buttonSupport";
            buttonSupport.Size = new Size(71, 65);
            buttonSupport.TabIndex = 3;
            buttonSupport.Text = "?";
            buttonSupport.UseVisualStyleBackColor = false;
            buttonSupport.Click += buttonSupport_Click;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources.Formula1;
            pictureBoxFormula.Location = new Point(36, 86);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(262, 41);
            pictureBoxFormula.TabIndex = 2;
            pictureBoxFormula.TabStop = false;
            // 
            // labelUslovieNext
            // 
            labelUslovieNext.AutoSize = true;
            labelUslovieNext.Location = new Point(21, 61);
            labelUslovieNext.Name = "labelUslovieNext";
            labelUslovieNext.Size = new Size(165, 15);
            labelUslovieNext.TabIndex = 1;
            labelUslovieNext.Text = "Результат вывести в таблице";
            // 
            // labelUslovie
            // 
            labelUslovie.AutoSize = true;
            labelUslovie.Location = new Point(18, 35);
            labelUslovie.Name = "labelUslovie";
            labelUslovie.Size = new Size(328, 15);
            labelUslovie.TabIndex = 0;
            labelUslovie.Text = "Протабулировать функцию ниже на заданном диапозоне ";
            // 
            // groupBoxImport
            // 
            groupBoxImport.Controls.Add(labelImportData);
            groupBoxImport.Controls.Add(labelImportDataStop);
            groupBoxImport.Controls.Add(textBoxDataImportStop);
            groupBoxImport.Controls.Add(textBoxImportData);
            groupBoxImport.Location = new Point(27, 352);
            groupBoxImport.Name = "groupBoxImport";
            groupBoxImport.Size = new Size(359, 98);
            groupBoxImport.TabIndex = 1;
            groupBoxImport.TabStop = false;
            groupBoxImport.Text = "Ввод данных";
            // 
            // labelImportData
            // 
            labelImportData.AutoSize = true;
            labelImportData.Location = new Point(18, 33);
            labelImportData.Name = "labelImportData";
            labelImportData.Size = new Size(69, 15);
            labelImportData.TabIndex = 1;
            labelImportData.Text = "Старт шага";
            // 
            // labelImportDataStop
            // 
            labelImportDataStop.AutoSize = true;
            labelImportDataStop.Location = new Point(185, 33);
            labelImportDataStop.Name = "labelImportDataStop";
            labelImportDataStop.Size = new Size(72, 15);
            labelImportDataStop.TabIndex = 3;
            labelImportDataStop.Text = "Конец шага";
            // 
            // textBoxDataImportStop
            // 
            textBoxDataImportStop.Location = new Point(170, 54);
            textBoxDataImportStop.Name = "textBoxDataImportStop";
            textBoxDataImportStop.Size = new Size(104, 23);
            textBoxDataImportStop.TabIndex = 2;
            // 
            // textBoxImportData
            // 
            textBoxImportData.Location = new Point(6, 54);
            textBoxImportData.Name = "textBoxImportData";
            textBoxImportData.Size = new Size(106, 23);
            textBoxImportData.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(460, 20);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(340, 431);
            groupBoxResult.TabIndex = 2;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(16, 44);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(312, 345);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxImport);
            Controls.Add(groupBoxUslovie);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 21 | Шакиров С.А.";
            groupBoxUslovie.ResumeLayout(false);
            groupBoxUslovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxImport.ResumeLayout(false);
            groupBoxImport.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxUslovie;
        private Label labelUslovie;
        private PictureBox pictureBoxFormula;
        private Label labelUslovieNext;
        private GroupBox groupBoxImport;
        private Label labelImportDataStop;
        private TextBox textBoxDataImportStop;
        private Label labelImportData;
        private TextBox textBoxImportData;
        private Button buttonResult;
        private Button buttonSupport;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
    }
}

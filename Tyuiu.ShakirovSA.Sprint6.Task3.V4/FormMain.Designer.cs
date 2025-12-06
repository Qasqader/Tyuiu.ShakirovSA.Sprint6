namespace Tyuiu.ShakirovSA.Sprint6.Task3.V4
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
            groupBoxHeading = new GroupBox();
            groupBoxResult = new GroupBox();
            labelHeading = new Label();
            dataGridViewResult = new DataGridView();
            buttonResult = new Button();
            buttonHelp = new Button();
            dataGridViewMatrix = new DataGridView();
            groupBoxHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBoxHeading
            // 
            groupBoxHeading.Controls.Add(groupBoxResult);
            groupBoxHeading.Controls.Add(labelHeading);
            groupBoxHeading.Location = new Point(12, 28);
            groupBoxHeading.Name = "groupBoxHeading";
            groupBoxHeading.Size = new Size(450, 400);
            groupBoxHeading.TabIndex = 0;
            groupBoxHeading.TabStop = false;
            groupBoxHeading.Text = "Условие";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Location = new Point(440, 14);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(354, 380);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.BorderStyle = BorderStyle.FixedSingle;
            labelHeading.Font = new Font("Segoe UI", 10F);
            labelHeading.Location = new Point(6, 19);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(243, 154);
            labelHeading.TabIndex = 0;
            labelHeading.Text = "Дана матрица 5 на 5 \r\n-14  -7  18  12 -20\r\n-2 -15 -19 -19  -3\r\n-18  -5 -10  14 -1\r\n-1   2 -10   0  11\r\n6 -18   0  19  16\r\nВсе четные элементы второй строки\r\nзаменить на 0\r\n";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(497, 28);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.Size = new Size(291, 305);
            dataGridViewResult.TabIndex = 1;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(652, 392);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(136, 46);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(497, 392);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(136, 46);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(18, 204);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.Size = new Size(311, 242);
            dataGridViewMatrix.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(buttonHelp);
            Controls.Add(buttonResult);
            Controls.Add(dataGridViewResult);
            Controls.Add(groupBoxHeading);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 4 | Шакиров Сергей Александрович";
            Load += Form1_Load;
            groupBoxHeading.ResumeLayout(false);
            groupBoxHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHeading;
        private Label labelHeading;
        private DataGridView dataGridViewResult;
        private GroupBox groupBoxResult;
        private Button buttonResult;
        private Button buttonHelp;
        private DataGridView dataGridViewMatrix;
    }
}

namespace Tyuiu.ShakirovSA.Sprint6.Task0.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxTask = new TextBox();
            pictureBoxFormula = new PictureBox();
            labelUslovie = new Label();
            labelDataImport = new Label();
            labelVarX = new Label();
            labelDataExport = new Label();
            labelResult = new Label();
            textBoxVarX = new TextBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 67);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(459, 186);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить выражение по формуле:";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(478, 67);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(323, 44);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // labelUslovie
            // 
            labelUslovie.AutoSize = true;
            labelUslovie.Location = new Point(12, 44);
            labelUslovie.Name = "labelUslovie";
            labelUslovie.Size = new Size(67, 20);
            labelUslovie.TabIndex = 2;
            labelUslovie.Text = "Условие";
            // 
            // labelDataImport
            // 
            labelDataImport.AutoSize = true;
            labelDataImport.Location = new Point(12, 294);
            labelDataImport.Name = "labelDataImport";
            labelDataImport.Size = new Size(102, 20);
            labelDataImport.TabIndex = 3;
            labelDataImport.Text = "Ввод данных:";
            // 
            // labelVarX
            // 
            labelVarX.AutoSize = true;
            labelVarX.Location = new Point(29, 336);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(111, 20);
            labelVarX.TabIndex = 7;
            labelVarX.Text = "Переменная X";
            // 
            // labelDataExport
            // 
            labelDataExport.AutoSize = true;
            labelDataExport.Location = new Point(494, 294);
            labelDataExport.Name = "labelDataExport";
            labelDataExport.Size = new Size(112, 20);
            labelDataExport.TabIndex = 8;
            labelDataExport.Text = "Вывод Данных";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(494, 336);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(75, 20);
            labelResult.TabIndex = 9;
            labelResult.Text = "Результат";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(26, 369);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(125, 27);
            textBoxVarX.TabIndex = 4;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(494, 369);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(125, 27);
            textBoxResult.TabIndex = 10;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(694, 409);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(94, 29);
            buttonDone.TabIndex = 11;
            buttonDone.Text = "Результат";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(628, 409);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(60, 29);
            buttonHelp.TabIndex = 12;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(labelDataExport);
            Controls.Add(labelVarX);
            Controls.Add(textBoxVarX);
            Controls.Add(labelDataImport);
            Controls.Add(labelUslovie);
            Controls.Add(pictureBoxFormula);
            Controls.Add(textBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 15 | Шакиров А.С.";
            Load += this.FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask;
        private PictureBox pictureBoxFormula;
        private Label labelUslovie;
        private Label labelDataImport;
        private Label labelVarX;
        private Label labelDataExport;
        private Label labelResult;
        private TextBox textBoxVarX;
        private TextBox textBoxResult;
        private Button buttonDone;
        private Button buttonHelp;
    }
}

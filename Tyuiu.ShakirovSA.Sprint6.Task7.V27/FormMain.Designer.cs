namespace Tyuiu.ShakirovSA.Sprint6.Task7.V27
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelHeading = new Panel();
            buttonAbout = new Button();
            buttonSaveToFile = new Button();
            buttonResult = new Button();
            buttonOpenFile = new Button();
            groupBoxHeading = new GroupBox();
            textBoxHeading = new TextBox();
            panelImport = new Panel();
            groupBoxImprot = new GroupBox();
            dataGridViewIn = new DataGridView();
            panelExport = new Panel();
            groupBoxExport = new GroupBox();
            dataGridViewOut = new DataGridView();
            toolTipButton = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            panelHeading.SuspendLayout();
            groupBoxHeading.SuspendLayout();
            panelImport.SuspendLayout();
            groupBoxImprot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelExport.SuspendLayout();
            groupBoxExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelHeading
            // 
            panelHeading.Controls.Add(buttonAbout);
            panelHeading.Controls.Add(buttonSaveToFile);
            panelHeading.Controls.Add(buttonResult);
            panelHeading.Controls.Add(buttonOpenFile);
            panelHeading.Controls.Add(groupBoxHeading);
            panelHeading.Dock = DockStyle.Top;
            panelHeading.Location = new Point(0, 0);
            panelHeading.Name = "panelHeading";
            panelHeading.Size = new Size(834, 100);
            panelHeading.TabIndex = 0;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = Properties.Resources.information;
            buttonAbout.Location = new Point(709, 78);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(113, 22);
            buttonAbout.TabIndex = 1;
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            buttonAbout.MouseEnter += buttonAbout_MouseEnter;
            // 
            // buttonSaveToFile
            // 
            buttonSaveToFile.Enabled = false;
            buttonSaveToFile.Image = Properties.Resources.page_save;
            buttonSaveToFile.Location = new Point(255, 75);
            buttonSaveToFile.Name = "buttonSaveToFile";
            buttonSaveToFile.Size = new Size(113, 22);
            buttonSaveToFile.TabIndex = 1;
            buttonSaveToFile.UseVisualStyleBackColor = true;
            buttonSaveToFile.Click += buttonSaveToFile_Click;
            buttonSaveToFile.MouseEnter += buttonSaveToFile_MouseEnter;
            // 
            // buttonResult
            // 
            buttonResult.Enabled = false;
            buttonResult.Image = Properties.Resources.page_go;
            buttonResult.Location = new Point(125, 75);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(113, 22);
            buttonResult.TabIndex = 1;
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            buttonResult.MouseEnter += buttonResult_MouseEnter;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = Properties.Resources.folder_page;
            buttonOpenFile.Location = new Point(6, 75);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(113, 22);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            buttonOpenFile.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // groupBoxHeading
            // 
            groupBoxHeading.Controls.Add(textBoxHeading);
            groupBoxHeading.Dock = DockStyle.Top;
            groupBoxHeading.FlatStyle = FlatStyle.System;
            groupBoxHeading.Location = new Point(0, 0);
            groupBoxHeading.Name = "groupBoxHeading";
            groupBoxHeading.Size = new Size(834, 75);
            groupBoxHeading.TabIndex = 0;
            groupBoxHeading.TabStop = false;
            groupBoxHeading.Text = "Условие";
            // 
            // textBoxHeading
            // 
            textBoxHeading.Dock = DockStyle.Fill;
            textBoxHeading.Location = new Point(3, 19);
            textBoxHeading.Multiline = true;
            textBoxHeading.Name = "textBoxHeading";
            textBoxHeading.Size = new Size(828, 53);
            textBoxHeading.TabIndex = 0;
            textBoxHeading.Text = resources.GetString("textBoxHeading.Text");
            // 
            // panelImport
            // 
            panelImport.Controls.Add(groupBoxImprot);
            panelImport.Dock = DockStyle.Fill;
            panelImport.Location = new Point(0, 100);
            panelImport.Name = "panelImport";
            panelImport.Size = new Size(834, 361);
            panelImport.TabIndex = 0;
            // 
            // groupBoxImprot
            // 
            groupBoxImprot.Controls.Add(dataGridViewIn);
            groupBoxImprot.Dock = DockStyle.Fill;
            groupBoxImprot.Location = new Point(0, 0);
            groupBoxImprot.Name = "groupBoxImprot";
            groupBoxImprot.Size = new Size(834, 361);
            groupBoxImprot.TabIndex = 0;
            groupBoxImprot.TabStop = false;
            groupBoxImprot.Text = "Данные из файла";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 19);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.Size = new Size(828, 339);
            dataGridViewIn.TabIndex = 0;
            // 
            // panelExport
            // 
            panelExport.Controls.Add(groupBoxExport);
            panelExport.Dock = DockStyle.Right;
            panelExport.Location = new Point(334, 100);
            panelExport.Name = "panelExport";
            panelExport.Size = new Size(500, 361);
            panelExport.TabIndex = 0;
            // 
            // groupBoxExport
            // 
            groupBoxExport.Controls.Add(dataGridViewOut);
            groupBoxExport.Dock = DockStyle.Fill;
            groupBoxExport.Location = new Point(0, 0);
            groupBoxExport.Name = "groupBoxExport";
            groupBoxExport.Size = new Size(500, 361);
            groupBoxExport.TabIndex = 0;
            groupBoxExport.TabStop = false;
            groupBoxExport.Text = "Результат";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 19);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(494, 339);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 461);
            Controls.Add(panelExport);
            Controls.Add(panelImport);
            Controls.Add(panelHeading);
            Name = "FormMain";
            ShowInTaskbar = false;
            Text = "Спринт 6 | Таск 7 | Вариант 27 | Шакиров Сергей Александрович";
            panelHeading.ResumeLayout(false);
            groupBoxHeading.ResumeLayout(false);
            groupBoxHeading.PerformLayout();
            panelImport.ResumeLayout(false);
            groupBoxImprot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelExport.ResumeLayout(false);
            groupBoxExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeading;
        private Panel panelImport;
        private Panel panelExport;
        private Splitter splitter1;
        private GroupBox groupBoxHeading;
        private TextBox textBoxHeading;
        private GroupBox groupBoxImprot;
        private DataGridView dataGridViewIn;
        private GroupBox groupBoxExport;
        private DataGridView dataGridViewOut;
        private Button buttonOpenFile;
        private Button buttonAbout;
        private Button buttonSaveToFile;
        private Button buttonResult;
        private ToolTip toolTipButton;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
    }
}

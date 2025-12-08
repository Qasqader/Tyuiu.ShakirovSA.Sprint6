namespace Tyuiu.ShakirovSA.Sprint6.Task6.V23
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
            buttonResult = new Button();
            buttonImportFromFolder = new Button();
            groupBoxHeading = new GroupBox();
            textBoxHeading = new TextBox();
            panelImportFromFile = new Panel();
            groupBoxImportFromFile = new GroupBox();
            textBoxIn = new TextBox();
            panelResult = new Panel();
            groupBoxResult = new GroupBox();
            textBoxOut = new TextBox();
            splitterMain = new Splitter();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelHeading.SuspendLayout();
            groupBoxHeading.SuspendLayout();
            panelImportFromFile.SuspendLayout();
            groupBoxImportFromFile.SuspendLayout();
            panelResult.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeading
            // 
            panelHeading.Controls.Add(buttonAbout);
            panelHeading.Controls.Add(buttonResult);
            panelHeading.Controls.Add(buttonImportFromFolder);
            panelHeading.Controls.Add(groupBoxHeading);
            panelHeading.Dock = DockStyle.Top;
            panelHeading.Location = new Point(0, 0);
            panelHeading.Name = "panelHeading";
            panelHeading.Size = new Size(834, 132);
            panelHeading.TabIndex = 0;
            // 
            // buttonAbout
            // 
            buttonAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout.Image = Properties.Resources.help;
            buttonAbout.Location = new Point(736, 10);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(86, 51);
            buttonAbout.TabIndex = 1;
            toolTip.SetToolTip(buttonAbout, "Справка.\r\nО разработчике.");
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonResult
            // 
            buttonResult.Enabled = false;
            buttonResult.Image = Properties.Resources.page_go;
            buttonResult.Location = new Point(160, 12);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(86, 51);
            buttonResult.TabIndex = 1;
            toolTip.SetToolTip(buttonResult, "Выполнить.\r\nВыполнить задание из условия.\r\n");
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonImportFromFolder
            // 
            buttonImportFromFolder.Image = Properties.Resources.folder_page;
            buttonImportFromFolder.Location = new Point(37, 14);
            buttonImportFromFolder.Name = "buttonImportFromFolder";
            buttonImportFromFolder.Size = new Size(91, 47);
            buttonImportFromFolder.TabIndex = 1;
            toolTip.SetToolTip(buttonImportFromFolder, "Открыть файл.\r\nВыберите нужный файл на компьютере\r\n");
            buttonImportFromFolder.UseVisualStyleBackColor = true;
            buttonImportFromFolder.Click += buttonImportFromFolder_Click;
            // 
            // groupBoxHeading
            // 
            groupBoxHeading.Controls.Add(textBoxHeading);
            groupBoxHeading.Dock = DockStyle.Bottom;
            groupBoxHeading.Location = new Point(0, 59);
            groupBoxHeading.Name = "groupBoxHeading";
            groupBoxHeading.Size = new Size(834, 73);
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
            textBoxHeading.Size = new Size(828, 51);
            textBoxHeading.TabIndex = 1;
            textBoxHeading.Text = resources.GetString("textBoxHeading.Text");
            // 
            // panelImportFromFile
            // 
            panelImportFromFile.Controls.Add(groupBoxImportFromFile);
            panelImportFromFile.Dock = DockStyle.Left;
            panelImportFromFile.Location = new Point(0, 132);
            panelImportFromFile.Name = "panelImportFromFile";
            panelImportFromFile.Size = new Size(198, 329);
            panelImportFromFile.TabIndex = 0;
            // 
            // groupBoxImportFromFile
            // 
            groupBoxImportFromFile.Controls.Add(textBoxIn);
            groupBoxImportFromFile.Dock = DockStyle.Fill;
            groupBoxImportFromFile.Location = new Point(0, 0);
            groupBoxImportFromFile.Name = "groupBoxImportFromFile";
            groupBoxImportFromFile.Size = new Size(198, 329);
            groupBoxImportFromFile.TabIndex = 0;
            groupBoxImportFromFile.TabStop = false;
            groupBoxImportFromFile.Text = "Данные из выбранного файла";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 19);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.Size = new Size(192, 307);
            textBoxIn.TabIndex = 0;
            // 
            // panelResult
            // 
            panelResult.Controls.Add(groupBoxResult);
            panelResult.Controls.Add(splitterMain);
            panelResult.Dock = DockStyle.Fill;
            panelResult.Location = new Point(198, 132);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(636, 329);
            panelResult.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxOut);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(3, 0);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(633, 329);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(3, 19);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.Size = new Size(627, 307);
            textBoxOut.TabIndex = 0;
            textBoxOut.TextChanged += textBoxOut_TextChanged;
            // 
            // splitterMain
            // 
            splitterMain.Location = new Point(0, 0);
            splitterMain.Name = "splitterMain";
            splitterMain.Size = new Size(3, 329);
            splitterMain.TabIndex = 0;
            splitterMain.TabStop = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 461);
            Controls.Add(panelResult);
            Controls.Add(panelImportFromFile);
            Controls.Add(panelHeading);
            MinimumSize = new Size(850, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 23 | Шакиров Сергей Александрович ";
            Load += Form1_Load;
            panelHeading.ResumeLayout(false);
            groupBoxHeading.ResumeLayout(false);
            groupBoxHeading.PerformLayout();
            panelImportFromFile.ResumeLayout(false);
            groupBoxImportFromFile.ResumeLayout(false);
            groupBoxImportFromFile.PerformLayout();
            panelResult.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeading;
        private Panel panelImportFromFile;
        private Panel panelResult;
        private GroupBox groupBoxHeading;
        private GroupBox groupBoxImportFromFile;
        private TextBox textBoxIn;
        private GroupBox groupBoxResult;
        private Splitter splitterMain;
        private TextBox textBoxHeading;
        private TextBox textBoxOut;
        private Button buttonImportFromFolder;
        private Button buttonResult;
        private Button buttonAbout;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}

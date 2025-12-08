namespace Tyuiu.ShakirovSA.Sprint6.Task6.V23
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            Label labelAbout;
            pictureBoxAvatar = new PictureBox();
            buttonOK = new Button();
            labelAbout = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = (Image)resources.GetObject("pictureBoxAvatar.Image");
            pictureBoxAvatar.Location = new Point(12, 23);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(147, 176);
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // labelAbout
            // 
            labelAbout.Location = new Point(190, 23);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(206, 132);
            labelAbout.TabIndex = 1;
            labelAbout.Text = "Выполнил Шакиров Сергей Александрович\r\nСтудент группы ИБКСБ-25-1\r\n";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(288, 154);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 45);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 211);
            Controls.Add(buttonOK);
            Controls.Add(labelAbout);
            Controls.Add(pictureBoxAvatar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAvatar;
        private Button buttonOK;
    }
}
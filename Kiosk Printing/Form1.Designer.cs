namespace Kiosk_Printing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBoxWord = new PictureBox();
            pictureBoxExcel = new PictureBox();
            pictureBoxPpt = new PictureBox();
            pictureBoxPdf = new PictureBox();
            pictureBoxEject = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExcel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPpt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPdf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEject).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 110.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(315, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1322, 167);
            label1.TabIndex = 0;
            label1.Text = "KIOSK PRINTING";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(484, 160);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(344, 106);
            label2.TabIndex = 1;
            label2.Text = "just plug";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(1019, 160);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(389, 106);
            label3.TabIndex = 2;
            label3.Text = "and print";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.more;
            pictureBox1.Location = new Point(834, 148);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxWord
            // 
            pictureBoxWord.BackColor = Color.Transparent;
            pictureBoxWord.Image = Properties.Resources.Microsoft_Office_Word;
            pictureBoxWord.Location = new Point(143, 636);
            pictureBoxWord.Margin = new Padding(2);
            pictureBoxWord.Name = "pictureBoxWord";
            pictureBoxWord.Size = new Size(287, 341);
            pictureBoxWord.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWord.TabIndex = 4;
            pictureBoxWord.TabStop = false;
            pictureBoxWord.Click += pictureBoxWord_Click;
            // 
            // pictureBoxExcel
            // 
            pictureBoxExcel.BackColor = Color.Transparent;
            pictureBoxExcel.Image = Properties.Resources.Microsoft_Office_Excel;
            pictureBoxExcel.Location = new Point(551, 636);
            pictureBoxExcel.Margin = new Padding(2);
            pictureBoxExcel.Name = "pictureBoxExcel";
            pictureBoxExcel.Size = new Size(287, 341);
            pictureBoxExcel.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxExcel.TabIndex = 5;
            pictureBoxExcel.TabStop = false;
            pictureBoxExcel.Click += pictureBoxExcel_Click;
            // 
            // pictureBoxPpt
            // 
            pictureBoxPpt.BackColor = Color.Transparent;
            pictureBoxPpt.Image = Properties.Resources.Microsoft_Office_PowerPoint;
            pictureBoxPpt.Location = new Point(967, 636);
            pictureBoxPpt.Margin = new Padding(2);
            pictureBoxPpt.Name = "pictureBoxPpt";
            pictureBoxPpt.Size = new Size(287, 341);
            pictureBoxPpt.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPpt.TabIndex = 6;
            pictureBoxPpt.TabStop = false;
            pictureBoxPpt.Click += pictureBoxPpt_Click;
            // 
            // pictureBoxPdf
            // 
            pictureBoxPdf.BackColor = Color.Transparent;
            pictureBoxPdf.Image = Properties.Resources.PDF_file_icon;
            pictureBoxPdf.Location = new Point(1375, 636);
            pictureBoxPdf.Margin = new Padding(2);
            pictureBoxPdf.Name = "pictureBoxPdf";
            pictureBoxPdf.Size = new Size(287, 341);
            pictureBoxPdf.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPdf.TabIndex = 7;
            pictureBoxPdf.TabStop = false;
            pictureBoxPdf.Click += pictureBoxPdf_Click;
            // 
            // pictureBoxEject
            // 
            pictureBoxEject.BackColor = Color.Transparent;
            pictureBoxEject.Image = Properties.Resources.usb;
            pictureBoxEject.Location = new Point(1812, 1001);
            pictureBoxEject.Margin = new Padding(2);
            pictureBoxEject.Name = "pictureBoxEject";
            pictureBoxEject.Size = new Size(96, 70);
            pictureBoxEject.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEject.TabIndex = 8;
            pictureBoxEject.TabStop = false;
            pictureBoxEject.Click += pictureBoxEject_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(484, 532);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(820, 43);
            label4.TabIndex = 9;
            label4.Text = "Select which type of Document would you like to Print";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1920, 1083);
            Controls.Add(label4);
            Controls.Add(pictureBoxEject);
            Controls.Add(pictureBoxPdf);
            Controls.Add(pictureBoxPpt);
            Controls.Add(pictureBoxExcel);
            Controls.Add(pictureBoxWord);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExcel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPpt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPdf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxWord;
        private PictureBox pictureBoxExcel;
        private PictureBox pictureBoxPpt;
        private PictureBox pictureBoxPdf;
        private PictureBox pictureBoxEject;
        private Label label4;
    }
}
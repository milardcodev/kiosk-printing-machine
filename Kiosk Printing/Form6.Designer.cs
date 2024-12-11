namespace Kiosk_Printing
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            label4 = new Label();
            FirstDrive = new Button();
            SecondDrive = new Button();
            ThirdDrive = new Button();
            FourthDrive = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(1067, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(289, 80);
            label3.TabIndex = 37;
            label3.Text = "and print";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(604, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(259, 80);
            label2.TabIndex = 36;
            label2.Text = "just plug";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 90F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(460, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1081, 135);
            label1.TabIndex = 35;
            label1.Text = "KIOSK PRINTING";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.more;
            pictureBox1.Location = new Point(869, 101);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(245, 241);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(1651, 733);
            listView1.TabIndex = 39;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(35, 270);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(198, 52);
            label4.TabIndex = 40;
            label4.Text = "LIST OF \r\nACTIVE DRIVES";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // FirstDrive
            // 
            FirstDrive.BackColor = Color.Transparent;
            FirstDrive.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstDrive.ForeColor = Color.Black;
            FirstDrive.Location = new Point(39, 381);
            FirstDrive.Margin = new Padding(2);
            FirstDrive.Name = "FirstDrive";
            FirstDrive.Size = new Size(173, 84);
            FirstDrive.TabIndex = 47;
            FirstDrive.UseVisualStyleBackColor = false;
            FirstDrive.Click += FirstDrive_Click;
            // 
            // SecondDrive
            // 
            SecondDrive.BackColor = Color.Transparent;
            SecondDrive.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SecondDrive.ForeColor = Color.Black;
            SecondDrive.Location = new Point(39, 533);
            SecondDrive.Margin = new Padding(2);
            SecondDrive.Name = "SecondDrive";
            SecondDrive.Size = new Size(173, 84);
            SecondDrive.TabIndex = 48;
            SecondDrive.UseVisualStyleBackColor = false;
            SecondDrive.Click += SecondDrive_Click;
            // 
            // ThirdDrive
            // 
            ThirdDrive.BackColor = Color.Transparent;
            ThirdDrive.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThirdDrive.ForeColor = Color.Black;
            ThirdDrive.Location = new Point(39, 691);
            ThirdDrive.Margin = new Padding(2);
            ThirdDrive.Name = "ThirdDrive";
            ThirdDrive.Size = new Size(173, 84);
            ThirdDrive.TabIndex = 49;
            ThirdDrive.UseVisualStyleBackColor = false;
            ThirdDrive.Click += ThirdDrive_Click;
            // 
            // FourthDrive
            // 
            FourthDrive.BackColor = Color.Transparent;
            FourthDrive.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FourthDrive.ForeColor = Color.Black;
            FourthDrive.Location = new Point(39, 841);
            FourthDrive.Margin = new Padding(2);
            FourthDrive.Name = "FourthDrive";
            FourthDrive.Size = new Size(173, 84);
            FourthDrive.TabIndex = 50;
            FourthDrive.UseVisualStyleBackColor = false;
            FourthDrive.Click += FourthDrive_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Transparent;
            btnSelect.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.Black;
            btnSelect.Location = new Point(972, 1001);
            btnSelect.Margin = new Padding(2);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(197, 58);
            btnSelect.TabIndex = 51;
            btnSelect.Text = "SELECT";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1920, 1083);
            Controls.Add(btnSelect);
            Controls.Add(FourthDrive);
            Controls.Add(ThirdDrive);
            Controls.Add(SecondDrive);
            Controls.Add(FirstDrive);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ListView listView1;
        private Label label4;
        private Button FirstDrive;
        private Button SecondDrive;
        private Button ThirdDrive;
        private Button FourthDrive;
        private Button btnSelect;
    }
}
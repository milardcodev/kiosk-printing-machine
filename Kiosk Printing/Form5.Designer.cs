namespace Kiosk_Printing
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBoxBack = new PictureBox();
            label14 = new Label();
            pictureBoxInsert = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            displayInsert = new Button();
            displayPay = new Button();
            displayPrice = new Button();
            displayPagePrint = new Button();
            label9 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            radioButtonCustom = new RadioButton();
            radioButtonAll = new RadioButton();
            pictureBoxPrinter = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            displayPage = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBoxSearch = new PictureBox();
            displayName = new Button();
            pictureBoxPdf = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInsert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrinter).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPdf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.BackColor = Color.Transparent;
            pictureBoxBack.Image = Properties.Resources.back1;
            pictureBoxBack.Location = new Point(1812, 1001);
            pictureBoxBack.Margin = new Padding(2);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(96, 70);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBack.TabIndex = 57;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Times New Roman", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(853, 1040);
            label14.Name = "label14";
            label14.Size = new Size(160, 31);
            label14.TabIndex = 55;
            label14.Text = "Insert Money";
            // 
            // pictureBoxInsert
            // 
            pictureBoxInsert.BackColor = Color.Transparent;
            pictureBoxInsert.Image = Properties.Resources.insert_coin;
            pictureBoxInsert.Location = new Point(824, 857);
            pictureBoxInsert.Margin = new Padding(2);
            pictureBoxInsert.Name = "pictureBoxInsert";
            pictureBoxInsert.Size = new Size(245, 162);
            pictureBoxInsert.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInsert.TabIndex = 54;
            pictureBoxInsert.TabStop = false;
            pictureBoxInsert.Click += pictureBoxInsert_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(704, 794);
            label13.Name = "label13";
            label13.Size = new Size(191, 31);
            label13.TabIndex = 53;
            label13.Text = "Inserted Money:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(704, 743);
            label12.Name = "label12";
            label12.Size = new Size(191, 31);
            label12.TabIndex = 52;
            label12.Text = "Amount To Pay:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(704, 690);
            label11.Name = "label11";
            label11.Size = new Size(176, 31);
            label11.TabIndex = 51;
            label11.Text = "Price Per Page:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(704, 639);
            label10.Name = "label10";
            label10.Size = new Size(257, 31);
            label10.TabIndex = 50;
            label10.Text = "No. Of Pages To Print:";
            // 
            // displayInsert
            // 
            displayInsert.BackColor = Color.Transparent;
            displayInsert.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayInsert.ForeColor = Color.Black;
            displayInsert.Location = new Point(988, 790);
            displayInsert.Name = "displayInsert";
            displayInsert.Size = new Size(166, 39);
            displayInsert.TabIndex = 49;
            displayInsert.UseVisualStyleBackColor = false;
            displayInsert.Click += button7_Click;
            // 
            // displayPay
            // 
            displayPay.BackColor = Color.Transparent;
            displayPay.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayPay.ForeColor = Color.Black;
            displayPay.Location = new Point(988, 739);
            displayPay.Name = "displayPay";
            displayPay.Size = new Size(166, 39);
            displayPay.TabIndex = 48;
            displayPay.UseVisualStyleBackColor = false;
            // 
            // displayPrice
            // 
            displayPrice.BackColor = Color.Transparent;
            displayPrice.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayPrice.ForeColor = Color.Black;
            displayPrice.Location = new Point(988, 686);
            displayPrice.Name = "displayPrice";
            displayPrice.Size = new Size(166, 39);
            displayPrice.TabIndex = 47;
            displayPrice.Text = "5.00";
            displayPrice.UseVisualStyleBackColor = false;
            // 
            // displayPagePrint
            // 
            displayPagePrint.BackColor = Color.Transparent;
            displayPagePrint.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayPagePrint.ForeColor = Color.Black;
            displayPagePrint.Location = new Point(988, 635);
            displayPagePrint.Name = "displayPagePrint";
            displayPagePrint.Size = new Size(166, 39);
            displayPagePrint.TabIndex = 46;
            displayPagePrint.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(318, 144);
            label9.Name = "label9";
            label9.Size = new Size(46, 42);
            label9.TabIndex = 19;
            label9.Text = "to";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown2.Location = new Point(382, 142);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(73, 50);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(214, 142);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(73, 50);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonCustom.Location = new Point(214, 69);
            radioButtonCustom.Name = "radioButtonCustom";
            radioButtonCustom.Size = new Size(151, 46);
            radioButtonCustom.TabIndex = 1;
            radioButtonCustom.TabStop = true;
            radioButtonCustom.Text = "Custom";
            radioButtonCustom.UseVisualStyleBackColor = true;
            radioButtonCustom.CheckedChanged += radioButtonCustom_CheckedChanged;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonAll.Location = new Point(56, 69);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(79, 46);
            radioButtonAll.TabIndex = 0;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.CheckedChanged += radioButtonAll_CheckedChanged;
            // 
            // pictureBoxPrinter
            // 
            pictureBoxPrinter.BackColor = Color.Transparent;
            pictureBoxPrinter.Image = Properties.Resources.printer;
            pictureBoxPrinter.Location = new Point(1383, 695);
            pictureBoxPrinter.Margin = new Padding(2);
            pictureBoxPrinter.Name = "pictureBoxPrinter";
            pictureBoxPrinter.Size = new Size(310, 241);
            pictureBoxPrinter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPrinter.TabIndex = 56;
            pictureBoxPrinter.TabStop = false;
            pictureBoxPrinter.Click += pictureBoxPrinter_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(radioButtonCustom);
            groupBox1.Controls.Add(radioButtonAll);
            groupBox1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(46, 776);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 243);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Page Range";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(245, 699);
            button3.Name = "button3";
            button3.Size = new Size(166, 39);
            button3.TabIndex = 44;
            button3.Text = "A4 (Default)";
            button3.UseVisualStyleBackColor = false;
            // 
            // displayPage
            // 
            displayPage.BackColor = Color.Transparent;
            displayPage.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayPage.ForeColor = Color.Black;
            displayPage.Location = new Point(245, 639);
            displayPage.Name = "displayPage";
            displayPage.Size = new Size(166, 39);
            displayPage.TabIndex = 43;
            displayPage.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(40, 703);
            label8.Name = "label8";
            label8.Size = new Size(142, 31);
            label8.TabIndex = 42;
            label8.Text = "Paper Size: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(40, 643);
            label7.Name = "label7";
            label7.Size = new Size(164, 31);
            label7.TabIndex = 41;
            label7.Text = "No. of Pages: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(1460, 553);
            label6.Name = "label6";
            label6.Size = new Size(133, 42);
            label6.TabIndex = 40;
            label6.Text = "PRINT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(883, 553);
            label5.Name = "label5";
            label5.Size = new Size(202, 42);
            label5.TabIndex = 39;
            label5.Text = "PAYMENT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(131, 553);
            label4.Name = "label4";
            label4.Size = new Size(255, 42);
            label4.TabIndex = 38;
            label4.Text = "PROPERTIES";
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.BackColor = Color.Transparent;
            pictureBoxSearch.Image = Properties.Resources.search;
            pictureBoxSearch.Location = new Point(1239, 451);
            pictureBoxSearch.Margin = new Padding(2);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(81, 59);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSearch.TabIndex = 37;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.Click += pictureBoxSearch_Click;
            // 
            // displayName
            // 
            displayName.BackColor = Color.Transparent;
            displayName.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayName.ForeColor = Color.Black;
            displayName.Location = new Point(651, 462);
            displayName.Name = "displayName";
            displayName.Size = new Size(572, 39);
            displayName.TabIndex = 36;
            displayName.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPdf
            // 
            pictureBoxPdf.BackColor = Color.Transparent;
            pictureBoxPdf.Image = Properties.Resources.PDF_file_icon;
            pictureBoxPdf.Location = new Point(779, 241);
            pictureBoxPdf.Margin = new Padding(2);
            pictureBoxPdf.Name = "pictureBoxPdf";
            pictureBoxPdf.Size = new Size(290, 215);
            pictureBoxPdf.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPdf.TabIndex = 35;
            pictureBoxPdf.TabStop = false;
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
            label3.TabIndex = 33;
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
            label2.TabIndex = 32;
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
            label1.TabIndex = 31;
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
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1920, 1083);
            Controls.Add(pictureBoxBack);
            Controls.Add(label14);
            Controls.Add(pictureBoxInsert);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(displayInsert);
            Controls.Add(displayPay);
            Controls.Add(displayPrice);
            Controls.Add(displayPagePrint);
            Controls.Add(pictureBoxPrinter);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(displayPage);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBoxSearch);
            Controls.Add(displayName);
            Controls.Add(pictureBoxPdf);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInsert).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrinter).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPdf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxBack;
        private Label label14;
        private PictureBox pictureBoxInsert;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button displayInsert;
        private Button displayPay;
        private Button displayPrice;
        private Button displayPagePrint;
        private Label label9;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private RadioButton radioButtonCustom;
        private RadioButton radioButtonAll;
        private PictureBox pictureBoxPrinter;
        private GroupBox groupBox1;
        private Button button3;
        private Button displayPage;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBoxSearch;
        private Button displayName;
        private PictureBox pictureBoxPdf;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
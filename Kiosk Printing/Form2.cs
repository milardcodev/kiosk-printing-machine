﻿using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;

namespace Kiosk_Printing
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
            label9.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            Visible = false;
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateResult()
        {
            
        }

        private void pictureBoxInsert_Click(object sender, EventArgs e)
        {
            
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            
        }

        private void pictureBoxPrinter_Click(object sender, EventArgs e)
        {
            
        }

        private void PrintWordDocument(string selectedDocumentName, int startPage, int endPage)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;   
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}
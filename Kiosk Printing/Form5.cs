using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Printing
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
            label9.Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
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

        private void PrintDocument(string selectedDocumentName, int startPage, int endPage)
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

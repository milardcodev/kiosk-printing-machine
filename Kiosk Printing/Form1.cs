using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Kiosk_Printing
{
    public partial class Form1 : Form
    {
        SoundPlayer player1 = new SoundPlayer(@"C:\Users\kiosk\source\repos\Kiosk Printing\Kiosk Printing\Resources\NO-USB.wav");
        SoundPlayer player2 = new SoundPlayer(@"C:\Users\kiosk\source\repos\Kiosk Printing\Kiosk Printing\Resources\USB.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagementEventWatcher watcher = new ManagementEventWatcher();
            WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2");
            watcher.EventArrived += (s, args) =>
            {
                player2.Play();
            };

            watcher.Query = query;
            watcher.Start();
        }

        private void pictureBoxWord_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                Form6 f6 = new Form6();
                f6.Show();
                Visible = false;
            }
            else
            {
                player1.Play();
            }
        }

        private void pictureBoxExcel_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                Form7 f7 = new Form7();
                f7.Show();
                Visible = false;
            }
            else
            {
                player1.Play();
            }
        }

        private void pictureBoxPpt_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                Form8 f8 = new Form8();
                f8.Show();
                Visible = false;
            }
            else
            {
                player1.Play();
            }
        }

        private void pictureBoxPdf_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                Form9 f9 = new Form9();
                f9.Show();
                Visible = false;
            }
            else
            {
                player1.Play();
            }
        }

        private void pictureBoxEject_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                string status = EjectFlashdriveManager.EjectFlashdrive(Convert.ToChar(drives.FirstOrDefault().Name.Replace(":\\", "")));
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                string message = status;
                string title = "USB Flash Drive Removal Confirmation";
                MessageBox.Show(message, title, buttons, icon);
            }
            else
            {
                player1.Play();
            }
        }
    }
}

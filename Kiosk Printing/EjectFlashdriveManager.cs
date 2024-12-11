using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk_Printing
{
    public static class EjectFlashdriveManager
    {
        const int OPEN_EXISTING = 3;
        const uint GENERIC_READ = 0x80000000;
        const uint GENERIC_WRITE = 0x40000000;
        const uint IOCTL_STORAGE_EJECT_MEDIA = 0x2D4808;

        [DllImport("kernel32")]
        private static extern int CloseHandle(IntPtr handle);
        [DllImport("kernel32")]
        private static extern int DeviceIoControl(IntPtr deviceHandle, uint ioControlCode, IntPtr inBuffer, int inBufferSize, IntPtr outBuffer, int outBufferSize, ref int bytesReturned, IntPtr overlapped);
        [DllImport("kernel32")]
        private static extern IntPtr CreateFile(string filename, uint desiredAccess, uint shareMode, IntPtr securityAttributes, int creationDisposition, int flagsAndAttributes, IntPtr templateFile);
        /// <summary>
        /// To eject pendrive 
        /// </summary>
        /// <param name="driveLetterCharacter">char</param>
        /// <returns></returns>
        public static string EjectFlashdrive(char driveLetterCharacter)
        {
            string pathfordrive = "\\\\.\\" + driveLetterCharacter + ":";
            IntPtr handle = CreateFile(pathfordrive, GENERIC_READ | GENERIC_WRITE, 0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
            if ((long)handle == -1)
            {
                return "Unable to open the USB flash drive." + driveLetterCharacter;
            }

            int dummy = 0;
            DeviceIoControl(handle, IOCTL_STORAGE_EJECT_MEDIA, IntPtr.Zero, 0, IntPtr.Zero, 0, ref dummy, IntPtr.Zero);
            CloseHandle(handle);
            return "The USB flash drive has been successfully removed from the system. It is now safe to disconnect the device from the computer.";
        }
    }
}
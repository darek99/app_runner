using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace app_runner
{
    public class SystemTime
    {
        private SYSTEMTIME systemTime;

        public SystemTime(DateTime dateTime)
        {
            try
            {
                systemTime = new SYSTEMTIME();

                GetSystemTime(out systemTime);

                if (Debugger.IsAttached)
                {
                    Debug.WriteLine("READ system day: {0}", systemTime.wDay);
                    Debug.WriteLine("READ system hour: {0}", systemTime.wHour);
                }

                CorectSystemTime(dateTime);
                SetSystemTime(ref systemTime);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void CorectSystemTime(DateTime dateTime)
        {
            systemTime.wDay = (short)dateTime.Day;
            systemTime.wMonth = (short)dateTime.Month;
            systemTime.wYear = (short)dateTime.Year;
            systemTime.wHour = (short)dateTime.Hour;
            systemTime.wMinute = (short)dateTime.Minute;
            systemTime.wSecond = (short)dateTime.Second;

            if (Debugger.IsAttached)
            {
                Debug.WriteLine("SAVE system day-mounth: {0}-{1}", systemTime.wDay, systemTime.wMonth);
                Debug.WriteLine("SAVE system time: {0}-{1}", systemTime.wHour, systemTime.wMinute);
            }
        }

        [DllImport("kernel32", SetLastError = true)]
        internal static extern bool GetSystemTime(out SYSTEMTIME systemTime);

        [DllImport("kernel32", SetLastError = true)]
        internal static extern bool SetSystemTime(ref SYSTEMTIME systemTime);

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear, wMonth, wDayOfWeek, wDay, wHour, wMinute, wSecond, wMilliseconds;
        }
    }
}
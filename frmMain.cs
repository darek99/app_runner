using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUBIEKT_RUNNER
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        struct SYSTEMTIME
        {
            internal short wYear;
            internal short wMonth;
            internal short wDayOfWeek;
            internal short wDay;
            internal short wHour;
            internal short wMinute;
            internal short wSecond;
            internal short wMilliseconds;
        }

        [System.Runtime.InteropServices.DllImport("kernel32", SetLastError = true)]
        private static extern bool GetSystemTime(out SYSTEMTIME systemTime);
        [System.Runtime.InteropServices.DllImport("kernel32", SetLastError = true)]
        private static extern bool SetSystemTime(ref SYSTEMTIME systemTime);


        private void ChangneSystemDate(DateTime date)
        {
            SYSTEMTIME st = new SYSTEMTIME();
            st.wHour = (short)date.Hour;
            st.wMinute = (short)date.Minute;
            st.wSecond = (short)date.Second;
            st.wMilliseconds = (short)date.Millisecond;
            st.wDay = (short)date.Day;
            st.wMonth = (short)date.Month;
            st.wYear = (short)date.Year;

            SetSystemTime(ref st);
        }

        // pokazuje MessageBox z informacjami o autorze i wersji aplikacji
        private void ShowInformationMessageBox()
        {
            var co = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), true);
            var cr = ((AssemblyCopyrightAttribute)co[0]).Copyright;
            var im = string.Format("{0}\nwersja: {1}", cr, Application.ProductVersion);

            MessageBox.Show(im, Application.ProductName);
        }

        private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            ShowInformationMessageBox();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNextDate_Click(object sender, EventArgs e)
        {
            datePicker.Value = datePicker.Value.AddDays(1);
        }

        private void btnPreviousDate_Click(object sender, EventArgs e)
        {
            datePicker.Value = datePicker.Value.AddDays(-1);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            // zmiana daty na inną
            datePicker.Value = DateTime.Now;
            _ = MessageBox.Show(datePicker.Value.ToString());

            //ChangneSystemDate(datePicker.Value);
        }

    }
}

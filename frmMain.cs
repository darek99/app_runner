using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace SUBIEKT_RUNNER
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // pobiera aktualną wartość daty i czasu systemowego
            // ustawia datePicer.Value

            datePicker.Value = DateTime.Now;
        }

        private struct SYSTEMTIME
        {
            internal short wYear, wMonth, wDayOfWeek, wDay, wHour, wMinute, wSecond, wMilliseconds;
        }

        [System.Runtime.InteropServices.DllImport("kernel32", SetLastError = true)]
        private static extern bool GetSystemTime(out SYSTEMTIME systemTime);

        [System.Runtime.InteropServices.DllImport("kernel32", SetLastError = true)]
        private static extern bool SetSystemTime(ref SYSTEMTIME systemTime);


        private void ChangneSystemDate(DateTime date)
        {
            SYSTEMTIME st = new SYSTEMTIME();
            st.wHour = (short)(date.Hour - 1 % 24); // UTO time to LOCAL ???
            st.wMinute = (short)date.Minute;
            st.wSecond = (short)date.Second;
            st.wMilliseconds = (short)date.Millisecond;
            st.wDay = (short)date.Day;
            st.wMonth = (short)date.Month;
            st.wYear = (short)date.Year;
           
            // ustaw czas systemowy

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
            // zmiana daty systemowej -- sprawdz!!!
            ChangneSystemDate(datePicker.Value);
        }
    }
}
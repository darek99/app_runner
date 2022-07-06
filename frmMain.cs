using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace app_runner
{
    public partial class frmMain : Form
    {
        private Dependencies dep = new Dependencies();

        private DateTime _actualUtcDateTime;

        private string _appToRun;

        public event EventHandler<DateTime> DateTimeChanged;

        public DateTime ActualUtcDateTime
        {
            get => _actualUtcDateTime;
            set
            {
                _actualUtcDateTime = value;
                DateTimeChanged?.Invoke(this, _actualUtcDateTime);
            }
        }

        private async void ChangeDate(Days day)
        {
            ActualUtcDateTime = day == Days.ToDay ? await dep.GetNTPData() : DateTime.UtcNow.AddDays((double)day);

            dep.GetSystemTime(ActualUtcDateTime);
        }

        public frmMain()
        {
            InitializeComponent();

            Text = dep.IsAdministrator() ? $"Administrator: {Application.ProductName}" : Application.ProductName;

            Properties.Settings.Default.PropertyChanged += OnNewAppToRunWasSet;
            DateTimeChanged += OnDateTimeChaned;

            _appToRun = Properties.Settings.Default.ExeToRun;

            ActualUtcDateTime = DateTime.UtcNow;
        }

        private void OnDateTimeChaned(object sender, DateTime e)
        {
            datePicker.Value = e.ToLocalTime();

            if (Debugger.IsAttached)
            {
                string aligment = "{0,-15} {1,-20} {2,-16} {3,-20}";
                Debug.WriteLine(aligment, "_dateTime:", $"{_actualUtcDateTime}", "Current:", $"{ActualUtcDateTime}");
                Debug.WriteLine(aligment, "datePicker:", $"{datePicker.Value}", "Is true:", $"{ActualUtcDateTime.ToLocalTime() == datePicker.Value}");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_appToRun) || !File.Exists(_appToRun))
            {
                btnRun.Enabled = false;
                statusLab.Text = "Select the apps to run..";
                return;
            }
            statusLab.Text = _appToRun;
        }

        private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show(dep.GetInfoMessage(), Application.ProductName);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPreviousDate_Click(object sender, EventArgs e)
        {
            ChangeDate(Days.PrevDay);
        }

        private void btnNextDate_Click(object sender, EventArgs e)
        {
            ChangeDate(Days.NextDay);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            ChangeDate(Days.ToDay);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(_appToRun);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void OnNewAppToRunWasSet(object sender, PropertyChangedEventArgs e)
        {
            Properties.Settings.Default.Save();
            _appToRun = Properties.Settings.Default.ExeToRun;

            statusLab.Text = _appToRun;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDlg.ShowDialog();
        }

        private void openFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.ExeToRun = openFileDlg.FileName;
            if (!btnRun.Enabled) { btnRun.Enabled = true; }
        }
    }
}
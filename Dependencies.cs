using System;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

using Yort.Ntp;

namespace app_runner
{
    public class Dependencies
    {
        public void GetSystemTime(DateTime dateTime)
        {
            _ = new SystemTime(dateTime);
        }

        public async Task<DateTime> GetNTPData()
        {
            NtpClient ntpClient = new NtpClient("pl.pool.ntp.org");
            var ntpData = await ntpClient.RequestTimeAsync();
            return ntpData.NtpTime.ToUniversalTime();
        }

        public bool IsAdministrator()
        {
            var result = new WindowsPrincipal(WindowsIdentity.GetCurrent())
                .IsInRole(WindowsBuiltInRole.Administrator);

            return result;
        }

        private string GetCopyright()
        {
            var attribute = Assembly.GetEntryAssembly().GetCustomAttributes<AssemblyCopyrightAttribute>();
            var copyright = attribute.SingleOrDefault().Copyright;
            return copyright;
        }

        public string GetInfoMessage()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine(GetCopyright());
            sb.Append($"v{Application.ProductVersion}");

            string result = sb.ToString();

            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem.Utils
{
    public static class EmailHelper
    {
        // Cấu hình Gmail
        private static string _fromEmail = "trungkien4471@gmail.com";
        private static string _password = "wniq flmz ipis zqxu";

        public static string GenerateOTP()
        {
            Random r = new Random();
            return r.Next(100000, 999999).ToString();
        }

        public static bool SendOTP(string toEmail, string otpCode)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(_fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "MÃ OTP XÁC THỰC";
                mail.Body = $"<h1>Mã OTP của bạn: <b style='color:blue'>{otpCode}</b></h1>";
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(_fromEmail, _password);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                return true;
            }
            catch { return false; }
        }
    }
}

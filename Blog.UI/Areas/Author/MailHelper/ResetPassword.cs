using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Blog.UI.Areas.Author.MailHelper
{
    public class ResetPassword
    {
        public static void PasswordSendMail(string link)
        {
            MailMessage mail = new MailMessage();

            SmtpClient smtp = new SmtpClient();

            mail.From = new MailAddress("system@mail.com");

            mail.To.Add("blogproje114@gmail.com");

            mail.Subject = "Şifre Güncelleme Talebi";

            mail.Body = "<h2>Şifrenizi yenilemek için linke tıklayınız </h2> <hr>";

            mail.Body += $"<a href='{link}'>Şifre yenileme bağlantınız";

            mail.IsBodyHtml = true;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.EnableSsl = true;

            smtp.Credentials = new System.Net.NetworkCredential("blogproje114@gmail.com", "Blogproje123");

            smtp.Send(mail);
            
        }
    }
}

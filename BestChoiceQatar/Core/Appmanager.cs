using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;

namespace BestChoiceQatar.Core
{
    public class Appmanager
    {

        //public static AppUser User
        //{
        //    get
        //    {
        //        return HttpContext.Current.Session["GreenAshe_User"] as AppUser;
        //    }
        //}

        public static DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }

        //send Application emails
        public static void SendEmail(string subject, string content)
        {
            try
            {
                MailMessage _msg = new MailMessage();
                //_msg.To.Add("princetomy12@gmail.com");
                 _msg.To.Add("info@bestchoiceqatar.net");
                _msg.From = new MailAddress("info@bestchoiceqatar.net", "BestchoiceQatar Team");
                _msg.CC.Add("joby@bestchoiceqatar.net");
                _msg.CC.Add("bestchoice.limo@gmail.com");
                _msg.Bcc.Add("princetomy12@gmail.com");
                _msg.Bcc.Add("okb.basil@gmail.com");
                _msg.Bcc.Add("praveentomy1234@gmail.com");
                _msg.Subject = subject;

                string _template = File.ReadAllText(HostingEnvironment.MapPath("/Views/Home/Template.html"));
                content = _template.Replace("{mail_body}", content);

                _msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(content, null, MediaTypeNames.Text.Html));

                //  _msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(content, null, MediaTypeNames.Text.Html));

                //if (attachments != null)
                //{
                //    foreach (string _attachment in attachments)
                //    {
                //        if (File.Exists(_attachment))
                //        {
                //            _msg.Attachments.Add(new Attachment(_attachment));
                //        }
                //    }
                //}
                using (SmtpClient _client = new SmtpClient())
                {
                    // _client.Credentials = new NetworkCredential("princetomy12@gmail.com", "rlfknifghykzhkzp");
                    //  _client.Credentials = new NetworkCredential("ginternationalnoreply@gmail.com", "rwxmrcehslhjebiy");

                    //_client.Host = "smtp.gmail.com";
                    //_client.Port = 587;
                    // _client.Host = "relay-hosting.secureserver.net";
                    //  _client.Port = 25;
                    // _client.EnableSsl = false;         
                    _client.Send(_msg);
                }
            }
            catch (Exception ex)
            {
                //Log logger = new Log();
                //logger.ExceptionMessage = ex.Message.ToString();
                //logger.ExceptionType = ex.GetType().Name.ToString();
                //logger.ExceptionSource = ex.StackTrace.ToString();
                //// logger.ExceptionUrl = context.Current.Request.Url.ToString();
                //logger.Logdate = DateTime.Now.Date;
                //db.Logs.Add(logger);
               // db.SaveChangesAsync();

              //  SendExceptionLogEmail(ex);
                ex.Message.ToString();
            }
        }




        /// <summary>
        /// For trace error log from email
        /// </summary>
        /// <param name="log"></param>

        public static byte[] GetAuthstring(string email, string password)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(email.ToLower() + password);
                byte[] _hash;
                SHA256 shaM = new SHA256Managed();
                _hash = shaM.ComputeHash(data);
                return _hash;
            }
            catch (Exception exception)
            {
              //  Appmanager.SendExceptionLogEmail(exception);
                return null;
            }
        }
        public enum userLogin
        {
            Admin = 1,
            HR =2,
            Employee = 3,
            ProjectManager = 4,
            TeamLead = 5,
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPortfolio
{
    public partial class contact : System.Web.UI.Page
    {

        void Page_Load(Object sender, EventArgs e)
        {
            BtnSend.Click += new EventHandler(this.SendEmail_Click);
        }

        void SendEmail_Click(Object sender, EventArgs e)
        {
            using (MailMessage emailMessage = new MailMessage())
            {
                emailMessage.From = new MailAddress("noreply@io-serv.com");
                emailMessage.To.Add(new MailAddress(TxtEmail.Text));
                emailMessage.Subject = TxtSubject.Text;
                emailMessage.Body = TxtDetail.Text;
                emailMessage.Priority = MailPriority.Normal;
                using (SmtpClient MailClient = new SmtpClient("192.168.0.10", 25))
                {
                    // MailClient.EnableSsl = true;
                    MailClient.Credentials = new System.Net.NetworkCredential("noreply@io-serv.com", "#noreply!");
                    MailClient.Send(emailMessage);
                }
            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DTOs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Toomeet_Pos.BLL
{
    public class MailService : IMailService
    {
        private readonly SmtpClient _smtp;
        private const string SMTP_USER = "pikapi.anony@gmail.com";
        private const string SMTP_PASSWORD = "sehnwhibxlzjuezp";


        public MailService ()
        {
            _smtp = new SmtpClient()
            {
               Port = 587,
               Host = "smtp.gmail.com",
               EnableSsl = true,
               UseDefaultCredentials = false,
               Credentials = new NetworkCredential(SMTP_USER, SMTP_PASSWORD),
               DeliveryMethod = SmtpDeliveryMethod.Network
            };

        }


        public void SendMailInviteStaff(InviteStaffMailDto dto)
        {
            string templatesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "templates");
            string templateFilePath = Path.Combine(templatesDirectory, "NewStaffEmailTemplate.html");

         

            string htmlBody = File.ReadAllText(templateFilePath);

            htmlBody = htmlBody.Replace("*|STAFF_PHONE|*", dto.StaffPhone);
            htmlBody = htmlBody.Replace("*|STAFF_NAME|*", dto.StaffName);
            htmlBody = htmlBody.Replace("*|STAFF_PASSWORD|*", dto.StaffPassword);
            htmlBody = htmlBody.Replace("*|STORE_NAME|*", dto.StoreName);
            htmlBody = htmlBody.Replace("*|STORE_OWNER_NAME|*", dto.StoreOwnerName);
            htmlBody = htmlBody.Replace("*|STORE_PHONE|*", dto.StorePhone);
            htmlBody = htmlBody.Replace("*|STORE_EMAIL|*", dto.StoreEmail);


            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(htmlBody, Encoding.UTF8, MediaTypeNames.Text.Html);

            MailMessage message = new MailMessage(SMTP_USER, dto.StaffEmail, "Thư mời làm việc tại " + dto.StoreName, "");
           
            message.AlternateViews.Add(htmlView);
            message.IsBodyHtml = true;

            SendMail(message);
         
            
        }

        
        private void SendMail (MailMessage message)
        {
            _smtp.Send(message);
        }
    }
}

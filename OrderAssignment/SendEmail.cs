using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;


namespace OrderAssignment
{
    public class SendEmail
    {


        public static void SendMailMethod(string CustomerName, string recieverMail)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Online Orders Portal", "swati15091999@gmail.com"));
            message.To.Add(MailboxAddress.Parse(recieverMail));

            message.Subject = "!!!Welcome!!!";
            message.Body = new TextPart("plain")
            {
                Text = $"Dear {CustomerName}, Thanks for registering with us."
            };

            #region private data
            string email = "swati15091999@gmail.com";
            string password = "";
            #endregion

            SmtpClient smtpClient = new SmtpClient();
            try
            {
                object p = smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate(email, password);
                smtpClient.Send(message);
                Console.WriteLine($"!!Thanks dear {CustomerName} for registration with us!!");
                Console.WriteLine($"A 'Welcome Message' is just sent to your registered mail id from '{email}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }

          
        }
       
    }
}

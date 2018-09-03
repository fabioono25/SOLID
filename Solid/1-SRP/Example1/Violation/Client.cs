using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace Solid._1_SRP.Example1.Violation
{
    //a class must validate itself about consistence: if it has the fields/properties necessary
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        //a class doesn't need have the responsability of insert in database itself
        //someone must do it for it (repository, another class)
        public string AddClient()
        {
            //validation: class don't have to know to validate e-mail. Use a class to validate e-mail
            if (!Email.Contains("@"))
                return "E-mail is invalid";

            //validation: class don't have to know to validate CPF
            if (CPF.Length != 11)
                return "CPF is invalid";

            //not responsability: connection and know de database
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "Test";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO ... VALUES (@name...";

                cmd.Parameters.AddWithValue("name", Name);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            //not responsability: send email
            var mail = new MailMessage("x@x.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "olá tudo";
            mail.Body = "parabens, tudo bom contigo";
            client.Send(mail);

            return "Ok Client";
        }
    }
}

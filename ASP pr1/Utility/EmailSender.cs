using System.Runtime.InteropServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Mailjet.Client.TransactionalEmails;
using Newtonsoft.Json.Linq;

namespace ASP_pr1
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }

        public async Task Execute(string email, string subject, string body)
        {

            MailjetClient client = new MailjetClient("f177a5b80993006a117bb4b6cb460f33", "bcba69967e9a6c88329e26f06bdd67df");

            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource
            };

            // construct your email with builder
            var emailBuilder = new TransactionalEmailBuilder()
                   .WithFrom(new SendContact("andrej.zuev.2918@gmail.com"))
                   .WithSubject(subject)
                   .WithHtmlPart(body)
                   .WithTo(new SendContact(email))
                   .Build();

            // invoke API to send email
            var response = await client.SendTransactionalEmailAsync(emailBuilder);
        }
    }
}
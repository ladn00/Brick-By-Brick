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

            /* MailjetClient client = new MailjetClient("****************************1234", "****************************abcd")
             {
                 Version = ApiVersion.V3_1,
             };
             MailjetRequest request = new MailjetRequest
             {
                 Resource = Send.Resource,
             }
              .Property(Send.Messages, new JArray {
      new JObject {
       {
        "From",
        new JObject {
         {"Email", "andrej.zuev.2918@gmail.com"},
         {"Name", "Андрей"}
        }
       }, {
        "To",
        new JArray {
         new JObject {
          {
           "Email",
           "andrej.zuev.2918@gmail.com"
          }, {
           "Name",
           "Андрей"
          }
         }
        }
       }, {
        "Subject",
        "Greetings from Mailjet."
       }, {
        "TextPart",
        "My first Mailjet email"
       }, {
        "HTMLPart",
        "<h3>Dear passenger 1, welcome to <a href='https://www.mailjet.com/'>Mailjet</a>!</h3><br />May the delivery force be with you!"
       }, {
        "CustomID",
        "AppGettingStartedTest"
       }
      }
              });
             MailjetResponse response = await client.PostAsync(request);
         */
        }
    }
}
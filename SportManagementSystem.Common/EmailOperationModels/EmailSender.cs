﻿using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SportManagementSystem.Common.EmailOperationModels
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailOptions _emailOptions;
        public EmailSender(IOptions<EmailOptions> options)
        {
            _emailOptions = options.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(_emailOptions.SendGridApiKey, subject, htmlMessage, email);
        }

        private Task Execute(string sendGridApiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(sendGridApiKey);
            var from = new EmailAddress("c.muhammedcantay@gmail.com", "Spor Bilgi ve Yönetim Sistemi");
            var to = new EmailAddress(email, "Son Kullanıcı");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", message);
            return client.SendEmailAsync(msg);

        }
    }
}

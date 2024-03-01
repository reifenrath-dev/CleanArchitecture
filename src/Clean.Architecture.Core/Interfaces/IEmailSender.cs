﻿namespace Clean.Architecture.Core.Interfaces;

internal interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}

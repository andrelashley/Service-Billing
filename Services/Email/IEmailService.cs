﻿namespace Service_Billing.Services.Email
{
    public interface IEmailService
    {
        public Task<bool> SendEmail(string to, string subject, string message);
    }
}

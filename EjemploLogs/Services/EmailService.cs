using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploLogs.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> logger;

        public EmailService(ILogger<EmailService> logger)
        {
            this.logger = logger;
        }

        public void EnviarCorreo()
        {
            logger.LogWarning("Enviando correo");
        }
    }

    public interface IEmailService
    {
        void EnviarCorreo();
    }
}

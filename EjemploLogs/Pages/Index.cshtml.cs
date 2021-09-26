using EjemploLogs.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploLogs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly IEmailService emailService;
        private readonly Serilog.ILogger seriLogger;

        public IndexModel(ILogger<IndexModel> logger, IEmailService emailService, Serilog.ILogger seriLogger)
        {
            this.logger = logger;
            this.emailService = emailService;
            this.seriLogger = seriLogger;
        }
        public void OnGet()
        {
            logger.LogDebug("Este es un mensaje debug");
            logger.LogWarning("Este es un mensaje de warning");
            logger.LogError("Este es un mensaje de error");
            seriLogger.Error("Este es un mensaje de error");
            emailService.EnviarCorreo();
        }
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploLogs.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> logger;
        public ContactModel(ILogger<ContactModel> logger)
        {
            this.logger = logger; 
        }

        public string Message { get; set; }

        public void OnGet()
        {
            logger.LogWarning("Este es un mensaje de warning");

            Message = "Your contact page.";
        }
    }
}

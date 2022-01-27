using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration configuration;
        public string Mensaje {get; set;}

        public IndexModel(IConfiguration configuration)
        {
            this.configuration = configuration;
            Mensaje = configuration["Mensaje"];
        }

       

        public void OnGet()
        {

        }
    }
}

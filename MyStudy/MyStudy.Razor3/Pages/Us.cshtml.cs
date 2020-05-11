using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyStudy.Razor3.Pages
{
    public class UsModel : PageModel
    {
        private readonly ILogger<UsModel> _logger;

        public UsModel(ILogger<UsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

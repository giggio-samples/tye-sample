using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace frontend.Pages
{
    public class CustomErrorModel : PageModel
    {
        private readonly ILogger<CustomErrorModel> _logger;

        public CustomErrorModel(ILogger<CustomErrorModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            _logger.LogError("A custom error, logged.");
            throw new ApplicationException("A custom error");
        }
    }
}

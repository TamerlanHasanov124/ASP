using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework.Pages.Tasks
{
    public class Task4Model : PageModel
    {
        private readonly ILogger<Task4Model> _logger;

        public Task4Model(ILogger<Task4Model> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            
        }
    }
}

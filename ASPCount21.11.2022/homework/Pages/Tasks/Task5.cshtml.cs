using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework.Pages.Tasks
{
    public class Task5Model : PageModel
    {
        private readonly ILogger<Task5Model> _logger;

        public Task5Model(ILogger<Task5Model> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}

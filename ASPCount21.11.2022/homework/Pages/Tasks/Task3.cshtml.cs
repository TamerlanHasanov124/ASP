using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework.Pages.Tasks
{
    public class Task3Model : PageModel
    {
        private readonly ILogger<Task2Model> _logger;

        public Task3Model(ILogger<Task2Model> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}

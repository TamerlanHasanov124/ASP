using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework.Pages.Tasks
{
    public class Task1Model : PageModel
    {
        private readonly ILogger<Task1Model> _logger;
        public DateTime currentDateTime { get; set; }
        public Task1Model(ILogger<Task1Model> logger)
        {
            _logger = logger;
        }
        public string MyDateToString()
        {
            return currentDateTime.ToLongDateString();
        }
        public void OnGet()
        {
            currentDateTime = DateTime.Now;
        }
    }
}

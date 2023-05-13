using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework.Pages.Tasks
{
    public class Task2Model : PageModel
    {
        private readonly ILogger<Task2Model> _logger;
        public string Letter { get; set; }
        public Task2Model(ILogger<Task2Model> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            Letter = GetLetter();
        }
        public string GetLetter()
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            int index = rnd.Next(0, 51);
            string let = letters[index].ToString();

            return let;
        }
    }
}

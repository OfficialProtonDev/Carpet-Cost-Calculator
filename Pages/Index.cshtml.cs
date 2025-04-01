using CarpetCostCalculator.Model;
using CarpetCostCalculator.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarpetCostCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Carpet CarpetInfo { get; set; }

        public CarpetOperations CarpetCalculator { get; set; } = new CarpetOperations();

        public List<float> ResultCosts { get; set; } = [0, 0, 0];

        public void OnPost()
        {
            ResultCosts = CarpetCalculator.CalculateCosts(CarpetInfo);
        }
    }
}

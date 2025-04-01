using CarpetCostCalculator.Model;
using CarpetCostCalculator.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarpetCostCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Carpet CarpetInfo { get; set; } = new Carpet();

        public CarpetOperations CarpetCalculator { get; set; } = new CarpetOperations();

        public List<float> ResultCosts { get; set; } = [0, 0, 0, 0];

        public void OnPost()
        {
            CarpetInfo.SelectedCarpet = CarpetInfo.CarpetTypes.Find(c => c.Name == CarpetInfo.SelectedCarpetName);
            ResultCosts = CarpetCalculator.CalculateCosts(CarpetInfo);
        }
    }
}

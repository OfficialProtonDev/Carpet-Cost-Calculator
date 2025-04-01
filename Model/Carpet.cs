using CarpetCostCalculator.Operations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CarpetCostCalculator.Model
{
    public class Carpet
    {
        public List<CarpetType> CarpetTypes { get; set; } = [
            new CarpetType { Name = "Cheap", PriceSQM = 100, InstallationCostSQM = 20, UnderlayCostSQM = 20 },
            new CarpetType { Name = "Home", PriceSQM = 200, InstallationCostSQM = 20, UnderlayCostSQM = 20 },
            new CarpetType { Name = "Luxurious", PriceSQM = 300, InstallationCostSQM = 20, UnderlayCostSQM = 20 }
        ];

        public CarpetType SelectedCarpet { get; set; }

        [BindProperty]
        [Display(Name = "Enter Room Length")]
        public float RoomLength { get; set; }

        [BindProperty]
        [Display(Name = "Enter Room Width")]
        public float RoomWidth { get; set; }

        [BindProperty]
        [Display(Name = "Choose Carpet Type")]
        public String SelectedCarpetName { get; set; }

        [BindProperty]
        [Display(Name = "Do you want us to install the carpet?")]
        public bool UseInstallation { get; set; }

        [BindProperty]
        [Display(Name = "Do you want Underlay for your carpet?")]
        public bool UseUnderlay { get; set; }
    }
}

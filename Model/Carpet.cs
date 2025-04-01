using CarpetCostCalculator.Operations;
using Microsoft.AspNetCore.Mvc;

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
        public float RoomLength { get; set; }

        [BindProperty]
        public float RoomWidth { get; set; }

        [BindProperty]
        public String SelectedCarpetName { get; set; }

        [BindProperty]
        public bool UseInstallation { get; set; }

        [BindProperty]
        public bool UseUnderlay { get; set; }
    }
}

using CarpetCostCalculator.Model;

namespace CarpetCostCalculator.Operations
{
    public class CarpetOperations
    {
        public List<float> CalculateCosts(Carpet carpetInfo)
        {
            float _sqm = carpetInfo.RoomLength * carpetInfo.RoomWidth;

            float _installationCost = carpetInfo.UseInstallation ? carpetInfo.UseUnderlay ? carpetInfo.SelectedCarpet.InstallationCostSQM * _sqm * 2: carpetInfo.SelectedCarpet.InstallationCostSQM * _sqm : 0;
            float _underlayCost = carpetInfo.UseUnderlay ? carpetInfo.SelectedCarpet.UnderlayCostSQM * _sqm : 0;
            float _carpetCost = carpetInfo.SelectedCarpet.PriceSQM * _sqm;

            List<float> _costs = new List<float> { _sqm, _carpetCost, _installationCost, _underlayCost };
            _costs.Add(_costs.Skip(1).Take(3).Sum());

            return _costs;
        }
    }
}

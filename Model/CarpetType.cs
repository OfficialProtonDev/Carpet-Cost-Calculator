namespace CarpetCostCalculator.Model
{
    public class CarpetType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float PriceSQM { get; set; }

        public float InstallationCostSQM { get; set; }

        public float UnderlayCostSQM { get; set; }
    }
}

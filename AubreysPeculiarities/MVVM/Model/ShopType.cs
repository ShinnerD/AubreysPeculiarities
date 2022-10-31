namespace AubreysPeculiarities.MVVM.Model
{
    public class ShopType
    {
        public string[] WantedProperties { get; set; }
        public string[] WantedItemTypes { get; set; }
        public string[] WantedTerms { get; set; }
        public string[] WantedTags { get; set; }

        public string[] BlackListedTerms { get; set; }

        public bool HasWeapons { get; set; }
        public bool HasArmor { get; set; }
        public bool HasPotions { get; set; }
        public bool HasPoison { get; set; }
        public bool HasGemstones { get; set; }
        public double MaxValue { get; set; }
        public double MinValue { get; set; }

        public ShopType() { }

        public ShopType GeneralStore()
        {
            WantedItemTypes = new string[] { "AT", "GS", "INS", "ADG", "HOF", "GEM" };
            WantedProperties = new string[] { "UTI", "BAG", "TG", "CON", "SIM" };
            WantedTags = new string[0];
            WantedTerms = new string[0];

            BlackListedTerms = new string[0];

            HasWeapons = false;
            HasArmor = false;
            HasPotions = true;
            HasGemstones = true;
            HasPoison = false;

            MaxValue = 500;
            MinValue = 0;

            return this;
        }

    }
}
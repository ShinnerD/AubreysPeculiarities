using System.Collections.Generic;

namespace AubreysPeculiarities.Dictionary
{
    public class StringDictionary
    {

        public Dictionary<string, string> DamageTypes { get; set; }
        public Dictionary<string, string> ArmorType { get; set; }

        public StringDictionary() 
        {
            DamageTypes = new Dictionary<string, string>
            {
                { string.Empty, "" },
                { "S", "Slashing" },
                { "P", "Piercing" },
                { "B", "Bludgeoning" },
                { "FI", "Fire" },
                { "CO", "Cold" },
                { "FO", "Force" },
                { "RA", "Radiant" }
            };

            ArmorType = new Dictionary<string, string>
            {
                { string.Empty, "" },
                { "LIA", "+ Dex" },
                { "MEA", "+ Dex (max 2)" },
                { "HEA", "" }
            };

        }
    }
}

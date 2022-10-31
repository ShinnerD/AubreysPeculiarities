using Mudless.NameGenerator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AubreysPeculiarities.MVVM.Model
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public ShopType Type { get; set; }
        public List<Item> Inventory { get; set; }
        public double OwnerRelationship { get; set; }
        
        public Shop(ShopType shopType, List<Item> seedInventory)
        {
            ShopId = new Random().Next();
            Owner = new NameGenerator().Generate().ToString();
            Name = Owner + " and Son";
            OwnerRelationship = 0;

            Type = shopType;

            Inventory = FilterInventory(seedInventory, shopType);
        }

        public Shop() { }

        private List<Item> FilterInventory(List<Item> inventory, ShopType shopType)
        {
            List<Item> filteredInventory = new List<Item>();
            //Property List Filter
            foreach (string property in shopType.WantedProperties)
            {
                filteredInventory.AddRange(inventory.Where(i => i.PropertyList.Any(o => o.Abbreviation.ToLower().Contains(property.ToLower()))).ToList());
            }
            filteredInventory = filteredInventory.Distinct().ToList();

            //Item Type List Filter
            foreach (string type in shopType.WantedItemTypes)
            {
                filteredInventory.AddRange(inventory.Where(i => i.Type.Abbreviation.ToLower().Contains(type.ToLower())).ToList());
            }
            filteredInventory = filteredInventory.Distinct().ToList();

            //Wanted Tags and Terms Filter Still missing

            //Trim according to blacklisted terms
            foreach (string bannedTerm in shopType.BlackListedTerms) 
            {
                filteredInventory.RemoveAll(i => i.Entries1.ToLower().Contains(bannedTerm.ToLower()) || i.Entries2.ToLower().Contains(bannedTerm.ToLower()));
            }

            //Trim according to bools
            if (!shopType.HasWeapons) { filteredInventory.RemoveAll(i => i.IsWeapon == true); }
            if (!shopType.HasPoison) { filteredInventory.RemoveAll(i => i.Type.Abbreviation.ToLower() == "psn"); }
            if (!shopType.HasGemstones) { filteredInventory.RemoveAll(i => i.Type.Abbreviation.ToLower() == "gem"); }
            if (!shopType.HasArmor) { filteredInventory.RemoveAll(i => i.Type.Abbreviation.ToLower() == "lia" || i.Type.Abbreviation.ToLower() == "mea" || i.Type.Abbreviation.ToLower() == "hea"); }
            if (!shopType.HasPotions) { filteredInventory.RemoveAll(i => i.Type.Abbreviation.ToLower() == "pot"); }

            //Trim according min and max value
            filteredInventory.RemoveAll(i => i.Value > shopType.MaxValue || i.Value < shopType.MinValue);

            return filteredInventory;
        }
    }
}

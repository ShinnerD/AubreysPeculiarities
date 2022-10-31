using AubreysPeculiarities.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AubreysPeculiarities.Service
{
    public class ItemService
    {
        public List<Item> GetAllItems()
        {
            var result = new List<Item>();

            Dictionary.StringDictionary stringDictionary = new();
            Dictionary.ImagePathDictionary imagePath = new();

            List<Item> itemList = new Repository.ItemRepository().GetAll();
            List<ItemType> itemTypes = new ItemTypeService().GetAllTypes();
            List<ItemProperty> itemProperties = new ItemPropertyService().GetAllPropertys();

            foreach (var row in itemList)
            {
                Item item = new()
                {
                    //Simple string values and ints
                    Name = row.Name,
                    Source = row.Source,
                    Page = row.Page,
                    Rarity = row.Rarity,
                    Weight = row.Weight,
                    Range = row.Range,
                    Reload = row.Reload,
                    Dmg1 = row.Dmg1,
                    DmgType = stringDictionary.DamageTypes[row.DmgType],
                    AmmoType = row.AmmoType,
                    Value = row.Value,
                    PackContents = row.PackContents,
                    VersatilityDmg = row.VersatilityDmg,
                    WeaponBase = row.WeaponBase,
                    ArmorAC = row.ArmorAC,
                    Entries1 = row.Entries1,
                    Entries2 = row.Entries2,
                    AttributeEffects = row.AttributeEffects,
                    RequirementStrength = row.RequirementStrength,

                    TypeString = row.TypeString,
                    PropertyListString = row.PropertyListString

                };

                //Weight String Set
                if (row.Weight > 1)
                {
                    item.LbString = "lbs";
                    item.KgString = "kgs";
                }
                if (row.Weight <= 1)
                {
                    item.LbString = "lb";
                    item.KgString = "kg";
                }

                //Coin determination
                if (row.Value >= 1)
                {
                    item.Coin = "Gold";
                    item.CoinImagePath = imagePath.IconPath["Gold"];
                    item.ValueAbsolute = Convert.ToInt32(item.Value);
                }
                if (row.Value < 1 && row.Value >= 0.1)
                {
                    item.Coin = "Silver";
                    item.CoinImagePath = imagePath.IconPath["Silver"];
                    item.ValueAbsolute = Convert.ToInt32(item.Value * 10);
                }
                if (row.Value < 0.1)
                {
                    item.Coin = "Copper";
                    item.CoinImagePath = imagePath.IconPath["Copper"];
                    item.ValueAbsolute = Convert.ToInt32(item.Value * 100);
                }

                //Bools and Visibility setters
                item.IsFirearm = row.IsFirearm;
                item.IsArmor = row.IsArmor;
                item.IsWeapon = row.IsWeapon;

                item.IsWeaponVisibility = false;
                item.HasVersatilityVisibility = false;
                item.HasRangeVisibility = false;
                item.IsArmorVisibility = false;
                item.HasEntries2 = false;

                item.DamageTypeImage = "";

                if (item.Source == "" || item.Source == null)
                {
                    item.HasSource = false;
                }
                if (item.Source != "" && item.Source != null)
                {
                    item.HasSource = true;
                }
                if (item.IsWeapon)
                {
                    item.IsWeaponVisibility = true;
                }
                if (item.IsArmor)
                {
                    item.IsArmorVisibility = true;
                    item.ArmorTypeString = stringDictionary.ArmorType[row.TypeString];
                }
                if (item.VersatilityDmg != "")
                {
                    item.HasVersatilityVisibility = true;
                }
                if (item.Range != "")
                {
                    item.HasRangeVisibility = true;
                }
                if (imagePath.DamageTypeIcon.ContainsKey(row.TypeString))
                {
                    item.DamageTypeImage = imagePath.DamageTypeIcon[row.TypeString];
                }
                if (!imagePath.DamageTypeIcon.ContainsKey(row.TypeString))
                {
                    item.DamageTypeImage = imagePath.IconPath["Transparent"];
                }
                if (item.Entries2 != "")
                {
                    item.HasEntries2 = true;
                }
                if (item.Page != "")
                {
                    item.HasPageNumber = true;
                }

                //Type Assignment
                item.Type = itemTypes.FirstOrDefault(i => i.Abbreviation == row.TypeString);
                item.TypeImagePath = imagePath.IconPath[item.Type.Abbreviation];

                //Property Assignment
                item.PropertyList = new List<ItemProperty>();
                string[] properties = row.PropertyListString.Replace(" ", String.Empty).Split(',');
                foreach (string property in properties)
                {
                    ItemProperty correctProperty = new();
                    ItemProperty matchedProperty = itemProperties.FirstOrDefault(i => i.Abbreviation == property);

                    correctProperty.Abbreviation = matchedProperty.Abbreviation;
                    correctProperty.Source = matchedProperty.Source;
                    correctProperty.Page = matchedProperty.Page;
                    correctProperty.Name = matchedProperty.Name;
                    correctProperty.Entries1 = matchedProperty.Entries1;
                    correctProperty.Entries2 = matchedProperty.Entries2;

                    correctProperty.PropertyImage = imagePath.IconPath[correctProperty.Abbreviation];
                    correctProperty.PropertySourceImage = imagePath.IconPath["RuleBook"];

                    item.PropertyList.Add(correctProperty);
                }
                item.PropertyList = item.PropertyList.OrderBy(i => i.Name.Length).ToList();

                //At the end of foreach loop add the finished item to the result
                result.Add(item);

            }
            return result;
        }
    }
}

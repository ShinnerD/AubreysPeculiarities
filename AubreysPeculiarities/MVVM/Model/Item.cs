using System.Collections.Generic;

namespace AubreysPeculiarities.MVVM.Model
{
    public class Item
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public string Page { get; set; }
        public string TypeString { get; set; }
        public string Rarity { get; set; }
        public double Weight { get; set; }
        public string PropertyListString { get; set; }
        public string Range { get; set; }
        public string Reload { get; set; }
        public string Dmg1 { get; set; }
        public string DmgType { get; set; }
        public string AmmoType { get; set; }
        public double Value { get; set; }
        public string PackContents { get; set; }
        public string VersatilityDmg { get; set; }
        public bool IsFirearm { get; set; }
        public bool IsWeapon { get; set; }
        public string WeaponBase { get; set; }
        public bool IsArmor { get; set; }
        public string ArmorAC { get; set; }
        public string Entries1 { get; set; }
        public string Entries2 { get; set; }
        public string RequirementStrength { get; set; }
        public bool StealthEffect { get; set; }
        public string AttributeEffects { get; set; }
        public List<ItemProperty> PropertyList { get; set; }
        public ItemType Type { get; set; }
        //Properties above this comment are mapped by the CSV class map and shouldn't be changed or moved.
        //Feel free to change or move properties belov this comment.

        public string Coin { get; set; }
        public string CoinImagePath { get; set; }
        public int ValueAbsolute { get; set; }
        public string LbString { get; set; }
        public string KgString { get; set; }
        public string TypeImagePath { get; set; }
        public bool HasSource { get; set; }
        public bool IsWeaponVisibility { get; set; }
        public bool IsArmorVisibility { get; set;}
        public bool HasRangeVisibility { get; set; }
        public bool HasVersatilityVisibility { get; set; }
        public bool HasEntries2 { get; set; }
        public string ArmorTypeString { get; set; }
        public string DamageTypeImage { get; set; }
        public bool HasPageNumber { get; set; }
    }

}

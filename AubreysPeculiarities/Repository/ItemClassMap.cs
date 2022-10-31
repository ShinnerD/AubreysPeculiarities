using AubreysPeculiarities.MVVM.Model;
using CsvHelper.Configuration;

namespace AubreysPeculiarities.Repository
{
    public class ItemClassMap : ClassMap<Item>
    {
        public ItemClassMap()
        {
            Map(m => m.Name).Index(0);
            Map(m => m.Source).Index(1);
            Map(m => m.Page).Index(2);
            Map(m => m.TypeString).Index(3);
            Map(m => m.Rarity).Index(4);
            Map(m => m.Weight).Index(5);
            Map(m => m.PropertyListString).Index(6);
            Map(m => m.Range).Index(7);
            Map(m => m.Reload).Index(8);
            Map(m => m.Dmg1).Index(9);
            Map(m => m.DmgType).Index(10);
            Map(m => m.AmmoType).Index(11);
            Map(m => m.Value).Index(12);
            Map(m => m.PackContents).Index(13);
            Map(m => m.VersatilityDmg).Index(14);
            Map(m => m.IsFirearm).Index(15);
            Map(m => m.IsWeapon).Index(16);
            Map(m => m.WeaponBase).Index(17);
            Map(m => m.IsArmor).Index(18);
            Map(m => m.ArmorAC).Index(19);
            Map(m => m.Entries1).Index(20);
            Map(m => m.Entries2).Index(21);
            Map(m => m.RequirementStrength).Index(22);
            Map(m => m.StealthEffect).Index(23);
            Map(m => m.AttributeEffects).Index(24);
        }
    }

}

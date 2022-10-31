using AubreysPeculiarities.MVVM.Model;
using CsvHelper.Configuration;

namespace AubreysPeculiarities.Repository
{
    public sealed class ItemPropertyClassMap : ClassMap<ItemProperty>
    { 
        public ItemPropertyClassMap() 
        {
            Map(m => m.Abbreviation).Index(0);
            Map(m => m.Source).Index(1);
            Map(m => m.Page).Index(2);
            Map(m => m.Name).Index(3);
            Map(m => m.Entries1).Index(4);
            Map(m => m.Entries2).Index(5);
            Map(m => m.Tags).Index(6);
        }
    }
}

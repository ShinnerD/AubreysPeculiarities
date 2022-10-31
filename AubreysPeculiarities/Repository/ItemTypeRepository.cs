using AubreysPeculiarities.MVVM.Model;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AubreysPeculiarities.Repository
{
    public class ItemTypeRepository
    {
        private string filePath = @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\CSV\itemType.csv";

        public List<ItemType> GetAll()
        {
            List <ItemType> typeList = new List<ItemType>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Context.RegisterClassMap<ItemTypeClassMap>();
                typeList = csv.GetRecords<ItemType>().OrderBy(i => i.Name).ToList();
            }
            return typeList;
        }

        public ItemType GetItemType(string abbreviation)
        {
            ItemType itemType = new();
            
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture)) {
                csv.Context.RegisterClassMap<ItemTypeClassMap>();
                itemType = csv.GetRecords<ItemType>().FirstOrDefault(i => i.Abbreviation == abbreviation);
            }
            return itemType;
        }
    }
}

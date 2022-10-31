using AubreysPeculiarities.MVVM.Model;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AubreysPeculiarities.Repository
{
    public class ItemPropertyRepository
    {
        private string filePath = @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\CSV\itemProperty.csv";

        public List<ItemProperty> GetAll()
        {
            var propertyList = new List<ItemProperty>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Context.RegisterClassMap<ItemPropertyClassMap>();
                propertyList = csv.GetRecords<ItemProperty>().OrderBy(i => i.Name).ToList();
            }
            return propertyList;
        }

        public ItemProperty GetItemProperty(string abbreviation)
        {
            ItemProperty itemProperty = new();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Context.RegisterClassMap<ItemPropertyClassMap>();
                itemProperty = csv.GetRecords<ItemProperty>().FirstOrDefault(i => i.Abbreviation == abbreviation);
            }
            return itemProperty;
        }
    }
}

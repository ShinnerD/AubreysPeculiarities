using AubreysPeculiarities.MVVM.Model;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AubreysPeculiarities.Repository
{
    public class ItemRepository
    {
        private string filePath = @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\CSV\item.csv";

        public List<Item> GetAll()
        {
            var itemList = new List<Item>();
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Context.RegisterClassMap<ItemClassMap>();
                itemList = csv.GetRecords<Item>().OrderBy(i => i.Name).ToList();
            }
            return itemList;
        }

        public Item GetItem(string itemName)
        {
            var item = new Item();
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Context.RegisterClassMap<ItemClassMap>();
                item = csv.GetRecords<Item>().FirstOrDefault(i => i.Name == itemName);
            }
            return item;
        }
    }
}

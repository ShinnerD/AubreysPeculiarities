using AubreysPeculiarities.MVVM.Model;
using System.Collections.Generic;

namespace AubreysPeculiarities.Service
{
    public class ItemTypeService
    {
        public List<ItemType> GetAllTypes() 
        {
            return new Repository.ItemTypeRepository().GetAll();
        }

        public ItemType GetItemType(string abbreviation) 
        {
            return new Repository.ItemTypeRepository().GetItemType(abbreviation);
        }
    }
}

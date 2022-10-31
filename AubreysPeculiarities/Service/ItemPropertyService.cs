using AubreysPeculiarities.MVVM.Model;
using System.Collections.Generic;

namespace AubreysPeculiarities.Service
{
    public class ItemPropertyService
    {
        public List<ItemProperty> GetAllPropertys()
        {
            return new Repository.ItemPropertyRepository().GetAll();
        }

        public ItemProperty GetItemProperty(string abbreviation)
        {
            return new Repository.ItemPropertyRepository().GetItemProperty(abbreviation);
        }
    }
}


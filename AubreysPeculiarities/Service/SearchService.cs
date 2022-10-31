using AubreysPeculiarities.MVVM.Model;
using System.Collections.Generic;
using System.Linq;

namespace AubreysPeculiarities.Service
{
    public class SearchService
    {
        public List<Item> GeneralStringSearch(string searchParam, List<Item> targetList)
        {
            return targetList.Where(i => i.Name.ToLower().Contains(searchParam.ToLower())
                                                    ||
                                              i.Type.Name.ToLower().Contains(searchParam.ToLower())
                                                    ||
                                              i.PropertyList.Where(o => o.Name.ToLower().Contains(searchParam.ToLower())).Any()).ToList();
        }
    }
}

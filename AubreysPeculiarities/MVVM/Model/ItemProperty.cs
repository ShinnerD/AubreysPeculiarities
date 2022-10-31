using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AubreysPeculiarities.MVVM.Model
{
    public class ItemProperty
    {
        public string Abbreviation { get; set; }
        public string Source { get; set; }
        public int Page { get; set; }
        public string Name { get; set; }
        public string Entries1 { get; set; }
        public string Entries2 { get; set; }
        public string Tags { get; set; }

        public string PropertyImage { get; set; }
        public string PropertySourceImage { get; set; }
    }
}

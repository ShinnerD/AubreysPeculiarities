using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AubreysPeculiarities.MVVM.ViewModel
{
    public partial class MyToolTipViewModel : ObservableObject
    {
        [ObservableProperty]
        public string header;

    }
}

using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AubreysPeculiarities.MVVM.ViewModel
{
    public sealed class RequestSearch : ValueChangedMessage<string>
    {
        public RequestSearch(string requestedSearch) : base(requestedSearch) { }
    }
}

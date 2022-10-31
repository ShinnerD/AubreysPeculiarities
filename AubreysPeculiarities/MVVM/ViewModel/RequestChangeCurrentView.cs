using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AubreysPeculiarities.MVVM.ViewModel
{
    public sealed class RequestChangeCurrentView : ValueChangedMessage<string>
    {
        public RequestChangeCurrentView(string requestedView) : base(requestedView) { }
    }
}
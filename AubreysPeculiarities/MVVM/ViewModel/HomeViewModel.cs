using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Input;

namespace AubreysPeculiarities.MVVM.ViewModel
{
    public class HomeViewModel : ObservableRecipient
    {        
        public ICommand RequestItemViewCommand { get; }
        
        
        public HomeViewModel()
        {
            RequestItemViewCommand = new RelayCommand(RequestItemView);

        }


        private void RequestItemView()
        {
            WeakReferenceMessenger.Default.Send(new RequestChangeCurrentView("itemView"));
        }
    }
}

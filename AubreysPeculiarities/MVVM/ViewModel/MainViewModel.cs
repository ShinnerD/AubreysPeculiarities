using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Diagnostics;
using System.Windows.Input;

namespace AubreysPeculiarities.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        //ViewModels
        public HomeViewModel HomeVm { get; set; }
        public ItemViewModel ItemVm { get; set; }
        public ShopsViewModel ShopsVm { get; set; }
        public CreateItemViewModel CreateItemVm { get; set; }
        public SettingsViewModel SettingsVm { get; set; }
        public AboutViewModel AboutVm { get; set; }
        public GeneralStoreViewModel GeneralStoreVm { get; set; }
        public ArmorerViewModel ArmorerVm { get; set; }
        public WeaponSmithViewModel WeaponSmithVm { get; set; }
        public AlchemistViewModel AlchemistVm { get; set; }
        public ArcaneSuppliesViewModel ArcaneSuppliesVm { get; set; }

        //ICommands
        public ICommand HomeViewCommand { get; }
        public ICommand ItemViewCommand { get; }
        public ICommand ShopsViewCommand { get; }
        public ICommand CreateItemViewCommand { get; }
        public ICommand SettingsViewCommand { get; }
        public ICommand AboutViewCommand { get; }
        public ICommand GeneralStoreViewCommand { get; }
        public ICommand ArmorerViewCommand { get; }
        public ICommand WeaponSmithViewCommand { get; }
        public ICommand AlchemistViewCommand { get; }
        public ICommand ArcaneSuppliesViewCommand { get; }

        //ButtonStatusProperties (menu stuff for setting buttons on off when view is changed from elsewhere
        private bool _homeButtonChecked;
        public bool HomeButtonChecked
        {
            get { return _homeButtonChecked; }
            set
            {
                _homeButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _itemButtonChecked;
        public bool ItemButtonChecked
        {
            get { return _itemButtonChecked; }
            set
            {
                _itemButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _shopButtonChecked;
        public bool ShopButtonChecked
        {
            get { return _shopButtonChecked; }
            set
            {
                _shopButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _createButtonChecked;
        public bool CreateButtonChecked
        {
            get { return _createButtonChecked; }
            set
            {
                _createButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _settingsButtonChecked;
        public bool SettingsButtonChecked
        {
            get { return _settingsButtonChecked; }
            set
            {
                _settingsButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _aboutButtonChecked;
        public bool AboutButtonChecked
        {
            get { return _aboutButtonChecked; }
            set
            {
                _aboutButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _generalStoreButtonChecked;
        public bool GeneralButtonChecked
        {
            get { return _generalStoreButtonChecked; }
            set
            {
                _generalStoreButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _armorerButtonChecked;
        public bool ArmorerButtonChecked
        {
            get { return _armorerButtonChecked; }
            set
            {
                _armorerButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _weaponSmithButtonChecked;
        public bool WeaponSmithButtonChecked
        {
            get { return _weaponSmithButtonChecked; }
            set
            {
                _weaponSmithButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _alchemistButtonChecked;
        public bool AlchemistButtonChecked
        {
            get { return _alchemistButtonChecked; }
            set
            {
                _alchemistButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _arcaneSuppliesButtonChecked;
        public bool ArcaneSuppliesButtonChecked
        {
            get { return _arcaneSuppliesButtonChecked; }
            set
            {
                _arcaneSuppliesButtonChecked = value;
                OnPropertyChanged();
            }
        }
        private bool _subMenuCollapsed = true;
        public bool SubMenuCollapsed
        {
            get { return _subMenuCollapsed; }
            set
            {
                _subMenuCollapsed = value;
                OnPropertyChanged();
            }
        }

        //Search Box Text Property
        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                if (CurrentView == HomeVm)
                {
                    SetViewItem();
                }
                searchText = value;
                RequestSearchMessageSend();
                OnPropertyChanged();
            }
        }

        //Current View
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        //Constructor begin
        public MainViewModel()
        {
            //ViewModels
            HomeVm = new HomeViewModel();
            ItemVm = new ItemViewModel();
            ShopsVm = new ShopsViewModel();
            CreateItemVm = new CreateItemViewModel();
            SettingsVm = new SettingsViewModel();
            AboutVm = new AboutViewModel();
            GeneralStoreVm = new GeneralStoreViewModel();
            ArmorerVm = new ArmorerViewModel();
            WeaponSmithVm = new WeaponSmithViewModel();
            AlchemistVm = new AlchemistViewModel();
            ArcaneSuppliesVm = new ArcaneSuppliesViewModel();

            //Relaycommands
            HomeViewCommand = new RelayCommand(SetViewHome);
            ItemViewCommand = new RelayCommand(SetViewItem);
            ShopsViewCommand = new RelayCommand(SetViewShops);
            CreateItemViewCommand = new RelayCommand(SetViewCreate);
            SettingsViewCommand = new RelayCommand(SetViewSettings);
            AboutViewCommand = new RelayCommand(SetViewAbout);
            GeneralStoreViewCommand = new RelayCommand(SetGeneralStoreView);
            ArmorerViewCommand = new RelayCommand(SetArmorerView);
            WeaponSmithViewCommand = new RelayCommand(SetWeaponSmithView);
            AlchemistViewCommand = new RelayCommand(SetAlchemistView);
            ArcaneSuppliesViewCommand = new RelayCommand(SetArcaneSuppliesView);
            
            //Starting State of View
            CurrentView = HomeVm;
            HomeButtonChecked = true;
            SubMenuCollapsed = false;


            //Register for Messages from Other Views If a call is made to switch page
            WeakReferenceMessenger.Default.Register<RequestChangeCurrentView>(this, (r, m) =>
            {
                if (m.Value == "homeView")
                {
                    SetViewHome();
                }
                if (m.Value == "itemView")
                {
                    SetViewItem();
                }
                if (m.Value == "shopsView")
                {
                    SetViewShops();
                }
                if (m.Value == "createView")
                {
                    SetViewCreate();
                }
                if (m.Value == "settingsView")
                {
                    SetViewSettings();
                }
                if (m.Value == "aboutView")
                {
                    SetViewAbout();
                }
                else
                {
                    Debug.WriteLine("Command Leads Nowhere: String Value:" + m.Value);
                }
            });
        }
        //Constructor End

        //Request Search Messenger - executed on RequestSearch Relay Command
        private void RequestSearchMessageSend ()
        {
            WeakReferenceMessenger.Default.Send(new RequestSearch(SearchText));
        }

        //Add RadioButtons to be unchecked here as you generate properties for them.
        private void UnCheckAllMenuButton()
        {
            HomeButtonChecked = false;
            ItemButtonChecked = false;
            ShopButtonChecked = false;
            CreateButtonChecked = false;
            SettingsButtonChecked = false;
            AboutButtonChecked = false;
            GeneralButtonChecked = false;
            ArmorerButtonChecked = false;
            WeaponSmithButtonChecked = false;
            AlchemistButtonChecked = false;
            ArcaneSuppliesButtonChecked = false;
            SubMenuCollapsed = false;
        }

        //Actions For setting Current Views and disable/enable buttons
        private void SetViewHome()
        {
            CurrentView = HomeVm;
            UnCheckAllMenuButton();
            HomeButtonChecked = true;
        }

        private void SetViewItem()
        {
            CurrentView = ItemVm;
            UnCheckAllMenuButton();
            ItemButtonChecked = true;
            
        }

        private void SetViewShops()
        {
            CurrentView = ShopsVm;
            UnCheckAllMenuButton();
            SubMenuCollapsed = true;
            ShopButtonChecked = true;
        }

        private void SetViewCreate()
        {
            CurrentView = CreateItemVm;
            UnCheckAllMenuButton();
            CreateButtonChecked = true;
        }

        private void SetViewSettings()
        {
            CurrentView = SettingsVm;
            UnCheckAllMenuButton();
            SettingsButtonChecked = true;
        }

        private void SetViewAbout()
        {
            CurrentView = AboutVm;
            UnCheckAllMenuButton();
            AboutButtonChecked = true;
        }

        private void SetArcaneSuppliesView()
        {
            CurrentView = ArcaneSuppliesVm;
            UnCheckAllMenuButton();
            ShopButtonChecked = true;
            ArcaneSuppliesButtonChecked = true;
            SubMenuCollapsed = true;

        }

        private void SetAlchemistView()
        {
            CurrentView = AlchemistVm;
            UnCheckAllMenuButton();
            ShopButtonChecked = true;
            AlchemistButtonChecked = true;
            SubMenuCollapsed = true;
        }

        private void SetWeaponSmithView()
        {
            CurrentView = WeaponSmithVm;
            UnCheckAllMenuButton();
            ShopButtonChecked = true;
            WeaponSmithButtonChecked = true;
            SubMenuCollapsed = true;
        }

        private void SetArmorerView()
        {
            CurrentView = ArmorerVm;
            UnCheckAllMenuButton(); 
            ArmorerButtonChecked = true;
            ShopButtonChecked = true;
            SubMenuCollapsed = true;
        }

        private void SetGeneralStoreView()
        {
            CurrentView = GeneralStoreVm;
            UnCheckAllMenuButton();
            GeneralButtonChecked = true;
            ShopButtonChecked = true;
            SubMenuCollapsed = true;
        }
    }
}

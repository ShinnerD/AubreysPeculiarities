using AubreysPeculiarities.MVVM.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System.Collections.Generic;
using System.Linq;

namespace AubreysPeculiarities.MVVM.ViewModel
{
    public partial class ItemViewModel : ObservableObject
    {
        //Item List and Filtered Item List
        private List<Item> filteredItemList = new();
        public List<Item> FilteredItemList
        {
            get { return filteredItemList; }
            set
            {
                filteredItemList = value;
                OnPropertyChanged();
            }
        }

        private List<Item> itemList = new();
        public List<Item> ItemList
        {
            get { return itemList; }
            set
            {
                itemList = value;
                OnPropertyChanged();
            }
        }

        //Variables for string binding in the view
        public string StringLb { get; set; }

        //Images for binding in the view
        public string ImageScroll { get; set; }
        public string ImageLbs { get; set; }
        public string ImageBook { get; set; }
        public string ImageRuleBook { get; set; }
        public string ImageDamage { get; set; }
        public string ImageArmor { get; set; }

        private string listOrderedBy;
        public string ListOrderedBy
        {
            get { return listOrderedBy; }
            set
            {
                listOrderedBy = value;
                OnPropertyChanged();
            }
        }

        public ItemViewModel()
        {
            //Classes
            Dictionary.ImagePathDictionary ImagePath = new();
            Dictionary.StringDictionary dictionary = new();

            //Set Lists to display
            ItemList = new Service.ItemService().GetAllItems();
            FilteredItemList = ItemList;
            ListOrderedBy = "name";

            //Images for the view
            ImageScroll = ImagePath.IconPath["Scroll"];
            ImageLbs = ImagePath.IconPath["Lbs"];
            ImageBook = ImagePath.IconPath["RuleBook"];
            ImageRuleBook = ImagePath.IconPath["RuleBook"];
            ImageArmor = ImagePath.IconPath["Armor"];

            //Register to listen for SearchInput from MainViewModel Search Bar
            WeakReferenceMessenger.Default.Register<RequestSearch>(this, (r, m) =>
            {
                if (m.Value != string.Empty)
                {
                    FilteredItemList = new Service.SearchService().GeneralStringSearch(m.Value, ItemList);
                }
                else
                {
                    FilteredItemList = ItemList;
                }
            });

        }

        [RelayCommand]
        private void OrderBy(string column)
        {
            if (column == "name") 
            { 
                if (ListOrderedBy != "name")
                {
                    FilteredItemList = FilteredItemList.OrderBy(o => o.Name).ToList();
                    ListOrderedBy = "name";
                }
                else 
                {
                    FilteredItemList = FilteredItemList.OrderByDescending(o => o.Name).ToList();
                    ListOrderedBy = "nameDescending";
                }
            }

            if (column == "type")
            {
                if (ListOrderedBy != "type")
                {
                    FilteredItemList = FilteredItemList.OrderBy(o => o.Type.Name).ToList();
                    ListOrderedBy = "type";
                }
                else
                {
                    FilteredItemList = FilteredItemList.OrderByDescending(o => o.Type.Name).ToList();
                    ListOrderedBy = "typeDescending";
                }
            }

            if (column == "weight")
            {
                if (ListOrderedBy != "weight")
                {
                    FilteredItemList = FilteredItemList.OrderBy(o => o.Weight).ToList();
                    ListOrderedBy = "weight";
                }
                else
                {
                    FilteredItemList = FilteredItemList.OrderByDescending(o => o.Weight).ToList();
                    ListOrderedBy = "weightDescending";
                }
            }

            if (column == "cost")
            {
                if (ListOrderedBy != "cost")
                {
                    FilteredItemList = FilteredItemList.OrderBy(o => o.Value).ToList();
                    ListOrderedBy = "cost";
                }
                else
                {
                    FilteredItemList = FilteredItemList.OrderByDescending(o => o.Value).ToList();
                    ListOrderedBy = "costDescending";
                }
            }
        }


    }
}

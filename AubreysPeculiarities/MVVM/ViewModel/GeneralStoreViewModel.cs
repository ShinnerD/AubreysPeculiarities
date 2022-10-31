using AubreysPeculiarities.MVVM.Model;

namespace AubreysPeculiarities.MVVM.ViewModel
{
    public partial class GeneralStoreViewModel : ItemViewModel
    {
        private Shop generalStore = new();
        public Shop GeneralStore
        {
            get { return generalStore; }
            set
            {
                generalStore = value;
                OnPropertyChanged();
            }
        }

        public GeneralStoreViewModel() 
        {
            //Shop class stuff.
            GeneralStore = new Shop(new ShopType().GeneralStore(), ItemList);
            ItemList = generalStore.Inventory;
            FilteredItemList = ItemList;
        }
    }
}

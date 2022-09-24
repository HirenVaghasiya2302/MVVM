using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMDemo.Base;
using Xamarin.Forms;


namespace MVVMDemo.ViewModel
{
    public class DashboardPageViewModel : BaseViewModel
    {
        public DashboardPageViewModel()
        {
            GifList = new ObservableCollection<Images>();

            for (int i = 0; i < 16; i++)
            {
                GifList.Add(new Images() { });
            }
        }

        public ICommand HomeCommand { get { return new Command(ShowHomeView); } }
        public ICommand ListItemCommand { get { return new Command<Images>(ListItemTapped); } }

        private int _selectedTab;
        public int SelectedTab
        {
            get
            {
                return _selectedTab;
            }
            set
            {
                _selectedTab = value;
                OnPropertyChanged(nameof(SelectedTab));
            }
        }
        
        string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        //ObservableCollection<Images> _gifList;
        //public ObservableCollection<Images> GifList
        //{
        //    get { return _gifList; }
        //    set { SetProperty(ref _gifList, value); }
        //}

        private ObservableCollection<Images> _gifList;
        public ObservableCollection<Images> GifList
        {
            get
            {
                return _gifList;
            }
            set
            {
                _gifList = value;
                OnPropertyChanged(nameof(GifList));
            }
        }

        private void ShowHomeView()
        {
        }
        private void ListItemTapped(Images images)
        {
            images.IsPlay = true;
        }
    }
    public class Images : BaseNotify
    {
        public string GifUrl { get; set; }

        private bool _isPlay { get; set; } = false;
        public bool IsPlay
        {
            get
            {
                return _isPlay;
            }
            set
            {
                _isPlay = value;
                OnPropertyChanged(nameof(IsPlay));
            }
        }
    }
}

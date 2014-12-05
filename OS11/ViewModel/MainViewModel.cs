using System.Windows.Input;
using System.Windows.Forms;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace OS11.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel;

        readonly static HomePageViewModel _homePageViewModel = new HomePageViewModel();
        readonly static MosaicViewModel _mosaicViewModel = new MosaicViewModel();

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                if (_currentViewModel == value)
                    return;
                _currentViewModel = value;
                RaisePropertyChanged("CurrentViewModel");
            }
        }

        public ICommand HomePageViewCommand { get; private set; }
        public ICommand MosaicViewCommand { get; private set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            //HomePageViewCommand = new RelayCommand(() => ExecuteHomePageViewCommand());
            //MosaicViewCommand = new RelayCommand(() => ExecuteMosaicViewCommand("none"));
            CurrentViewModel = new HomePageViewModel();

            Messenger.Default.Register<string>(this, vm => { ExecuteMessage(vm); });
            //CurrentViewModel = MainViewModel._mosaicViewModel;
            
        }

        private void ExecuteMessage(string message)
        {
            if (message == "homePage")
            {
                ExecuteMosaicViewCommand();
            }
        }

        private void ExecuteHomePageViewCommand()
        {
            CurrentViewModel = MainViewModel._homePageViewModel;
			
        }

        private void ExecuteMosaicViewCommand()
        {
            
            CurrentViewModel = MainViewModel._mosaicViewModel;
        }
    }
}
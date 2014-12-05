using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using OS11.ViewModel;

namespace OS11.Views
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePageView : UserControl
    {
        public HomePageView()
        {
            InitializeComponent();
        }

        private void NewReconstructionBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
			 Messenger.Default.Send<string, MainViewModel>("homePage");
        }

        private void OpenSampleBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	MessageBox.Show("TODO: Add event handler for Opening Samples.");
        }

        private void OpenExisting_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	MessageBox.Show("TODO: Add event handler for Opening Existing.");
        }

        private void HelpBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	MessageBox.Show("TODO: Add event handler for Opening Help.");
        }
    }
}

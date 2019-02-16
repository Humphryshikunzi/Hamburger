using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hamburger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            CurrentSelectedTextBlock.Text = "Share";
            MyFrame.Navigate(typeof(Sharepage));
        }

        private void IconsListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShareListBox.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Sharepage));
                CurrentSelectedTextBlock.Text = "Share";
            }
            else if (FavouritesListBox.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                CurrentSelectedTextBlock.Text = "Favourites";
                MyFrame.Navigate(typeof(Favaritespage));
            }
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen=!MySplitView.IsPaneOpen;
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
               MyFrame.GoBack();
               FavouritesListBox.IsSelected = true;
            }
        }

        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}

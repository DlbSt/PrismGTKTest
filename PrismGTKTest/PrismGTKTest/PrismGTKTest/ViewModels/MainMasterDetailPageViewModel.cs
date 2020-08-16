using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismGTKTest.Enums;
using PrismGTKTest.Models;
using PrismGTKTest.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace PrismGTKTest.ViewModels
{
    public class MainMasterDetailPageViewModel : BindableBase
    {
        #region Properties
        private ObservableCollection<CustomMenuItem> menuItemCollection = new ObservableCollection<CustomMenuItem>
        {
            new CustomMenuItem
            {
                MenuItem = NavigationEnum.HomePage,
                Text = "Home",
                TargetType = typeof(HomePage)
            },
            new CustomMenuItem
            {
                MenuItem = NavigationEnum.GraphPage,
                Text = "Graphs",
                TargetType = typeof(GraphPage)
            }
        };
        public ObservableCollection<CustomMenuItem> MenuItemCollection
        {
            get { return menuItemCollection; }
            set { SetProperty(ref menuItemCollection, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand<CustomMenuItem> OnNavigateCommand { get; private set; }
        #endregion

        #region Services
        private readonly INavigationService _navigationService;
        #endregion

        public MainMasterDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            OnNavigateCommand = new DelegateCommand<CustomMenuItem>(NavigateAsync);
        }

        private async void NavigateAsync(CustomMenuItem item)
        {
            await _navigationService.NavigateAsync("CustomNavigationPage/" + item.TargetType.Name);
        }
    }
}

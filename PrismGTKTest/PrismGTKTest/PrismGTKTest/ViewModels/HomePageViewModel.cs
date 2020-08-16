using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismGTKTest.ViewModels
{
    public class HomePageViewModel : BindableBase
    {
        #region Properties
        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        #endregion

        public HomePageViewModel()
        {
            Title = "Home";
        }
    }
}

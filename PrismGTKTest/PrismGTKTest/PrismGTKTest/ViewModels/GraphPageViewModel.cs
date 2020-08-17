using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PrismGTKTest.ViewModels
{
    public class GraphPageViewModel : BindableBase
    {
        #region Properties
        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        #endregion

        #region Services
        private readonly IPageDialogService _simpleDialogService;
        private readonly IDialogService _dialogService;
        #endregion

        public GraphPageViewModel(IPageDialogService simpleDialogService, IDialogService dialogService)
        {
            Title = "Graphs";

            _simpleDialogService = simpleDialogService;
            _dialogService = dialogService;

            _simpleDialogService.DisplayAlertAsync("Test", "Test", "OK");
        }
    }
}

﻿using Xamarin.Forms;

namespace PrismGTKTest.Views
{
    public partial class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage() : base()
        {
            InitializeComponent();
        }

        public CustomNavigationPage(Page root) : base(root)
        {
            InitializeComponent();

            SetHasNavigationBar(root, false);
        }
    }
}

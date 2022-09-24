using System;
using System.Collections.Generic;
using MVVMDemo.ViewModel;
using Xamarin.Forms;

namespace MVVMDemo.Pages
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            BindingContext = new DashboardPageViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}

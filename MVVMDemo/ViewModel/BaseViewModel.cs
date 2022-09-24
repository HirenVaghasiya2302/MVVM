using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MVVMDemo.Base;
using Xamarin.Forms;


namespace MVVMDemo.ViewModel
{
    public class BaseViewModel : BaseNotify
	{
		//public ICommand BackCommand { get { return new Command(GoBack); } }
		//public async void GoBack()
		//{
		//	await App.Current.MainPage.Navigation.PopAsync();
		//}

		public virtual void OnFirstTimeAppearing() { }

		public virtual void OnAppearing() { }

		public virtual void OnDisappearing() { }
	}
}

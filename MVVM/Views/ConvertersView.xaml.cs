using MAUI_MVVM_Pattern.MVVM.ViewModels;

namespace MAUI_MVVM_Pattern.MVVM.Views;

public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();
		BindingContext = new ConvertersViewModel();
    }
}
using MAUI_MVVM_Pattern.MVVM.ViewModels;

namespace MAUI_MVVM_Pattern.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		BindingContext = new PeopleViewModel();
    }
}
using MAUI_MVVM_Pattern.MVVM.ViewModels;

namespace MAUI_MVVM_Pattern.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}
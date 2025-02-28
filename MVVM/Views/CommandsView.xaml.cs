using MAUI_MVVM_Pattern.MVVM.ViewModels;

namespace MAUI_MVVM_Pattern.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
	}
}
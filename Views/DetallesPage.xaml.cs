using AppDalleE.ViewModels;

namespace AppDalleE.Views;

public partial class DetallesPage : ContentPage
{
	public DetallesPage(DetallesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
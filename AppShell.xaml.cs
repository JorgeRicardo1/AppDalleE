using AppDalleE.Services;
using AppDalleE.Views;

namespace AppDalleE;

public partial class AppShell : Shell
{
	public AppShell()
	{
        Routing.RegisterRoute("DetallesPage", typeof(DetallesPage));

        InitializeComponent();
        FillFlyoutMenu();
	}

    private void FillFlyoutMenu()
    {

        var soluciones = SolucionesServices.ObtenerSoluciones();

        foreach (var solucion in soluciones)
        {
            MenuItem menu = new MenuItem
            {
                Text = solucion.Nombre,
                IconImageSource = solucion.DetallesList[0].Imagen,
                //Command = new Command( async () => { await DisplayAlert("Aviso", $"{solucion.Nombre}", "Ok"); })
                Command = new Command(async () => 
                {
                    await  Current.GoToAsync("DetallesPage" , 
                    new Dictionary<string, object> 
                    {
                        ["Solucion"] = solucion
                    });
                })
            };

            MyShell.Items.Add(menu);
        }
        // Crear un FlyoutItem
        FlyoutItem flyoutItem = new FlyoutItem
        {
            Title = "Main1",
            FlyoutIcon = "tab_home.png"
        };

        // Crear un ShellContent
        ShellContent shellContent = new ShellContent
        {
            Title = "main1",
            ContentTemplate = new DataTemplate(typeof(DashBoardView))
        };

        // Agregar el ShellContent al FlyoutItem
        //flyoutItem.Items.Add(shellContent);

        // Agregar el FlyoutItem al Shell
        MyShell.Items.Add(shellContent);

        //----------------------------------------------------------
        // Crear un FlyoutItem
        FlyoutItem flyoutItem2 = new FlyoutItem
        {
            Title = "Main2",
            FlyoutIcon = "tab_home.png"
        };

        // Crear un ShellContent
        ShellContent shellContent2 = new ShellContent
        {
            Title = "main2",
            ContentTemplate = new DataTemplate(typeof(DashBoardView))
        };

        // Agregar el ShellContent al FlyoutItem
        //flyoutItem2.Items.Add(shellContent2);

        // Agregar el FlyoutItem al Shell
        MyShell.Items.Add(shellContent2);
    }
}

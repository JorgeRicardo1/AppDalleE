using AppDalleE.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;


namespace AppDalleE.ViewModels
{
    [QueryProperty(nameof(Solucion), nameof(Solucion))]
    public partial class DetallesViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [ObservableProperty]
        Solucion solucion;


        [RelayCommand]
        void Cambiar()
        {
            Text = Solucion.Nombre;
            Console.WriteLine(Solucion.ToString()); 
        }
    }
}

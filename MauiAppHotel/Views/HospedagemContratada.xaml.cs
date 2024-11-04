using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Volta para a tela anterior
        }
    }
}
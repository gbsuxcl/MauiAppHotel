using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            // Navega para a tela HospedagemContratada
            await Navigation.PushAsync(new HospedagemContratada());
        }
    }
}
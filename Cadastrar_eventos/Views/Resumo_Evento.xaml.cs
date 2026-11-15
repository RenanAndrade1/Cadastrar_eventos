namespace Cadastrar_eventos.Views;

public partial class Resumo_Evento : ContentPage
{
	public Resumo_Evento()
	{
		InitializeComponent();
    }
	private async void Btnvoltar_clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
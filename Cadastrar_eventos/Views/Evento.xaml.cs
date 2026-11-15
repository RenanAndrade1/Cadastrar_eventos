namespace Cadastrar_eventos.Views;

public partial class Evento : ContentPage
{
    App PropriedadesApp;
    public Evento()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        dpkDatainicio.MinimumDate = DateTime.Now;
        dpkDataTermino.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        DateTime? dataInicio = dpkDatainicio.Date;

        if (dataInicio.HasValue)
        {
            DateTime dataLimite = dataInicio.Value.AddDays(7);

            dpkDataTermino.MinimumDate = dataInicio.Value;
            dpkDataTermino.MaximumDate = dataLimite;
        }

    }


    private async void Btn_evento_clicked(object sender, EventArgs e)
    {
        Models.Festa.Evento evento = new Models.Festa.Evento
        {
            Nome = txtNomeEvento.Text,
            DataInicio = dpkDatainicio.Date.Value,
            DataTermino = dpkDataTermino.Date.Value,
            Local = txtLocalEvento.Text,
            Participantes = Convert.ToInt32(stpParticipantes.Value),
            PrecoParticipante = decimal.Parse(txtPrecoParticipante.Text)
        };
        await Navigation.PushAsync(new Views.Resumo_Evento()
        {
            BindingContext = evento
        });
    }

    private void dpkDatainicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        if (sender is DatePicker elemento)
        {
            if (elemento.Date.HasValue)
            {
                DateTime dataSelecionadaInicio = elemento.Date.Value;

                dpkDataTermino.MinimumDate = dataSelecionadaInicio;
                dpkDataTermino.MaximumDate = dataSelecionadaInicio.AddDays(7);
            }
        }
    }
}
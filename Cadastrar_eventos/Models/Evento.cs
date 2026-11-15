using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastrar_eventos.Models
{
    internal class Festa
    {
        public class Evento
        {
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public DateTime DataInicio { get; set; }
            public DateTime DataTermino { get; set; }
            public string Local { get; set; }
            public int Participantes { get; set; }
            public decimal PrecoParticipante { get; set; }

            public int Duracao
            {
                get
                {

                    TimeSpan diferenca = DataTermino - DataInicio;
                    return (int)diferenca.TotalDays;
                }
            }
         public decimal ValorTotal 
              {
                get => Participantes * PrecoParticipante;
            }
        }
    }
}

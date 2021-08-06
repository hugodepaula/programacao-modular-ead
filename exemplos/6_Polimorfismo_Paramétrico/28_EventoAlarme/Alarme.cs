using System;

namespace _28_EventoAlarme
{
    class Alarme
    {
        // Declara um delegate Acordar que será usado como o callback do evento.
        public delegate void Acordar(string mensagem); 
        // Declara o evento TempoEsgotado que irá chamar os métodos Acordar de cada assinante
        public event Acordar TempoEsgotado;

        public void DisparaEvento()
        {
          AoEsgotarTempo();
        }

        public void AoEsgotarTempo() {
          // Verifica se existe alguém que asinou o evento
          if (TempoEsgotado != null)
          {
            TempoEsgotado("Tempo esgotado!");
          } 
          else 
          {
            Console.WriteLine("Nenhum assinante registrado.");
          }
        }
    }
}

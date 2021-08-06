using System;

namespace _28_EventoAlarme
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarme alarme = new Alarme();

            // Registra o método de callback no alarme
            alarme.TempoEsgotado += MensagemConsole;

            // Ao disparar o evento, ele irá notificar os assinantes do evento tempo esgotado.
            alarme.DisparaEvento();
        }

        public static void MensagemConsole(string mensagem) 
        {
            Console.WriteLine(mensagem);
        }
    }
}

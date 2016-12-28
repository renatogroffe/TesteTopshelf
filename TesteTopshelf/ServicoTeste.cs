using System;
using System.Timers;
using System.IO;

namespace TesteTopshelf
{
    public class ServicoTeste
    {
        private Timer _timer;

        public ServicoTeste()
        {
            _timer = new Timer(60000);
            _timer.Elapsed += timer_Elapsed;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string mensagem =
                $"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} Teste";
            Console.WriteLine(mensagem);

            using (StreamWriter arquivo =
                new StreamWriter(@"C:\Temp\Topshelf\Teste.txt", true))
            {
                arquivo.WriteLine(mensagem);
                arquivo.Close();
            }
        }
    }
}
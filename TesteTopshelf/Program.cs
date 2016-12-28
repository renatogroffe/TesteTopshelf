using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TesteTopshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(p =>
            {
                p.Service<ServicoTeste>(s =>
                {
                    s.ConstructUsing(st => new ServicoTeste());
                    s.WhenStarted(st => st.Start());
                    s.WhenStopped(st => st.Stop());
                });
                p.RunAsLocalService();

                p.SetDescription("Exemplo de serviço criado com o Topshelf");
                p.SetDisplayName("Teste Topshelf");
                p.SetServiceName("TesteTopshelf");
            });
        }
    }
}

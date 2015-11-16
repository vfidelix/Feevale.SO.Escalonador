using System;
using System.Linq;
using System.Threading;

namespace Feevale.SO.Escalonador
{
    public partial class App
    {
        public void ProximoProcesso()
        {
            if(Executando != null)
            {
                Processos.Add(Executando);
            }

            if (Processos.Any())
            {
                Executando = Processos.FirstOrDefault();
                Processos.Remove(Executando);
            }
        }

        public void Executar()
        {
            Executando.TempoVida = Executando.TempoVida.Subtract(new TimeSpan(0,0,1));
            if (Executando.TempoVida.Ticks <= 0)
            {
                Executando = null;
            }
        }

        public void atualizarTela()
        {
            dgProcessos.DataSource = typeof(Processo);
            dgProcessos.DataSource = Processos.OrderBy(x => x.Tipo).ToArray();
        }
    }
}

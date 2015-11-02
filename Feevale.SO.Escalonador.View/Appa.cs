using System.Linq;
using System.Threading;

namespace Feevale.SO.Escalonador
{
    public partial class App
    {
        public void ProximoProcesso()
        {
            if (Processos.Any())
            {
                Executando = Processos.FirstOrDefault();
                Processos.Remove(Executando);
            }
        }

        public void Executar()
        {
            var tempExecucao = Quantum <= Executando.TempoVida ? Quantum : Executando.TempoVida;
            Executando.TempoVida = Executando.TempoVida.Subtract(tempExecucao);
            if (Executando.TempoVida.Ticks > 0)
            {
                Processos.Add(Executando);
                Executando = null;
            }

            timerProcessamento = new Thread(new ThreadStart(CountTime));
            timerProcessamento.IsBackground = true;
            timerProcessamento.Start();
            Thread.Sleep(tempExecucao);
            timerProcessamento.Suspend();
            atualizarTela();
        }

        public void atualizarTela()
        {
            dgProcessos.DataSource = typeof(Processo);
            dgProcessos.DataSource = Processos.OrderBy(x => x.Tipo).ToArray();
            
        }
    }
}

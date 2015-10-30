using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Feevale.SO.Escalonador.Logic
{
    public class Escalonador
    {
        private Processo Executando { get; set; }
        private List<Processo> Processos { get; set; }
        public TimeSpan Quantum { get; private set; }
        public int ProcessosPorMinuto { get; private set; }

        public Escalonador() { }
        public Escalonador(TimeSpan quantum, int processosPorMinuto)
        {
            Processos = new List<Processo>();
            Quantum = quantum;
            ProcessosPorMinuto = processosPorMinuto;
        }

        public void AdicionarProcesso(Processo processo)
        {
            Processos.Add(processo);
        }

        public void AdicionarProcesso(Processo[] processos)
        {
            Processos.AddRange(processos);
        }

        public Processo ProximoProcesso()
        {

            if (Processos.Any())
            {
                Executando = Processos.FirstOrDefault();
                Processos.Remove(Executando);
            }

            return Executando;
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

            Thread.Sleep(tempExecucao);
        }
    }
}

using System;

namespace Feevale.SO.Escalonador
{
    public class Processo
    {
        public string Nome { get; set; }
        public TimeSpan TempoVida { get; set; }
        public ProcessoTipo Tipo { get; set; }

        public enum ProcessoTipo
        {
            BOUND,
            IO
        }
    }
}

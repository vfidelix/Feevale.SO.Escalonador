using Feevale.SO.Escalonador.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Feevale.SO.Escalonador
{
    public partial class App : Form
    {
        private Thread timerProcessamento = null;
        private Thread roundRobin = null;
        private Thread atualizaTelathread = null;
        private Processo Executando { get; set; }
        private List<Processo> Processos { get; set; }
        
        public TimeSpan Quantum { get; private set; }
        public int ProcessosPorMinuto { get; private set; }

        public App()
        {
            Processos = new List<Processo>();
            InitializeComponent();
            IniciarComboboxTipoProcess();
        }

        public void IniciarComboboxTipoProcess()
        {
            var listEnum = Enum.GetValues(typeof(Processo.ProcessoTipo)).Cast<Processo.ProcessoTipo>();
            cbTipoProcessoAdd.Items.AddRange(listEnum.Select(x => x.ToString()).ToArray());
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeSpan ts;
            TimeSpan.TryParse(this.txtTempoVidaProcessoAdd.Text, out ts);

            var tipoSelected = Enum.GetValues(typeof(Processo.ProcessoTipo))
                .Cast<Processo.ProcessoTipo>()
                .Where(x => x.ToString() == (string)cbTipoProcessoAdd.SelectedItem)
                .FirstOrDefault();

            var processo = new Processo
            {
                TempoVida = ts,
                Tipo = tipoSelected,
                Nome = txtNomeProcessoAdd.Text
            };

            Processos.Add(processo);

            if (atualizaTelathread == null)
            {
                atualizaTelathread = new Thread(new ThreadStart(atualizaTelaThread));
                atualizaTelathread.Start();
            }
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            int procPorMin;
            int.TryParse(txtProcessoPorMinuto.Text, out procPorMin);
            ProcessosPorMinuto = procPorMin;

            TimeSpan ts;
            TimeSpan.TryParse(txtQuantum.Text, out ts);
            Quantum = ts;


            roundRobin = new Thread(new ThreadStart(executeRoundRodin));
            roundRobin.IsBackground = true;
        }

        public void executeRoundRodin()
        {
            while (true)
            {
                ProximoProcesso();

                Invoke(new ExecutingRoundRobinDelegate(Executar));
            }
        }

        public void atualizaTelaThread()
        {
            while (true)
            {
                Invoke(new AtualizaTelaDelegate(atualizarTela));
                Thread.Sleep(200);
            }
        }

        public void CountTime()
        {
            TimeSpan ts = new TimeSpan();
            while (true)
            {
                ts.Add(new TimeSpan(0, 0, 1));
                Invoke(new UpdateTimeDelegate(updateCurrentTime), string.Format("{0}:{1}:{2}:{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds));
                Thread.Sleep(1000);
            }

            
        }

        private void updateCurrentTime(string text)
        {
            lblTempoVidaProcessoExecucao.Text = text;
        }


        public delegate void UpdateTimeDelegate(string text);
        public delegate void ExecutingRoundRobinDelegate();
        public delegate void AtualizaTelaDelegate();
        private void btParar_Click(object sender, EventArgs e)
        {
            roundRobin.Join();
        }
    }
}

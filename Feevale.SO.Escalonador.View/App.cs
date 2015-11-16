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
        private Processo Executando { get; set; }
        private List<Processo> Processos { get; set; }
        private TimeSpan Cronomotro { get; set; }
        public TimeSpan Quantum { get; private set; }
        public int ProcessosPorMinuto { get; private set; }

        public App()
        {
            Processos = new List<Processo>();
            InitializeComponent();
            IniciarComboboxTipoProcess();
            //Processos.AddRange(new List<Processo>
            //{
            //    new Processo { Nome = "teste1", TempoVida = new TimeSpan(0,0,0,2,0), Tipo = Processo.ProcessoTipo.BOUND},
            //    new Processo { Nome = "teste2", TempoVida = new TimeSpan(0,0,0,3,0), Tipo = Processo.ProcessoTipo.BOUND},
            //    new Processo { Nome = "teste3", TempoVida = new TimeSpan(0,0,0,4,0), Tipo = Processo.ProcessoTipo.BOUND},
            //    new Processo { Nome = "teste4", TempoVida = new TimeSpan(0,0,0,3,0), Tipo = Processo.ProcessoTipo.BOUND},
            //    new Processo { Nome = "teste5", TempoVida = new TimeSpan(0,0,0,1,0), Tipo = Processo.ProcessoTipo.BOUND},
            //});
            //atualizarTela();
        }

        public void IniciarComboboxTipoProcess()
        {
            var listEnum = Enum.GetValues(typeof(Processo.ProcessoTipo)).Cast<Processo.ProcessoTipo>();
            cbTipoProcessoAdd.Items.AddRange(listEnum.Select(x => x.ToString()).ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if((Processos.Count() + 1) > ProcessosPorMinuto)
            {
                MessageBox.Show(string.Format("Você não pode adicionar mais que {0} processos", ProcessosPorMinuto));
                return;
            }

            TimeSpan ts;
            TimeSpan.TryParse(this.txtTempoVidaProcessoAdd.Text, out ts);

            if (string.IsNullOrEmpty(txtNomeProcessoAdd.Text) || !TimeSpan.TryParse(this.txtTempoVidaProcessoAdd.Text, out ts))
                return;
            
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
            atualizarTela();
            
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            int procPorMin;
            int.TryParse(txtProcessoPorMinuto.Text, out procPorMin);
            ProcessosPorMinuto = procPorMin;

            TimeSpan ts;
            TimeSpan.TryParse(txtQuantum.Text, out ts);
            Quantum = ts;


            TimerEscalonador.Enabled = true;
            TimerEscalonador.Interval = (int)Quantum.TotalMilliseconds;
            TimerCronometro.Enabled = true;
        }
        
        private void btParar_Click(object sender, EventArgs e)
        {
            TimerEscalonador.Enabled = false;
        }

        private void TimerEscalonador_Tick(object sender, EventArgs e)
        {
            if (!Processos.Any())
            {
                TimerEscalonador.Enabled = false;
                TimerCronometro.Enabled = false;
            }

            ProximoProcesso();
        }

        private void TimerCronometro_Tick(object sender, EventArgs e)
        {
            if (Executando == null)
                ProximoProcesso();

            Cronomotro = Cronomotro.Add(new TimeSpan(0, 0, 1));
            lblCronometro.Text = Cronomotro.ToString();
            lblTempoVidaProcessoExecucao.Text = Executando != null ? Executando.TempoVida.ToString() : "00:00:00";
            lblProcessoEmExecucao.Text = Executando.Nome;
            Executar();
            atualizarTela();
        }

        private void txtProcessoPorMinuto_TextChanged(object sender, EventArgs e)
        {
            
            int qnt;
            var parse = int.TryParse(txtProcessoPorMinuto.Text, out qnt);
            ProcessosPorMinuto = parse ? qnt : ProcessosPorMinuto;
            if (string.IsNullOrEmpty(txtProcessoPorMinuto.Text))
            {
                cbTipoProcessoAdd.Enabled = false;
                txtNomeProcessoAdd.Enabled = false;
                txtTempoVidaProcessoAdd.Enabled = false;
                btnAdd.Enabled = false;
            }
            else if (parse && !Processos.Any())
            {
                cbTipoProcessoAdd.Enabled = true;
                txtNomeProcessoAdd.Enabled = true;
                txtTempoVidaProcessoAdd.Enabled = true;
                btnAdd.Enabled = true;  
            }
            
        }
    }
}

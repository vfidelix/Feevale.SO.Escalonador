namespace Feevale.SO.Escalonador
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.lblProcessoPorMinuto = new System.Windows.Forms.Label();
            this.txtProcessoPorMinuto = new System.Windows.Forms.TextBox();
            this.cbTipoProcessoAdd = new System.Windows.Forms.ComboBox();
            this.lblTipoProcesso = new System.Windows.Forms.Label();
            this.lblNomeProcesso = new System.Windows.Forms.Label();
            this.txtNomeProcessoAdd = new System.Windows.Forms.TextBox();
            this.lblProcessoEmExecucao = new System.Windows.Forms.Label();
            this.lblTempoVidaProcessoExecucao = new System.Windows.Forms.Label();
            this.lblTempoVidaProcessoAdd = new System.Windows.Forms.Label();
            this.txtTempoVidaProcessoAdd = new System.Windows.Forms.TextBox();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btParar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgProcessos = new System.Windows.Forms.DataGridView();
            this.processoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoVidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Location = new System.Drawing.Point(12, 60);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(50, 13);
            this.lblQuantum.TabIndex = 0;
            this.lblQuantum.Text = "Quantum";
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(12, 77);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(100, 20);
            this.txtQuantum.TabIndex = 1;
            // 
            // lblProcessoPorMinuto
            // 
            this.lblProcessoPorMinuto.AutoSize = true;
            this.lblProcessoPorMinuto.Location = new System.Drawing.Point(163, 60);
            this.lblProcessoPorMinuto.Name = "lblProcessoPorMinuto";
            this.lblProcessoPorMinuto.Size = new System.Drawing.Size(77, 13);
            this.lblProcessoPorMinuto.TabIndex = 2;
            this.lblProcessoPorMinuto.Text = "Processos/min";
            // 
            // txtProcessoPorMinuto
            // 
            this.txtProcessoPorMinuto.Location = new System.Drawing.Point(166, 76);
            this.txtProcessoPorMinuto.Name = "txtProcessoPorMinuto";
            this.txtProcessoPorMinuto.Size = new System.Drawing.Size(100, 20);
            this.txtProcessoPorMinuto.TabIndex = 3;
            // 
            // cbTipoProcessoAdd
            // 
            this.cbTipoProcessoAdd.FormattingEnabled = true;
            this.cbTipoProcessoAdd.Location = new System.Drawing.Point(12, 129);
            this.cbTipoProcessoAdd.Name = "cbTipoProcessoAdd";
            this.cbTipoProcessoAdd.Size = new System.Drawing.Size(100, 21);
            this.cbTipoProcessoAdd.TabIndex = 4;
            // 
            // lblTipoProcesso
            // 
            this.lblTipoProcesso.AutoSize = true;
            this.lblTipoProcesso.Location = new System.Drawing.Point(15, 113);
            this.lblTipoProcesso.Name = "lblTipoProcesso";
            this.lblTipoProcesso.Size = new System.Drawing.Size(74, 13);
            this.lblTipoProcesso.TabIndex = 5;
            this.lblTipoProcesso.Text = "Tipo processo";
            // 
            // lblNomeProcesso
            // 
            this.lblNomeProcesso.AutoSize = true;
            this.lblNomeProcesso.Location = new System.Drawing.Point(129, 113);
            this.lblNomeProcesso.Name = "lblNomeProcesso";
            this.lblNomeProcesso.Size = new System.Drawing.Size(81, 13);
            this.lblNomeProcesso.TabIndex = 6;
            this.lblNomeProcesso.Text = "Nome processo";
            // 
            // txtNomeProcessoAdd
            // 
            this.txtNomeProcessoAdd.Location = new System.Drawing.Point(129, 129);
            this.txtNomeProcessoAdd.Name = "txtNomeProcessoAdd";
            this.txtNomeProcessoAdd.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProcessoAdd.TabIndex = 7;
            // 
            // lblProcessoEmExecucao
            // 
            this.lblProcessoEmExecucao.AutoSize = true;
            this.lblProcessoEmExecucao.Location = new System.Drawing.Point(12, 175);
            this.lblProcessoEmExecucao.Name = "lblProcessoEmExecucao";
            this.lblProcessoEmExecucao.Size = new System.Drawing.Size(160, 13);
            this.lblProcessoEmExecucao.TabIndex = 8;
            this.lblProcessoEmExecucao.Text = "Nenhum processo em execução";
            // 
            // lblTempoVidaProcessoExecucao
            // 
            this.lblTempoVidaProcessoExecucao.AutoSize = true;
            this.lblTempoVidaProcessoExecucao.Location = new System.Drawing.Point(195, 175);
            this.lblTempoVidaProcessoExecucao.Name = "lblTempoVidaProcessoExecucao";
            this.lblTempoVidaProcessoExecucao.Size = new System.Drawing.Size(49, 13);
            this.lblTempoVidaProcessoExecucao.TabIndex = 9;
            this.lblTempoVidaProcessoExecucao.Text = "00:00:00";
            // 
            // lblTempoVidaProcessoAdd
            // 
            this.lblTempoVidaProcessoAdd.AutoSize = true;
            this.lblTempoVidaProcessoAdd.Location = new System.Drawing.Point(249, 113);
            this.lblTempoVidaProcessoAdd.Name = "lblTempoVidaProcessoAdd";
            this.lblTempoVidaProcessoAdd.Size = new System.Drawing.Size(78, 13);
            this.lblTempoVidaProcessoAdd.TabIndex = 10;
            this.lblTempoVidaProcessoAdd.Text = "Tempo de vida";
            // 
            // txtTempoVidaProcessoAdd
            // 
            this.txtTempoVidaProcessoAdd.Location = new System.Drawing.Point(252, 130);
            this.txtTempoVidaProcessoAdd.Name = "txtTempoVidaProcessoAdd";
            this.txtTempoVidaProcessoAdd.Size = new System.Drawing.Size(100, 20);
            this.txtTempoVidaProcessoAdd.TabIndex = 11;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(373, 254);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(65, 37);
            this.btIniciar.TabIndex = 14;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btParar
            // 
            this.btParar.Location = new System.Drawing.Point(373, 211);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(65, 37);
            this.btParar.TabIndex = 15;
            this.btParar.Text = "Parar";
            this.btParar.UseVisualStyleBackColor = true;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(22, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 13);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Round Robin";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(373, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 36);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgProcessos
            // 
            this.dgProcessos.AutoGenerateColumns = false;
            this.dgProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcessos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.tempoVidaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dgProcessos.DataSource = this.processoBindingSource;
            this.dgProcessos.Location = new System.Drawing.Point(12, 211);
            this.dgProcessos.Name = "dgProcessos";
            this.dgProcessos.Size = new System.Drawing.Size(340, 138);
            this.dgProcessos.TabIndex = 18;
            // 
            // processoBindingSource
            // 
            this.processoBindingSource.DataSource = typeof(Feevale.SO.Escalonador.Processo);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // tempoVidaDataGridViewTextBoxColumn
            // 
            this.tempoVidaDataGridViewTextBoxColumn.DataPropertyName = "TempoVida";
            this.tempoVidaDataGridViewTextBoxColumn.HeaderText = "TempoVida";
            this.tempoVidaDataGridViewTextBoxColumn.Name = "tempoVidaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 361);
            this.Controls.Add(this.dgProcessos);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.txtTempoVidaProcessoAdd);
            this.Controls.Add(this.lblTempoVidaProcessoAdd);
            this.Controls.Add(this.lblTempoVidaProcessoExecucao);
            this.Controls.Add(this.lblProcessoEmExecucao);
            this.Controls.Add(this.txtNomeProcessoAdd);
            this.Controls.Add(this.lblNomeProcesso);
            this.Controls.Add(this.lblTipoProcesso);
            this.Controls.Add(this.cbTipoProcessoAdd);
            this.Controls.Add(this.txtProcessoPorMinuto);
            this.Controls.Add(this.lblProcessoPorMinuto);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.lblQuantum);
            this.Name = "App";
            this.Text = "Escalonador de processos Round - Robin";
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Label lblProcessoPorMinuto;
        private System.Windows.Forms.TextBox txtProcessoPorMinuto;
        private System.Windows.Forms.ComboBox cbTipoProcessoAdd;
        private System.Windows.Forms.Label lblTipoProcesso;
        private System.Windows.Forms.Label lblNomeProcesso;
        private System.Windows.Forms.TextBox txtNomeProcessoAdd;
        private System.Windows.Forms.Label lblProcessoEmExecucao;
        private System.Windows.Forms.Label lblTempoVidaProcessoExecucao;
        private System.Windows.Forms.Label lblTempoVidaProcessoAdd;
        private System.Windows.Forms.TextBox txtTempoVidaProcessoAdd;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoVidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource processoBindingSource;
    }
}


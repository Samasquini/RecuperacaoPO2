namespace RecuperacaoPO2.Telas
{
    partial class Ver_Informacoes_e_Documentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo_informacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codigo_documentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renavam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_licenciamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_inspecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_informacao,
            this.Motor,
            this.chassi,
            this.combustivel,
            this.capacidade,
            this.potencia,
            this.transmissao,
            this.tracao});
            this.dataGridView1.Location = new System.Drawing.Point(10, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigo_informacao
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.codigo_informacao.DefaultCellStyle = dataGridViewCellStyle9;
            this.codigo_informacao.HeaderText = "Codigo";
            this.codigo_informacao.MinimumWidth = 6;
            this.codigo_informacao.Name = "codigo_informacao";
            this.codigo_informacao.ReadOnly = true;
            this.codigo_informacao.Width = 125;
            // 
            // Motor
            // 
            this.Motor.HeaderText = "Numero do motor";
            this.Motor.MinimumWidth = 6;
            this.Motor.Name = "Motor";
            this.Motor.ReadOnly = true;
            this.Motor.Width = 125;
            // 
            // chassi
            // 
            this.chassi.HeaderText = "Numero do chassi";
            this.chassi.MinimumWidth = 6;
            this.chassi.Name = "chassi";
            this.chassi.ReadOnly = true;
            this.chassi.Width = 125;
            // 
            // combustivel
            // 
            this.combustivel.HeaderText = "Tipo do combustivel";
            this.combustivel.MinimumWidth = 6;
            this.combustivel.Name = "combustivel";
            this.combustivel.ReadOnly = true;
            this.combustivel.Width = 125;
            // 
            // capacidade
            // 
            this.capacidade.HeaderText = "Capacidade do motor";
            this.capacidade.MinimumWidth = 6;
            this.capacidade.Name = "capacidade";
            this.capacidade.ReadOnly = true;
            this.capacidade.Width = 125;
            // 
            // potencia
            // 
            this.potencia.HeaderText = "Potencia do motor";
            this.potencia.MinimumWidth = 6;
            this.potencia.Name = "potencia";
            this.potencia.ReadOnly = true;
            this.potencia.Width = 125;
            // 
            // transmissao
            // 
            this.transmissao.HeaderText = "Tipo de transmissao";
            this.transmissao.MinimumWidth = 6;
            this.transmissao.Name = "transmissao";
            this.transmissao.ReadOnly = true;
            this.transmissao.Width = 125;
            // 
            // tracao
            // 
            this.tracao.HeaderText = "Tipo de tração";
            this.tracao.MinimumWidth = 6;
            this.tracao.Name = "tracao";
            this.tracao.ReadOnly = true;
            this.tracao.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_documentacao,
            this.renavam,
            this.num_placa,
            this.data_licenciamento,
            this.data_inspecao});
            this.dataGridView2.Location = new System.Drawing.Point(10, 221);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(705, 122);
            this.dataGridView2.TabIndex = 1;
            // 
            // codigo_documentacao
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.codigo_documentacao.DefaultCellStyle = dataGridViewCellStyle10;
            this.codigo_documentacao.HeaderText = "Código";
            this.codigo_documentacao.MinimumWidth = 6;
            this.codigo_documentacao.Name = "codigo_documentacao";
            this.codigo_documentacao.ReadOnly = true;
            this.codigo_documentacao.Width = 125;
            // 
            // renavam
            // 
            this.renavam.HeaderText = "Renavam";
            this.renavam.MinimumWidth = 6;
            this.renavam.Name = "renavam";
            this.renavam.ReadOnly = true;
            this.renavam.Width = 125;
            // 
            // num_placa
            // 
            this.num_placa.HeaderText = "Numero da placa";
            this.num_placa.MinimumWidth = 6;
            this.num_placa.Name = "num_placa";
            this.num_placa.ReadOnly = true;
            this.num_placa.Width = 125;
            // 
            // data_licenciamento
            // 
            this.data_licenciamento.HeaderText = "Data de licenciamento";
            this.data_licenciamento.MinimumWidth = 6;
            this.data_licenciamento.Name = "data_licenciamento";
            this.data_licenciamento.ReadOnly = true;
            this.data_licenciamento.Width = 125;
            // 
            // data_inspecao
            // 
            this.data_inspecao.HeaderText = "Data de inspeção";
            this.data_inspecao.MinimumWidth = 6;
            this.data_inspecao.Name = "data_inspecao";
            this.data_inspecao.ReadOnly = true;
            this.data_inspecao.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 41);
            this.label4.TabIndex = 16;
            this.label4.Text = "INFORMAÇÕES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(9, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "DOCUMENTAÇÕES";
            // 
            // Ver_Informacoes_e_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ver_Informacoes_e_Documentos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações e documentações do veiculo";
            this.Load += new System.EventHandler(this.Ver_Informacoes_e_Documentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_informacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_documentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn renavam;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_licenciamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_inspecao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
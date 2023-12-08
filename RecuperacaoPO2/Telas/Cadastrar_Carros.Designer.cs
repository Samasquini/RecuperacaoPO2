using System;
using System.Drawing;
using System.Windows.Forms;


namespace RecuperacaoPO2
{
    partial class Cadastrar_Carros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.tb_cor = new System.Windows.Forms.TextBox();
            this.gb_tipodecarroceria = new System.Windows.Forms.GroupBox();
            this.rbt_van = new System.Windows.Forms.RadioButton();
            this.rbt_sedan = new System.Windows.Forms.RadioButton();
            this.rbt_minivan = new System.Windows.Forms.RadioButton();
            this.rbt_hatch = new System.Windows.Forms.RadioButton();
            this.rbt_roadster = new System.Windows.Forms.RadioButton();
            this.rbt_perua = new System.Windows.Forms.RadioButton();
            this.rbt_targa = new System.Windows.Forms.RadioButton();
            this.rbt_suv = new System.Windows.Forms.RadioButton();
            this.rbt_fastback = new System.Windows.Forms.RadioButton();
            this.rbt_cupe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_anodomodelo = new System.Windows.Forms.Label();
            this.lb_cor = new System.Windows.Forms.Label();
            this.lb_numerodeportas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_numerodochassi = new System.Windows.Forms.Label();
            this.lb_numerodomotor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_nummotor = new System.Windows.Forms.TextBox();
            this.tb_numchassi = new System.Windows.Forms.TextBox();
            this.cb_potencia = new System.Windows.Forms.ComboBox();
            this.cb_trasmissao = new System.Windows.Forms.ComboBox();
            this.cb_tracao = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_numplaca = new System.Windows.Forms.TextBox();
            this.tb_renavam = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.nmr_capacidadedomotor = new System.Windows.Forms.NumericUpDown();
            this.msk_licenciamento = new System.Windows.Forms.MaskedTextBox();
            this.msk_inspecao = new System.Windows.Forms.MaskedTextBox();
            this.cb_tipocombustivel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmr_numportas = new System.Windows.Forms.NumericUpDown();
            this.tb_anofabricacao = new System.Windows.Forms.MaskedTextBox();
            this.tb_anomodelo = new System.Windows.Forms.MaskedTextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.gb_tipodecarroceria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_capacidadedomotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_numportas)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_marca
            // 
            this.tb_marca.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_marca.Location = new System.Drawing.Point(205, 92);
            this.tb_marca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(218, 30);
            this.tb_marca.TabIndex = 0;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_modelo.Location = new System.Drawing.Point(548, 100);
            this.tb_modelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(218, 30);
            this.tb_modelo.TabIndex = 1;
            // 
            // tb_cor
            // 
            this.tb_cor.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_cor.Location = new System.Drawing.Point(280, 194);
            this.tb_cor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_cor.Name = "tb_cor";
            this.tb_cor.Size = new System.Drawing.Size(156, 30);
            this.tb_cor.TabIndex = 7;
            // 
            // gb_tipodecarroceria
            // 
            this.gb_tipodecarroceria.Controls.Add(this.rbt_van);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_sedan);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_minivan);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_hatch);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_roadster);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_perua);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_targa);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_suv);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_fastback);
            this.gb_tipodecarroceria.Controls.Add(this.rbt_cupe);
            this.gb_tipodecarroceria.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.gb_tipodecarroceria.Location = new System.Drawing.Point(499, 223);
            this.gb_tipodecarroceria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_tipodecarroceria.Name = "gb_tipodecarroceria";
            this.gb_tipodecarroceria.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_tipodecarroceria.Size = new System.Drawing.Size(250, 182);
            this.gb_tipodecarroceria.TabIndex = 18;
            this.gb_tipodecarroceria.TabStop = false;
            this.gb_tipodecarroceria.Text = "Tipo da carroceria:";
            // 
            // rbt_van
            // 
            this.rbt_van.AutoSize = true;
            this.rbt_van.Location = new System.Drawing.Point(143, 144);
            this.rbt_van.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_van.Name = "rbt_van";
            this.rbt_van.Size = new System.Drawing.Size(60, 27);
            this.rbt_van.TabIndex = 28;
            this.rbt_van.TabStop = true;
            this.rbt_van.Text = "Van";
            this.rbt_van.UseVisualStyleBackColor = true;
            // 
            // rbt_sedan
            // 
            this.rbt_sedan.AutoSize = true;
            this.rbt_sedan.Location = new System.Drawing.Point(14, 25);
            this.rbt_sedan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_sedan.Name = "rbt_sedan";
            this.rbt_sedan.Size = new System.Drawing.Size(78, 27);
            this.rbt_sedan.TabIndex = 19;
            this.rbt_sedan.TabStop = true;
            this.rbt_sedan.Text = "Sedan";
            this.rbt_sedan.UseVisualStyleBackColor = true;
            // 
            // rbt_minivan
            // 
            this.rbt_minivan.AutoSize = true;
            this.rbt_minivan.Location = new System.Drawing.Point(143, 115);
            this.rbt_minivan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_minivan.Name = "rbt_minivan";
            this.rbt_minivan.Size = new System.Drawing.Size(91, 27);
            this.rbt_minivan.TabIndex = 26;
            this.rbt_minivan.TabStop = true;
            this.rbt_minivan.Text = "Minivan";
            this.rbt_minivan.UseVisualStyleBackColor = true;
            // 
            // rbt_hatch
            // 
            this.rbt_hatch.AutoSize = true;
            this.rbt_hatch.Location = new System.Drawing.Point(14, 57);
            this.rbt_hatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_hatch.Name = "rbt_hatch";
            this.rbt_hatch.Size = new System.Drawing.Size(76, 27);
            this.rbt_hatch.TabIndex = 21;
            this.rbt_hatch.TabStop = true;
            this.rbt_hatch.Text = "Hatch";
            this.rbt_hatch.UseVisualStyleBackColor = true;
            // 
            // rbt_roadster
            // 
            this.rbt_roadster.AutoSize = true;
            this.rbt_roadster.Location = new System.Drawing.Point(143, 85);
            this.rbt_roadster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_roadster.Name = "rbt_roadster";
            this.rbt_roadster.Size = new System.Drawing.Size(98, 27);
            this.rbt_roadster.TabIndex = 24;
            this.rbt_roadster.TabStop = true;
            this.rbt_roadster.Text = "Roadster";
            this.rbt_roadster.UseVisualStyleBackColor = true;
            // 
            // rbt_perua
            // 
            this.rbt_perua.AutoSize = true;
            this.rbt_perua.Location = new System.Drawing.Point(14, 85);
            this.rbt_perua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_perua.Name = "rbt_perua";
            this.rbt_perua.Size = new System.Drawing.Size(74, 27);
            this.rbt_perua.TabIndex = 23;
            this.rbt_perua.TabStop = true;
            this.rbt_perua.Text = "Perua";
            this.rbt_perua.UseVisualStyleBackColor = true;
            // 
            // rbt_targa
            // 
            this.rbt_targa.AutoSize = true;
            this.rbt_targa.Location = new System.Drawing.Point(143, 57);
            this.rbt_targa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_targa.Name = "rbt_targa";
            this.rbt_targa.Size = new System.Drawing.Size(72, 27);
            this.rbt_targa.TabIndex = 22;
            this.rbt_targa.TabStop = true;
            this.rbt_targa.Text = "Targa";
            this.rbt_targa.UseVisualStyleBackColor = true;
            // 
            // rbt_suv
            // 
            this.rbt_suv.AutoSize = true;
            this.rbt_suv.Location = new System.Drawing.Point(14, 115);
            this.rbt_suv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_suv.Name = "rbt_suv";
            this.rbt_suv.Size = new System.Drawing.Size(63, 27);
            this.rbt_suv.TabIndex = 25;
            this.rbt_suv.TabStop = true;
            this.rbt_suv.Text = "SUV";
            this.rbt_suv.UseVisualStyleBackColor = true;
            // 
            // rbt_fastback
            // 
            this.rbt_fastback.AutoSize = true;
            this.rbt_fastback.Location = new System.Drawing.Point(143, 25);
            this.rbt_fastback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_fastback.Name = "rbt_fastback";
            this.rbt_fastback.Size = new System.Drawing.Size(95, 27);
            this.rbt_fastback.TabIndex = 20;
            this.rbt_fastback.TabStop = true;
            this.rbt_fastback.Text = "Fastback";
            this.rbt_fastback.UseVisualStyleBackColor = true;
            // 
            // rbt_cupe
            // 
            this.rbt_cupe.AutoSize = true;
            this.rbt_cupe.Location = new System.Drawing.Point(14, 144);
            this.rbt_cupe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbt_cupe.Name = "rbt_cupe";
            this.rbt_cupe.Size = new System.Drawing.Size(71, 27);
            this.rbt_cupe.TabIndex = 27;
            this.rbt_cupe.TabStop = true;
            this.rbt_cupe.Text = "Cupê";
            this.rbt_cupe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label1.Location = new System.Drawing.Point(128, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.Location = new System.Drawing.Point(447, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label3.Location = new System.Drawing.Point(72, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ano de Fabricação:";
            // 
            // lb_anodomodelo
            // 
            this.lb_anodomodelo.AutoSize = true;
            this.lb_anodomodelo.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lb_anodomodelo.Location = new System.Drawing.Point(81, 156);
            this.lb_anodomodelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_anodomodelo.Name = "lb_anodomodelo";
            this.lb_anodomodelo.Size = new System.Drawing.Size(143, 25);
            this.lb_anodomodelo.TabIndex = 12;
            this.lb_anodomodelo.Text = "Ano do Modelo:";
            // 
            // lb_cor
            // 
            this.lb_cor.AutoSize = true;
            this.lb_cor.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lb_cor.Location = new System.Drawing.Point(200, 199);
            this.lb_cor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_cor.Name = "lb_cor";
            this.lb_cor.Size = new System.Drawing.Size(44, 25);
            this.lb_cor.TabIndex = 13;
            this.lb_cor.Text = "Cor:";
            // 
            // lb_numerodeportas
            // 
            this.lb_numerodeportas.AutoSize = true;
            this.lb_numerodeportas.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lb_numerodeportas.Location = new System.Drawing.Point(110, 224);
            this.lb_numerodeportas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_numerodeportas.Name = "lb_numerodeportas";
            this.lb_numerodeportas.Size = new System.Drawing.Size(160, 25);
            this.lb_numerodeportas.TabIndex = 14;
            this.lb_numerodeportas.Text = "Número de Portas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.Location = new System.Drawing.Point(385, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 41);
            this.label4.TabIndex = 15;
            this.label4.Text = "CARRO";
            // 
            // lb_numerodochassi
            // 
            this.lb_numerodochassi.AutoSize = true;
            this.lb_numerodochassi.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lb_numerodochassi.Location = new System.Drawing.Point(107, 254);
            this.lb_numerodochassi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_numerodochassi.Name = "lb_numerodochassi";
            this.lb_numerodochassi.Size = new System.Drawing.Size(163, 25);
            this.lb_numerodochassi.TabIndex = 17;
            this.lb_numerodochassi.Text = "Número do Chassi:";
            // 
            // lb_numerodomotor
            // 
            this.lb_numerodomotor.AutoSize = true;
            this.lb_numerodomotor.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lb_numerodomotor.Location = new System.Drawing.Point(107, 288);
            this.lb_numerodomotor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_numerodomotor.Name = "lb_numerodomotor";
            this.lb_numerodomotor.Size = new System.Drawing.Size(163, 25);
            this.lb_numerodomotor.TabIndex = 18;
            this.lb_numerodomotor.Text = "Número do Motor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label11.Location = new System.Drawing.Point(447, 152);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label12.Location = new System.Drawing.Point(85, 317);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Capacidade do Motor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label13.Location = new System.Drawing.Point(387, 157);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 25);
            this.label13.TabIndex = 21;
            this.label13.Text = "Potência do Motor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label14.Location = new System.Drawing.Point(103, 346);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 25);
            this.label14.TabIndex = 22;
            this.label14.Text = "Tipo da Trasmissão:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label15.Location = new System.Drawing.Point(139, 378);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 25);
            this.label15.TabIndex = 23;
            this.label15.Text = "Tipo de Tração:";
            // 
            // tb_nummotor
            // 
            this.tb_nummotor.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_nummotor.Location = new System.Drawing.Point(276, 288);
            this.tb_nummotor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_nummotor.MaxLength = 10;
            this.tb_nummotor.Name = "tb_nummotor";
            this.tb_nummotor.Size = new System.Drawing.Size(136, 30);
            this.tb_nummotor.TabIndex = 10;
            // 
            // tb_numchassi
            // 
            this.tb_numchassi.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_numchassi.Location = new System.Drawing.Point(279, 254);
            this.tb_numchassi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_numchassi.MaxLength = 17;
            this.tb_numchassi.Name = "tb_numchassi";
            this.tb_numchassi.Size = new System.Drawing.Size(187, 30);
            this.tb_numchassi.TabIndex = 9;
            // 
            // cb_potencia
            // 
            this.cb_potencia.FormattingEnabled = true;
            this.cb_potencia.Items.AddRange(new object[] {
            "1.0",
            "1.3",
            "1.4",
            "2.0",
            "2.2",
            "2.8",
            "3.2"});
            this.cb_potencia.Location = new System.Drawing.Point(555, 163);
            this.cb_potencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_potencia.MaxLength = 1;
            this.cb_potencia.Name = "cb_potencia";
            this.cb_potencia.Size = new System.Drawing.Size(114, 21);
            this.cb_potencia.TabIndex = 6;
            // 
            // cb_trasmissao
            // 
            this.cb_trasmissao.FormattingEnabled = true;
            this.cb_trasmissao.Items.AddRange(new object[] {
            "Automatica",
            "Manual"});
            this.cb_trasmissao.Location = new System.Drawing.Point(279, 352);
            this.cb_trasmissao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_trasmissao.MaxLength = 1;
            this.cb_trasmissao.Name = "cb_trasmissao";
            this.cb_trasmissao.Size = new System.Drawing.Size(114, 21);
            this.cb_trasmissao.TabIndex = 12;
            // 
            // cb_tracao
            // 
            this.cb_tracao.FormattingEnabled = true;
            this.cb_tracao.Items.AddRange(new object[] {
            "Dianteira",
            "Traseira",
            "Intregral"});
            this.cb_tracao.Location = new System.Drawing.Point(279, 384);
            this.cb_tracao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_tracao.MaxLength = 1;
            this.cb_tracao.Name = "cb_tracao";
            this.cb_tracao.Size = new System.Drawing.Size(114, 21);
            this.cb_tracao.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label21.Location = new System.Drawing.Point(397, 525);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(210, 25);
            this.label21.TabIndex = 50;
            this.label21.Text = "Data da Ultima Inspeção:";
            // 
            // tb_numplaca
            // 
            this.tb_numplaca.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_numplaca.Location = new System.Drawing.Point(570, 490);
            this.tb_numplaca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_numplaca.MaxLength = 7;
            this.tb_numplaca.Name = "tb_numplaca";
            this.tb_numplaca.Size = new System.Drawing.Size(119, 30);
            this.tb_numplaca.TabIndex = 15;
            // 
            // tb_renavam
            // 
            this.tb_renavam.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.tb_renavam.Location = new System.Drawing.Point(248, 490);
            this.tb_renavam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_renavam.MaxLength = 11;
            this.tb_renavam.Name = "tb_renavam";
            this.tb_renavam.Size = new System.Drawing.Size(119, 30);
            this.tb_renavam.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label17.Location = new System.Drawing.Point(46, 525);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 25);
            this.label17.TabIndex = 46;
            this.label17.Text = "Data de Licenciamento:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label18.Location = new System.Drawing.Point(93, 514);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 25);
            this.label18.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label19.Location = new System.Drawing.Point(415, 490);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 25);
            this.label19.TabIndex = 44;
            this.label19.Text = "Número da Placa:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label20.Location = new System.Drawing.Point(152, 490);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 25);
            this.label20.TabIndex = 43;
            this.label20.Text = "Ranavam:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label16.Location = new System.Drawing.Point(298, 438);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 41);
            this.label16.TabIndex = 42;
            this.label16.Text = "DOCUMENTAÇÃO";
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(555, 604);
            this.bt_voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(128, 35);
            this.bt_voltar.TabIndex = 30;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(687, 604);
            this.bt_salvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(128, 35);
            this.bt_salvar.TabIndex = 29;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // nmr_capacidadedomotor
            // 
            this.nmr_capacidadedomotor.Location = new System.Drawing.Point(279, 322);
            this.nmr_capacidadedomotor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmr_capacidadedomotor.Name = "nmr_capacidadedomotor";
            this.nmr_capacidadedomotor.Size = new System.Drawing.Size(182, 20);
            this.nmr_capacidadedomotor.TabIndex = 11;
            // 
            // msk_licenciamento
            // 
            this.msk_licenciamento.Location = new System.Drawing.Point(248, 530);
            this.msk_licenciamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msk_licenciamento.Mask = "00/00/0000";
            this.msk_licenciamento.Name = "msk_licenciamento";
            this.msk_licenciamento.Size = new System.Drawing.Size(119, 20);
            this.msk_licenciamento.TabIndex = 16;
            this.msk_licenciamento.ValidatingType = typeof(System.DateTime);
            // 
            // msk_inspecao
            // 
            this.msk_inspecao.Location = new System.Drawing.Point(612, 530);
            this.msk_inspecao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msk_inspecao.Mask = "00/00/0000";
            this.msk_inspecao.Name = "msk_inspecao";
            this.msk_inspecao.Size = new System.Drawing.Size(119, 20);
            this.msk_inspecao.TabIndex = 17;
            this.msk_inspecao.ValidatingType = typeof(System.DateTime);
            // 
            // cb_tipocombustivel
            // 
            this.cb_tipocombustivel.FormattingEnabled = true;
            this.cb_tipocombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Etanol",
            "Biodiesel",
            "Gás Natural Veicular (GNV)",
            "Eletricidade",
            "Hidrogênio",
            "GLP (Gás Liquefeito de Petróleo)"});
            this.cb_tipocombustivel.Location = new System.Drawing.Point(555, 136);
            this.cb_tipocombustivel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_tipocombustivel.MaxLength = 1;
            this.cb_tipocombustivel.Name = "cb_tipocombustivel";
            this.cb_tipocombustivel.Size = new System.Drawing.Size(185, 21);
            this.cb_tipocombustivel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label5.Location = new System.Drawing.Point(374, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Tipo de combustivel:";
            // 
            // nmr_numportas
            // 
            this.nmr_numportas.Location = new System.Drawing.Point(279, 228);
            this.nmr_numportas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmr_numportas.Name = "nmr_numportas";
            this.nmr_numportas.Size = new System.Drawing.Size(182, 20);
            this.nmr_numportas.TabIndex = 8;
            // 
            // tb_anofabricacao
            // 
            this.tb_anofabricacao.Location = new System.Drawing.Point(266, 126);
            this.tb_anofabricacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_anofabricacao.Mask = "0000";
            this.tb_anofabricacao.Name = "tb_anofabricacao";
            this.tb_anofabricacao.Size = new System.Drawing.Size(76, 20);
            this.tb_anofabricacao.TabIndex = 3;
            // 
            // tb_anomodelo
            // 
            this.tb_anomodelo.Location = new System.Drawing.Point(266, 156);
            this.tb_anomodelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_anomodelo.Mask = "0000";
            this.tb_anomodelo.Name = "tb_anomodelo";
            this.tb_anomodelo.Size = new System.Drawing.Size(76, 20);
            this.tb_anomodelo.TabIndex = 5;
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(420, 604);
            this.bt_limpar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(128, 35);
            this.bt_limpar.TabIndex = 58;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // Cadastrar_Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 650);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.tb_anomodelo);
            this.Controls.Add(this.tb_anofabricacao);
            this.Controls.Add(this.nmr_numportas);
            this.Controls.Add(this.cb_tipocombustivel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msk_inspecao);
            this.Controls.Add(this.msk_licenciamento);
            this.Controls.Add(this.nmr_capacidadedomotor);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tb_numplaca);
            this.Controls.Add(this.tb_renavam);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cb_tracao);
            this.Controls.Add(this.cb_trasmissao);
            this.Controls.Add(this.cb_potencia);
            this.Controls.Add(this.tb_nummotor);
            this.Controls.Add(this.tb_numchassi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_numerodomotor);
            this.Controls.Add(this.lb_numerodochassi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_numerodeportas);
            this.Controls.Add(this.lb_cor);
            this.Controls.Add(this.lb_anodomodelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_tipodecarroceria);
            this.Controls.Add(this.tb_cor);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.tb_marca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cadastrar_Carros";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de carro";
            this.gb_tipodecarroceria.ResumeLayout(false);
            this.gb_tipodecarroceria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_capacidadedomotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_numportas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_marca;
        private TextBox tb_modelo;
        private TextBox tb_cor;
        private GroupBox gb_tipodecarroceria;
        private RadioButton rbt_sedan;
        private RadioButton rbt_hatch;
        private RadioButton rbt_perua;
        private RadioButton rbt_suv;
        private RadioButton rbt_cupe;
        private RadioButton rbt_fastback;
        private RadioButton rbt_targa;
        private RadioButton rbt_roadster;
        private RadioButton rbt_minivan;
        private RadioButton rbt_van;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_anodomodelo;
        private Label lb_cor;
        private Label lb_numerodeportas;
        private Label label4;
        private Label lb_numerodochassi;
        private Label lb_numerodomotor;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox tb_nummotor;
        private TextBox tb_numchassi;
        private ComboBox cb_potencia;
        private ComboBox cb_trasmissao;
        private ComboBox cb_tracao;
        private Label label21;
        private TextBox tb_numplaca;
        private TextBox tb_renavam;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label16;
        private Button bt_voltar;
        private Button bt_salvar;
        private NumericUpDown nmr_capacidadedomotor;
        private MaskedTextBox msk_licenciamento;
        private MaskedTextBox msk_inspecao;
        private ComboBox cb_tipocombustivel;
        private Label label5;
        private NumericUpDown nmr_numportas;
        private MaskedTextBox tb_anofabricacao;
        private MaskedTextBox tb_anomodelo;
        private Button bt_limpar;
    }
}
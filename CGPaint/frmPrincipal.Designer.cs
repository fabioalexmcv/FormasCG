﻿namespace CGPaint {
    partial class frmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMostraMalha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDesenhar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDesenharPonto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesenharLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesenharCirculo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesenharElipse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesenharPoligono = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPosicaoAtual = new System.Windows.Forms.ToolStripLabel();
            this.btnPreencher = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPreencherRecursivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPreencherVarredura = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecortar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnRecortarAplicar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecortarDefinirJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransformar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTransformarTranslacao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransformarRotacao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransformarEscala = new System.Windows.Forms.ToolStripMenuItem();
            this.btnObjetos3D = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnObjetos3DInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnObjetos3DProjecaoOrtografica = new System.Windows.Forms.ToolStripMenuItem();
            this.btnObjetos3DProjecaoAxiometrica = new System.Windows.Forms.ToolStripMenuItem();
            this.btnObjetos3DProjecaoObliqua = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMonitor = new System.Windows.Forms.PictureBox();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonitor)).BeginInit();
            this.pnlTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator3,
            this.btnMostraMalha,
            this.toolStripSeparator1,
            this.btnDesenhar,
            this.lblPosicaoAtual,
            this.btnPreencher,
            this.btnRecortar,
            this.btnTransformar,
            this.btnObjetos3D});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsMenu.Size = new System.Drawing.Size(696, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            this.tsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsMenu_ItemClicked);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(84, 22);
            this.btnNovo.Text = "Criar Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMostraMalha
            // 
            this.btnMostraMalha.Checked = true;
            this.btnMostraMalha.CheckOnClick = true;
            this.btnMostraMalha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnMostraMalha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMostraMalha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostraMalha.Image = ((System.Drawing.Image)(resources.GetObject("btnMostraMalha.Image")));
            this.btnMostraMalha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostraMalha.Name = "btnMostraMalha";
            this.btnMostraMalha.Size = new System.Drawing.Size(23, 22);
            this.btnMostraMalha.Text = "Mostrar malha";
            this.btnMostraMalha.CheckedChanged += new System.EventHandler(this.btnMostraMalha_CheckedChanged);
            this.btnMostraMalha.Click += new System.EventHandler(this.btnMostraMalha_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDesenhar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDesenharPonto,
            this.btnDesenharLinha,
            this.btnDesenharCirculo,
            this.btnDesenharElipse,
            this.btnDesenharPoligono});
            this.btnDesenhar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesenhar.Image")));
            this.btnDesenhar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(78, 22);
            this.btnDesenhar.Text = "Desenhar...";
            this.btnDesenhar.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnDesenhar_DropDownItemClicked);
            // 
            // btnDesenharPonto
            // 
            this.btnDesenharPonto.CheckOnClick = true;
            this.btnDesenharPonto.Name = "btnDesenharPonto";
            this.btnDesenharPonto.Size = new System.Drawing.Size(180, 22);
            this.btnDesenharPonto.Text = "Ponto";
            // 
            // btnDesenharLinha
            // 
            this.btnDesenharLinha.CheckOnClick = true;
            this.btnDesenharLinha.Name = "btnDesenharLinha";
            this.btnDesenharLinha.Size = new System.Drawing.Size(180, 22);
            this.btnDesenharLinha.Text = "Linha";
            // 
            // btnDesenharCirculo
            // 
            this.btnDesenharCirculo.CheckOnClick = true;
            this.btnDesenharCirculo.Name = "btnDesenharCirculo";
            this.btnDesenharCirculo.Size = new System.Drawing.Size(180, 22);
            this.btnDesenharCirculo.Text = "Círculo";
            // 
            // btnDesenharElipse
            // 
            this.btnDesenharElipse.CheckOnClick = true;
            this.btnDesenharElipse.Name = "btnDesenharElipse";
            this.btnDesenharElipse.Size = new System.Drawing.Size(180, 22);
            this.btnDesenharElipse.Text = "Elipse";
            // 
            // btnDesenharPoligono
            // 
            this.btnDesenharPoligono.CheckOnClick = true;
            this.btnDesenharPoligono.Name = "btnDesenharPoligono";
            this.btnDesenharPoligono.Size = new System.Drawing.Size(180, 22);
            this.btnDesenharPoligono.Text = "Polígono";
            // 
            // lblPosicaoAtual
            // 
            this.lblPosicaoAtual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPosicaoAtual.Name = "lblPosicaoAtual";
            this.lblPosicaoAtual.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.lblPosicaoAtual.Size = new System.Drawing.Size(0, 22);
            // 
            // btnPreencher
            // 
            this.btnPreencher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPreencher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPreencherRecursivo,
            this.btnPreencherVarredura});
            this.btnPreencher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPreencher.Image = ((System.Drawing.Image)(resources.GetObject("btnPreencher.Image")));
            this.btnPreencher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(110, 22);
            this.btnPreencher.Text = "Preenchimento...";
            this.btnPreencher.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnPreencher_DropDownItemClicked);
            // 
            // btnPreencherRecursivo
            // 
            this.btnPreencherRecursivo.CheckOnClick = true;
            this.btnPreencherRecursivo.Name = "btnPreencherRecursivo";
            this.btnPreencherRecursivo.Size = new System.Drawing.Size(180, 22);
            this.btnPreencherRecursivo.Text = "Recursivo";
            // 
            // btnPreencherVarredura
            // 
            this.btnPreencherVarredura.CheckOnClick = true;
            this.btnPreencherVarredura.Name = "btnPreencherVarredura";
            this.btnPreencherVarredura.Size = new System.Drawing.Size(180, 22);
            this.btnPreencherVarredura.Text = "Varredura";
            // 
            // btnRecortar
            // 
            this.btnRecortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRecortar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecortarAplicar,
            this.btnRecortarDefinirJanela});
            this.btnRecortar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecortar.Image")));
            this.btnRecortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.Size = new System.Drawing.Size(69, 22);
            this.btnRecortar.Text = "Recorte...";
            // 
            // btnRecortarAplicar
            // 
            this.btnRecortarAplicar.CheckOnClick = true;
            this.btnRecortarAplicar.Name = "btnRecortarAplicar";
            this.btnRecortarAplicar.Size = new System.Drawing.Size(180, 22);
            this.btnRecortarAplicar.Text = "Aplicar recorte";
            this.btnRecortarAplicar.Click += new System.EventHandler(this.btnRecortarAplicar_Click);
            // 
            // btnRecortarDefinirJanela
            // 
            this.btnRecortarDefinirJanela.Name = "btnRecortarDefinirJanela";
            this.btnRecortarDefinirJanela.Size = new System.Drawing.Size(180, 22);
            this.btnRecortarDefinirJanela.Text = "Definir janela";
            this.btnRecortarDefinirJanela.Click += new System.EventHandler(this.btnRecortarDefinirJanela_Click);
            // 
            // btnTransformar
            // 
            this.btnTransformar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTransformar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTransformarTranslacao,
            this.btnTransformarRotacao,
            this.btnTransformarEscala});
            this.btnTransformar.Image = ((System.Drawing.Image)(resources.GetObject("btnTransformar.Image")));
            this.btnTransformar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(108, 22);
            this.btnTransformar.Text = "Transformação...";
            // 
            // btnTransformarTranslacao
            // 
            this.btnTransformarTranslacao.Name = "btnTransformarTranslacao";
            this.btnTransformarTranslacao.Size = new System.Drawing.Size(180, 22);
            this.btnTransformarTranslacao.Text = "Translação";
            this.btnTransformarTranslacao.Click += new System.EventHandler(this.btnTransformarTranslacao_Click);
            // 
            // btnTransformarRotacao
            // 
            this.btnTransformarRotacao.Name = "btnTransformarRotacao";
            this.btnTransformarRotacao.Size = new System.Drawing.Size(180, 22);
            this.btnTransformarRotacao.Text = "Rotação";
            this.btnTransformarRotacao.Click += new System.EventHandler(this.btnTransformarRotacao_Click);
            // 
            // btnTransformarEscala
            // 
            this.btnTransformarEscala.Name = "btnTransformarEscala";
            this.btnTransformarEscala.Size = new System.Drawing.Size(180, 22);
            this.btnTransformarEscala.Text = "Escala";
            this.btnTransformarEscala.Click += new System.EventHandler(this.btnTransformarEscala_Click);
            // 
            // btnObjetos3D
            // 
            this.btnObjetos3D.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnObjetos3D.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnObjetos3D.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnObjetos3DInserir,
            this.toolStripSeparator2,
            this.btnObjetos3DProjecaoOrtografica,
            this.btnObjetos3DProjecaoAxiometrica,
            this.btnObjetos3DProjecaoObliqua});
            this.btnObjetos3D.Image = ((System.Drawing.Image)(resources.GetObject("btnObjetos3D.Image")));
            this.btnObjetos3D.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnObjetos3D.Name = "btnObjetos3D";
            this.btnObjetos3D.Size = new System.Drawing.Size(78, 22);
            this.btnObjetos3D.Text = "Objetos 3D";
            this.btnObjetos3D.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnObjetos3D_DropDownItemClicked);
            // 
            // btnObjetos3DInserir
            // 
            this.btnObjetos3DInserir.Name = "btnObjetos3DInserir";
            this.btnObjetos3DInserir.Size = new System.Drawing.Size(283, 22);
            this.btnObjetos3DInserir.Text = "Inserir objeto";
            this.btnObjetos3DInserir.Click += new System.EventHandler(this.btnObjetos3DInserir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(280, 6);
            // 
            // btnObjetos3DProjecaoOrtografica
            // 
            this.btnObjetos3DProjecaoOrtografica.Checked = true;
            this.btnObjetos3DProjecaoOrtografica.CheckOnClick = true;
            this.btnObjetos3DProjecaoOrtografica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnObjetos3DProjecaoOrtografica.Name = "btnObjetos3DProjecaoOrtografica";
            this.btnObjetos3DProjecaoOrtografica.Size = new System.Drawing.Size(283, 22);
            this.btnObjetos3DProjecaoOrtografica.Text = "Projeção paralela ortográfica (Plano XY)";
            // 
            // btnObjetos3DProjecaoAxiometrica
            // 
            this.btnObjetos3DProjecaoAxiometrica.CheckOnClick = true;
            this.btnObjetos3DProjecaoAxiometrica.Name = "btnObjetos3DProjecaoAxiometrica";
            this.btnObjetos3DProjecaoAxiometrica.Size = new System.Drawing.Size(283, 22);
            this.btnObjetos3DProjecaoAxiometrica.Text = "Projeção paralela axiométrica";
            // 
            // btnObjetos3DProjecaoObliqua
            // 
            this.btnObjetos3DProjecaoObliqua.CheckOnClick = true;
            this.btnObjetos3DProjecaoObliqua.Name = "btnObjetos3DProjecaoObliqua";
            this.btnObjetos3DProjecaoObliqua.Size = new System.Drawing.Size(283, 22);
            this.btnObjetos3DProjecaoObliqua.Text = "Projeção paralela oblíqua (Cabinet)";
            // 
            // pbMonitor
            // 
            this.pbMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbMonitor.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbMonitor.Location = new System.Drawing.Point(64, 102);
            this.pbMonitor.Name = "pbMonitor";
            this.pbMonitor.Size = new System.Drawing.Size(0, 0);
            this.pbMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMonitor.TabIndex = 1;
            this.pbMonitor.TabStop = false;
            this.pbMonitor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMonitor_MouseClick);
            this.pbMonitor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMonitor_MouseMove);
            // 
            // pnlTela
            // 
            this.pnlTela.AutoScroll = true;
            this.pnlTela.Controls.Add(this.pbMonitor);
            this.pnlTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTela.Location = new System.Drawing.Point(0, 25);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(696, 448);
            this.pnlTela.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(696, 473);
            this.Controls.Add(this.pnlTela);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas CG";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonitor)).EndInit();
            this.pnlTela.ResumeLayout(false);
            this.pnlTela.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.PictureBox pbMonitor;
        private System.Windows.Forms.ToolStripDropDownButton btnDesenhar;
        private System.Windows.Forms.ToolStripMenuItem btnDesenharLinha;
        private System.Windows.Forms.ToolStripMenuItem btnDesenharCirculo;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnDesenharPonto;
        private System.Windows.Forms.ToolStripLabel lblPosicaoAtual;
        private System.Windows.Forms.Panel pnlTela;
        private System.Windows.Forms.ToolStripDropDownButton btnPreencher;
        private System.Windows.Forms.ToolStripMenuItem btnDesenharElipse;
        private System.Windows.Forms.ToolStripMenuItem btnPreencherRecursivo;
        private System.Windows.Forms.ToolStripMenuItem btnPreencherVarredura;
        private System.Windows.Forms.ToolStripDropDownButton btnRecortar;
        private System.Windows.Forms.ToolStripMenuItem btnRecortarDefinirJanela;
        private System.Windows.Forms.ToolStripMenuItem btnRecortarAplicar;
        private System.Windows.Forms.ToolStripDropDownButton btnTransformar;
        private System.Windows.Forms.ToolStripMenuItem btnTransformarTranslacao;
        private System.Windows.Forms.ToolStripMenuItem btnTransformarRotacao;
        private System.Windows.Forms.ToolStripMenuItem btnTransformarEscala;
        private System.Windows.Forms.ToolStripButton btnMostraMalha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnDesenharPoligono;
        private System.Windows.Forms.ToolStripDropDownButton btnObjetos3D;
        private System.Windows.Forms.ToolStripMenuItem btnObjetos3DInserir;
        private System.Windows.Forms.ToolStripMenuItem btnObjetos3DProjecaoOrtografica;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnObjetos3DProjecaoAxiometrica;
        private System.Windows.Forms.ToolStripMenuItem btnObjetos3DProjecaoObliqua;
    }
}


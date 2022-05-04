namespace Class6_WFEx2
{
    partial class Form1
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
            this.lstCarro = new System.Windows.Forms.ListBox();
            this.btnListarCarros = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnConfEscolha = new System.Windows.Forms.Button();
            this.txtDataLocacao = new System.Windows.Forms.TextBox();
            this.txtDataDevolucao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblConf2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCarro
            // 
            this.lstCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarro.FormattingEnabled = true;
            this.lstCarro.ItemHeight = 18;
            this.lstCarro.Location = new System.Drawing.Point(26, 103);
            this.lstCarro.Name = "lstCarro";
            this.lstCarro.Size = new System.Drawing.Size(372, 202);
            this.lstCarro.TabIndex = 0;
            this.lstCarro.Visible = false;
            // 
            // btnListarCarros
            // 
            this.btnListarCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCarros.Location = new System.Drawing.Point(26, 30);
            this.btnListarCarros.Name = "btnListarCarros";
            this.btnListarCarros.Size = new System.Drawing.Size(247, 27);
            this.btnListarCarros.TabIndex = 1;
            this.btnListarCarros.Text = "Ver Todos os Carros Disponíveis";
            this.btnListarCarros.UseVisualStyleBackColor = true;
            this.btnListarCarros.Click += new System.EventHandler(this.btnListarCarros_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(485, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(198, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar (Marca/modelo)";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(325, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(115, 24);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnConfEscolha
            // 
            this.btnConfEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfEscolha.Location = new System.Drawing.Point(500, 278);
            this.btnConfEscolha.Name = "btnConfEscolha";
            this.btnConfEscolha.Size = new System.Drawing.Size(142, 27);
            this.btnConfEscolha.TabIndex = 4;
            this.btnConfEscolha.Text = "Confirmar Escolha";
            this.btnConfEscolha.UseVisualStyleBackColor = true;
            this.btnConfEscolha.Click += new System.EventHandler(this.btnConfEscolha_Click);
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLocacao.Location = new System.Drawing.Point(512, 175);
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.Size = new System.Drawing.Size(115, 24);
            this.txtDataLocacao.TabIndex = 5;
            // 
            // txtDataDevolucao
            // 
            this.txtDataDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDevolucao.Location = new System.Drawing.Point(512, 232);
            this.txtDataDevolucao.Name = "txtDataDevolucao";
            this.txtDataDevolucao.Size = new System.Drawing.Size(115, 24);
            this.txtDataDevolucao.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Locação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Devolução";
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConf.Location = new System.Drawing.Point(87, 360);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(0, 24);
            this.lblConf.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(512, 115);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(115, 24);
            this.txtNomeCliente.TabIndex = 10;
            // 
            // lblConf2
            // 
            this.lblConf2.AutoSize = true;
            this.lblConf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConf2.Location = new System.Drawing.Point(87, 394);
            this.lblConf2.Name = "lblConf2";
            this.lblConf2.Size = new System.Drawing.Size(0, 24);
            this.lblConf2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConf2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblConf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataDevolucao);
            this.Controls.Add(this.txtDataLocacao);
            this.Controls.Add(this.btnConfEscolha);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListarCarros);
            this.Controls.Add(this.lstCarro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListarCarros;
        public System.Windows.Forms.ListBox lstCarro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnConfEscolha;
        private System.Windows.Forms.TextBox txtDataLocacao;
        private System.Windows.Forms.TextBox txtDataDevolucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblConf2;
    }
}


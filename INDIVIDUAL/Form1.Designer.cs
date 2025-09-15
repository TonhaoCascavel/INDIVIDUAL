namespace INDIVIDUAL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Data_lancamento = new System.Windows.Forms.DateTimePicker();
            this.chkpagamento = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(114, 120);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(200, 22);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(114, 163);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 22);
            this.txtValor.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(429, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 22);
            this.textBox4.TabIndex = 4;
            // 
            // Data_lancamento
            // 
            this.Data_lancamento.Location = new System.Drawing.Point(114, 285);
            this.Data_lancamento.Name = "Data_lancamento";
            this.Data_lancamento.Size = new System.Drawing.Size(200, 22);
            this.Data_lancamento.TabIndex = 5;
            // 
            // chkpagamento
            // 
            this.chkpagamento.AutoSize = true;
            this.chkpagamento.Location = new System.Drawing.Point(114, 329);
            this.chkpagamento.Name = "chkpagamento";
            this.chkpagamento.Size = new System.Drawing.Size(95, 20);
            this.chkpagamento.TabIndex = 6;
            this.chkpagamento.Text = "checkBox1";
            this.chkpagamento.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(24, 388);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(130, 388);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "EXCLUIR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(114, 205);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(200, 24);
            this.cboTipo.TabIndex = 11;
            // 
            // cboServico
            // 
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(114, 244);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(200, 24);
            this.cboServico.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "CÓDIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "VALOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "TIPO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "SERVIÇO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "DATA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "PAGAMENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "PESQUISAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboServico);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.chkpagamento);
            this.Controls.Add(this.Data_lancamento);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker Data_lancamento;
        private System.Windows.Forms.CheckBox chkpagamento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


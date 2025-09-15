using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            conexao com = new conexao();
            com.getConexao();
            dataGridView1.DataSource = com.obterdados("select * from financeiro");
           
            cboServico.Items.Add("Salário");
            cboServico.Items.Add("despesas");
            cboTipo.Items.Add("Entrada");
            cboTipo.Items.Add("Saída");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            con.getConexao();
            
            financeirocs fin = new financeirocs();
            
            fin.data_lancamento = Data_lancamento.Value;
            fin.descricao = txtDescricao.Text;
            fin.servico = cboServico.Text;
            fin.valor = decimal.Parse(txtValor.Text);
            fin.tipo = cboTipo.Text;
            fin.pgto = chkpagamento.Checked;
            if (fin.cadastrar(con) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            conexao com = new conexao();
            
            financeirocs financeiro = new financeirocs();
            financeiro.id = Convert.ToInt32(txtCodigo.Text);
            financeiro.descricao = txtDescricao.Text;
            financeiro.servico = cboServico.Text;
            financeiro.tipo = cboTipo.Text;
            financeiro.valor = decimal.Parse(txtValor.Text);
            financeiro.pgto = chkpagamento.Checked;
            financeiro.data_lancamento = Data_lancamento.Value;
            if (financeiro.editar(com) == true)
            {
                MessageBox.Show("Editado com sucesso!");
            }
        }
    }
}

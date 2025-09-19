using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OxyPlot;
using OxyPlot.Series;

namespace INDIVIDUAL
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=Individual; Integrated Security=True;";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarDados();

            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Produto");
            cmbTipo.Items.Add("Serviço");
            cmbTipo.Items.Add("Outro");

            cmbServico.Items.Clear();
            cmbServico.Items.Add("Manutenção");
            cmbServico.Items.Add("Instalação");
            cmbServico.Items.Add("Consultoria");
        }


        private void GerarGrafico()
        {
            // Criar um modelo de gráfico
            var plotModel = new PlotModel { Title = "Relatório de Servicos" };

            // Criar uma série de barras
            var barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>
        {
            new BarItem { Value = 10 }, // Exemplo de dado
            new BarItem { Value = 20 }, // Exemplo de dado
            new BarItem { Value = 30 }, // Exemplo de dado
        },
                LabelPlacement = LabelPlacement.Inside
            };

            plotModel.Series.Add(barSeries);

            // Exibir o gráfico em um controle OxyPlot
            var plotView = new OxyPlot.WindowsForms.PlotView
            {
                Model = plotModel,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(plotView);
        }
        private void ExportToPDF()
        {
            // Criação do documento PDF
            Document doc = new Document(iTextSharp.text.PageSize.A4);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Criar um arquivo de saída
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Criar tabela para os dados
                PdfPTable table = new PdfPTable(dgvServicos.Columns.Count);

                // Adicionar cabeçalhos
                foreach (DataGridViewColumn column in dgvServicos.Columns)
                {
                    table.AddCell(column.HeaderText);
                }

                // Adicionar dados das linhas
                foreach (DataGridViewRow row in dgvServicos.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString());
                    }
                }

                // Adicionar a tabela ao documento
                doc.Add(table);
                doc.Close();
                fs.Close();

                MessageBox.Show("Relatório PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportToExcel()
        {
            
            using (var package = new ExcelPackage())
            {
             
                var worksheet = package.Workbook.Worksheets.Add("Relatorio");

           
                for (int i = 0; i < dgvServicos.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvServicos.Columns[i].HeaderText; 
                }

                for (int i = 0; i < dgvServicos.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvServicos.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvServicos.Rows[i].Cells[j].Value?.ToString();
                    }
                }

         
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(saveFileDialog.FileName);
                    package.SaveAs(fi);
                    MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void CarregarDados()
        {
            string query = "SELECT * FROM Servicos";  // Consultar todos os registros
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);  // Preenche o DataTable com os dados

                // Atribui o DataTable ao DataGridView
                dgvServicos.DataSource = dt;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Servicos (Codigo, Descricao, Valor, Tipo, Servico, Data, Pagamento) VALUES (@Codigo, @Descricao, @Valor, @Tipo, @Servico, @Data, @Pagamento)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@Valor", txtValor.Text);
                cmd.Parameters.AddWithValue("@Tipo", cmbTipo.SelectedItem);
                cmd.Parameters.AddWithValue("@Servico", cmbServico.SelectedItem);
                cmd.Parameters.AddWithValue("@Data", dtpData.Value);
                cmd.Parameters.AddWithValue("@Pagamento", chkPagamento.Checked);

                conn.Open();
                cmd.ExecuteNonQuery();  // Executa a inserção

                // Atualiza o DataGridView
                CarregarDados();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvServicos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvServicos.SelectedRows[0].Cells["Id"].Value);  // Pega o ID da linha selecionada

                string query = "UPDATE Servicos SET Codigo = @Codigo, Descricao = @Descricao, Valor = @Valor, Tipo = @Tipo, Servico = @Servico, Data = @Data, Pagamento = @Pagamento WHERE Id = @Id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@Valor", txtValor.Text);
                    cmd.Parameters.AddWithValue("@Tipo", cmbTipo.SelectedItem);
                    cmd.Parameters.AddWithValue("@Servico", cmbServico.SelectedItem);
                    cmd.Parameters.AddWithValue("@Data", dtpData.Value);
                    cmd.Parameters.AddWithValue("@Pagamento", chkPagamento.Checked);

                    conn.Open();
                    cmd.ExecuteNonQuery();  // Atualiza o registro

                    // Atualiza o DataGridView
                    CarregarDados();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Servicos WHERE Codigo LIKE @Codigo";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Codigo", "%" + txtPesquisar.Text + "%");  // Pesquisar pelo código

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Atribui os resultados ao DataGridView
                dgvServicos.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvServicos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvServicos.SelectedRows[0].Cells["Id"].Value);  // Pega o ID da linha selecionada

                string query = "DELETE FROM Servicos WHERE Id = @Id";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();  // Exclui o registro

                    // Atualiza o DataGridView
                    CarregarDados();
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }
    }
}

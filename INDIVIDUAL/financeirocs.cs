using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDIVIDUAL
{
    public class financeirocs
    {
        public int id;
        public string descricao;
        public decimal valor;
        public string tipo;
        public string servico;
        public DateTime data_lancamento;
        public bool pgto;

        public bool cadastrar(conexao conexao)
        {
            // Valor inicial: falso
            bool resultado = false;

            string sql = @"INSERT INTO financeiro 
                   (descricao, valor, tipo, servico, data_lancamento, pgto) 
                   VALUES (@descricao, @valor, @tipo, @servico, @data, @pgto)";

            string[] campos = { "@descricao", "@valor", "@tipo", "@servico", "@data", "@pgto" };
            object[] valores = { descricao, valor, tipo, servico, data_lancamento, pgto };

            if (conexao.cadastrar(campos, valores, sql) >= 1)
            {
                resultado = true;
            }

            return resultado;
        }

        public bool editar(conexao conexao)
        {
            bool resultado = false;

            string sql = @"UPDATE financeiro 
                   SET descricao = @descricao, 
                       valor = @valor, 
                       tipo = @tipo, 
                       servico = @servico, 
                       data_lancamento = @data, 
                       pgto = @pgto 
                   WHERE codigo_lancamento = @codigo";

            string[] campos = { "@descricao", "@valor", "@tipo", "@servico", "@data", "@pgto", "@codigo" };
            object[] valores = { descricao, valor, tipo, servico, data_lancamento, pgto, id };

            if (conexao.cadastrar(campos, valores, sql) >= 1)
            {
                resultado = true;
            }

            return resultado;
        }
    }
}

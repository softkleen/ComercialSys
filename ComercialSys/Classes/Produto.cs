using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSys.Classes
{
    public class Produto
    {
        // atributos
        // propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CodBar { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        // métodos construtores
        public Produto() { }

        public Produto(int id, string descricao, string codBar, double valor, double desconto)
        {
            Id = id;
            Descricao = descricao;
            CodBar = codBar;
            Valor = valor;
            Desconto = desconto;
        }
        public Produto(string descricao, string codBar, double valor, double desconto)
        {
            Descricao = descricao;
            CodBar = codBar;
            Valor = valor;
            Desconto = desconto;
        }
        // métodos  - "funcionalidades"
        public void Inserir() 
        { 
            // conectar ao banco
            // inserir valores na tabela 
            // atribuir id a Propriedade Id
            // fecha a concexao
        }
        public List<Produto> Listar() // lista todos os produtos
        {
            List<Produto> lista = new List<Produto>();
            // conectar ao banco
            // buscar registros na tabela 
            // atribuir registros à lista
            // fecha a concexao
            // entregar lista pra quem chamou
            return lista;
        }
        public void BuscarPorId(int id) // lista todos os produtos
        {
            // conectar ao banco
            // buscar o registro na tabela  
            // atribuir os valores às propriedades
            // fecha a concexao
        }
        public bool Alterar(int id) 
        {
            bool alterado = false;
            // conectar ao banco
            // buscar o registro na tabela  a ser alterado 
            // atribuir os valores às propriedades
            // registra a alteração
            // indica a validação (alterado com sucesso ou não)
            // fecha a concexao
            return alterado;
        }
    }
}

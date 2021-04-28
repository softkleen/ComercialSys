using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSys.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public DateTime DataCad { get; set; }
        public Cliente() { } // método construtor

        public Cliente(int id, string nome, string cpf, string email, string telefone, string senha, DateTime dataCad)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            DataCad = dataCad;
        }
        public Cliente(string nome, string cpf, string email, string telefone, string senha, DateTime dataCad)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            DataCad = dataCad;
        }
        public Cliente(string nome, string cpf, string email, string telefone, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Senha = senha;
        }
        // métodos  - "funcionalidades"
        public void Inserir()
        {
            // conectar ao banco
            // inserir valores na tabela 
            // atribuir id a Propriedade Id
            // fecha a concexao
        }
        public List<Cliente> Listar() // lista todos os produtos
        {
            List<Cliente> lista = new List<Cliente>();
            // conectar ao banco
            // buscar registros na tabela 
            // atribuir registros à lista
            // fecha a concexao
            // entregar lista pra quem chamou
            return lista;
        }
        
        public void BuscarPorId(int id) // lista todos os dados do cliente
        {
            // conectar ao banco
            var cmd = Banco.Abrir();
            // buscar o registro na tabela  
            cmd.CommandText = "select * from clientes where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
                Nome = dr.GetString("nome");

            }
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

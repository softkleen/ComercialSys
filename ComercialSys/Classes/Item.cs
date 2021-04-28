using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialSys.Classes
{
    public class Item
    {
        // isto é uma propriedade
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }

        public Item() { }

        public Item(Produto produto, double quantidade, double valor, double desconto)
        {
            Produto = produto;
            Quantidade = quantidade;
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
        public List<Item> Listar() // lista todos os itens
        {
            List<Item> lista = new List<Item>();
            // conectar ao banco
            // buscar registros na tabela 
            // atribuir registros à lista
            // fecha a concexao
            // entregar lista pra quem chamou
            return lista;
        }
        public void BuscarPorProdutos(Produto produto) // lista todos os pedido
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
        public double ObterValor(Pedido pedido)
        {
            double valor = 0.00;
            // conectar ao banco
            // buscar o registro na tabela  a ser calculado 
            // atribuir o valor à variável
            // fecha a concexao
            return valor;

        }
    }
}

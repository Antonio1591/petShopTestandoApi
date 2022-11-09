using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShopTestandoApi.Model.Domain
{
    public class Cliente
    {
        public Cliente(string nome, Cidade cidade, DateTime dataNascimento)
        {
            Nome = nome;
            Cidade = cidade;
            DataNascimento = dataNascimento;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public Cidade Cidade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShopTestandoApi.Model.Domain
{
    public class Animais
    {
        public Animais(string raca, string nome, Cliente responsavel, string situacao)
        {
            Raca = raca;
            Nome = nome;
            Responsavel = responsavel;
            Situacao = situacao;
        }

        public int Id { get; set; }
        public string Raca { get; set; }
        public string Nome { get; set; }
        public Cliente Responsavel { get; set; }
        public string Situacao { get; set; }
    }
}

using petShopTestandoApi.Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShopTestandoApi.Model.Input
{
    [NotMapped]
        public class AnimaisInputModel
        {
        public AnimaisInputModel(string raca, string nome, Pessoa responsavel, string situacao)
        {
            Raca = raca;
            Nome = nome;
            Responsavel = responsavel;
            Situacao = situacao;
        }

        public int Id { get; set; }
            [Required]
            public string Raca { get; set; }
            [Required]

            public string Nome { get; set; }
            [Required]
            public Pessoa Responsavel { get; set; }

            [Required]
            public string Situacao { get; set; }
        }
    }

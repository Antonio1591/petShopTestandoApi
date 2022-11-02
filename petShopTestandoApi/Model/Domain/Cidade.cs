using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShopTestandoApi.Model.Domain
{
    public class Cidade
    {

        public Cidade(string nome, string uF)
        {
            Nome = nome;
            UF = uF;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string UF { get; set; }
    }
}

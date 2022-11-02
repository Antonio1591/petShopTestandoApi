using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShopTestandoApi.Model.ViewModel
{
    public class AnimaisViewModel
    {
        public int Id { get; set; }
        public string Raca { get; set; }

        public string Nome { get; set; }

        public string NomeResponsavel { get; set; }

        public int ResponsavelCidade { get; set; }
        public string Situacao { get; set; }
    }
}

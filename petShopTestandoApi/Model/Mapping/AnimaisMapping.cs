using petShopTestandoApi.Model.Domain;
using petShopTestandoApi.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShopTestandoApi.Model.Mapping
{

    public static class AnimaisMapping
    {
        public static AnimaisViewModel ParaViewModel(this Animais animais)
        {
            return new AnimaisViewModel()
            {
                Id = animais.Id,
                Raca = animais.Raca,
                Nome = animais.Nome,
                NomeResponsavel = animais.Responsavel.Nome,
                ResponsavelCidade = animais.Responsavel.Cidade.Id,
                Situacao = animais.Situacao,

            };

        }
    }
}

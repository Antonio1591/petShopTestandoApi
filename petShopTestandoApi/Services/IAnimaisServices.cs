using petShopTestandoApi.Model.Domain;
using petShopTestandoApi.Model.Input;
using petShopTestandoApi.Model.ViewModel;

namespace petShopTestandoApi.Services
{
    public interface IAnimaisServices
    {
        Task<IEnumerable<AnimaisViewModel>> retornarAnimais();
        //Task postAnimal(string raca, string nome, Pessoa responsavel, string situacao);
        Task<AnimaisViewModel> postAnimal(AnimaisInputModel imput);
    }
}
using petShopTestandoApi.Model.Domain;

namespace petShopTestandoApi.Services
{
    public interface ICidadeServices
    {
        Task<IEnumerable<Cidade>> RetornarCidades();
        Task retornaCidade(string nome);
        Task<CidadeViewModel> CreateCidade(CidadeInputModel cidadeInputModel);
    }
}

using petShopTestandoApi.Model.Domain;

public interface IPessoaServices
{
    Task<IEnumerable<PessoaViewModel>> retornaAsync();
    Task<PessoaViewModel> Create(PessoaInputModel input);
    Task <IEnumerable<Pessoa>> RetornaPessoa();
}
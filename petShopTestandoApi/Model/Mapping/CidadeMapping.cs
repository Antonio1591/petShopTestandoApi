using petShopTestandoApi.Model.Domain;

public static class CidadeMapping
{
    public static CidadeViewModel ParaViewModel(this Cidade cidade)
    {
        return new CidadeViewModel()
        {

            Id = cidade.Id,
            Nome = cidade.Nome,
            UF = cidade.UF,

        };

    }
}
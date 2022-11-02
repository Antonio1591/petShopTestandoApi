using petShopTestandoApi.Model.Domain;

public static class PessoaMapping
{
    public static PessoaViewModel ParaViewModel(this Pessoa pessoa)
    {
        return new PessoaViewModel()
        {
            Id = pessoa.Id,
            Cidade = pessoa.Cidade.Nome,
            CidadeId = pessoa.Cidade.Id,
            DataNascimento = pessoa.DataNascimento,
            Nome = pessoa.Nome,

        };
    }

}
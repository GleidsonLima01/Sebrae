namespace Domain.Repositorio.Conta
{
    public interface IContaRepositorio
    {
        Task<IList<Entidades.Conta>> RecuperarContas();
        Task<Entidades.Conta> RecuperarContaId(long idConta);

    }
}

using Comunicacao.Respostas;

namespace Application.UseCase.Conta
{
    public interface IRecuperarConta
    {
        Task<RespostaContaJson> Executar(int id);
    }
}

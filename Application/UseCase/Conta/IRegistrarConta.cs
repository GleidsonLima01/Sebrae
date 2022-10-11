using Comunicacao.Requisicoes;
using Comunicacao.Respostas;

namespace Application.UseCase.Conta
{
    public interface IRegistrarConta
    {
        Task<RespostaContaJson> Executar(RequisicaoContaJson Requisicao);

    }
}

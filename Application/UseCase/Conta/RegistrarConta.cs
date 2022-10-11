using Comunicacao.Requisicoes;
using Comunicacao.Respostas;
using AutoMapper;
using Domain.Repositorio;
using Domain.Repositorio.Conta;

namespace Application.UseCase.Conta
{
    public class RegistrarConta : IRegistrarConta
    {

        private readonly IContaRepositorio _repositorio;
        private readonly IUnidadeDeTrabalho _unidadeTrabalho;
        private readonly IMapper _mapper;


        public RegistrarConta(IContaRepositorio repositorio, IMapper mapper, IUnidadeDeTrabalho unidadeDeTrabalho)
        {
            _repositorio = repositorio;
            _unidadeTrabalho = unidadeDeTrabalho;
            _mapper = mapper;
        }

        public async Task<RespostaContaJson> Executar(RequisicaoContaJson requisicao)
        {
            var conta = _mapper.Map<Domain.Entidades.Conta>(requisicao);

            await _unidadeTrabalho.Commit();

            return _mapper.Map<RespostaContaJson>(conta);
        }

    }

}

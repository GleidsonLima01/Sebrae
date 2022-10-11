using AutoMapper;
using HashidsNet;

namespace Application.Servicos
{
    public class AutoMapperConfiguracao : Profile
    {
        private readonly IHashids _hashids;
        public AutoMapperConfiguracao(IHashids hashids)
        {
            _hashids = hashids;

            RequisicaoParaEntidade();
            EntidadeParaResposta();
        }

        private void EntidadeParaResposta()
        {
            CreateMap<Domain.Entidades.Conta, Comunicacao.Respostas.RespostaContaJson>()
            .ForMember(destino => destino.id, config => config.MapFrom(origem => _hashids.EncodeLong(origem.id)));
        }

        private void RequisicaoParaEntidade()
        {
            CreateMap<Comunicacao.Requisicoes.RequisicaoContaJson, Domain.Entidades.Conta>();
        }
    }
}

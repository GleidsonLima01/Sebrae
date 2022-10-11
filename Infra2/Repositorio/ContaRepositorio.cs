using Domain.Entidades;
using Domain.Repositorio.Conta;
using Microsoft.EntityFrameworkCore;

namespace Infra2.Repositorio
{
    public class ContaRepositorio : IContaRepositorio
    {
        private readonly Context _contexto;

        public ContaRepositorio(Context contexto)
        {
            _contexto = contexto;
        }


        async Task<Conta> IContaRepositorio.RecuperarContaId(long idConta)
        {
            return await _contexto.Contas
                .FirstOrDefaultAsync(c => c.id == idConta);
        }

        public async Task<IList<Conta>> RecuperarContas()
        {
            return await _contexto.Contas.ToListAsync();
        }
    }
}

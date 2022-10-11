using Application.UseCase.Conta;
using AspNetCore.Hashids.Mvc;
using Comunicacao.Requisicoes;
using Comunicacao.Respostas;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers
{
    public class ContaController : Controller
    {
        [HttpPost]
        [ProducesResponseType(typeof(RespostaContaJson), StatusCodes.Status201Created)]
        public async Task<IActionResult> Registrar(
            [FromServices] IRegistrarConta usecase,
            [FromBody] RequisicaoContaJson requisicao)
        {
            var resposta = await usecase.Executar(requisicao);

            return Created(string.Empty, resposta);
            
        }

        [HttpGet]
        public async Task<IActionResult> RecuperarPorId(
        [FromServices] IRecuperarConta useCase,
        [FromRoute][ModelBinder(typeof(HashidsModelBinder))] int id)
        {
            var resposta = await useCase.Executar(id);

            return Ok(resposta);
        }
    }
}

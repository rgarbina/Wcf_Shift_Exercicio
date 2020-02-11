using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WsProcessoSeletivo;
namespace ShiftWebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly WSProcessoSeletivoSoap _wSProcessoSeletivoSoap;

        public PedidoController(ILogger<PedidoController> logger, WSProcessoSeletivoSoap wSProcessoSeletivoSoap)
        {
            _logger = logger;
            _wSProcessoSeletivoSoap = wSProcessoSeletivoSoap;
        }

        [HttpPost]
        public async Task<IActionResult> PostPedidoLab([FromBody] PedidoLab[] pedidoLab)
        {
            var WsClient = new WSProcessoSeletivoSoapClient();

            var queryOrdemServico = pedidoLab.GroupBy(x => x.pedido.ordemServico)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            var queryConcat = pedidoLab.Select(s => new
            { pedido_OrdemServico = s.identificador + s.pedido.ordemServico })
                .GroupBy(x => x.pedido_OrdemServico)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            if (queryOrdemServico.Count > 0 || queryConcat.Count > 0)
            {
                string itemRepetido = string.Join(",", queryOrdemServico.ToArray());
                itemRepetido += string.Join(",", queryConcat.ToArray());

                return BadRequest(itemRepetido);
            }

            foreach (var item in pedidoLab)
            {
                var pedido_OrdemServico = item.identificador + item.pedido.ordemServico;

                if (pedido_OrdemServico != item.pedido.ordemServico)
                {
                    item.pedido.ordemServico = pedido_OrdemServico;
                }
                var listEnum = Enum.GetValues(typeof(Connected_Services.Model.EnumExame)).Cast<Connected_Services.Model.EnumExame>();

                bool hasMatch = item.exames.GroupBy(x => x.codigo)
                    .Any(x => listEnum.Any(y => y.ToString() == x.Key));

                if (hasMatch)
                {
                    return BadRequest(string.Format("Lista de Exames codigo invalido! para ordem de servico{0}", item.pedido.ordemServico));
                }
            }

            string descricaoRequisicao;

            var retorno = WsClient.SolicitaPedido(pedidoLab, out descricaoRequisicao);

            return Ok(retorno);
        }
    }
}

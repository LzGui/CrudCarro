using CrudCarro.Services;
using CrudCarro.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCarro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {

        private readonly ILogger<CarroController> _logger;
        private readonly ICarroService _carro;

        public CarroController(ILogger<CarroController> logger, ICarroService produto)
        {
            _logger = logger;
            _carro = produto;
        }

        [HttpGet]
        public IActionResult TodosCarros()
        {
            return Ok(_carro.RetornarListaCarro());
        }

        [HttpGet("{id}")]
        public IActionResult carro(int id)
        {

            return Ok(_carro.RetornarCarroPorId(id));
        }

        [HttpPost]
        public IActionResult CarroAdd([FromBody] Carros novoCarro)
        {

            return Ok(_carro.AdicionarCarro(novoCarro));
        }

        [HttpPut]
        public IActionResult CarroUpdate([FromBody] Carros novoCarro)
        {

            return Ok(_carro.AtualizarCarro(novoCarro));
        }


        [HttpDelete("{id}")]
        public IActionResult CarroDelete(int id)
        {

            return Ok(_carro.DeletarCarro(id));
        }



    }
}
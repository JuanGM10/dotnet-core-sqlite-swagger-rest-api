using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Request;
using Backend.Response;
using Backend.Repository;
namespace Backend.Controllers
{
    [Route("")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private ICalculatorRepository _calculatorRepository;
        public CalculatorController(ICalculatorRepository calculatorRepository)
        {
            _calculatorRepository = calculatorRepository;
        }

        [HttpGet("Operaciones")]
        public ActionResult<List<Calculator>> Getstrings()
        {
            return _calculatorRepository.Operaciones();
        }


        [HttpPost("Suma")]
        public ResponseApi Suma(CalculatorRequest request)
        {
            return _calculatorRepository.Suma(request);
        }
        [HttpPost("Multiplicar")]
        public ResponseApi Multiplicar(CalculatorRequest request)
        {
            return _calculatorRepository.Multiplicar(request);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Backend.Models;
using Backend.Request;
using Backend.Response;
namespace Backend.Repository
{
    public interface ICalculatorRepository
    {
        public List<Calculator> Operaciones();
        public ResponseApi Suma(CalculatorRequest request);
        public ResponseApi Multiplicar(CalculatorRequest request);
    }
}
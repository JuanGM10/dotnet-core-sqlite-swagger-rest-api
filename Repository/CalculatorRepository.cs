using System;
using System.Collections.Generic;
using System.Linq;
using Backend.Models;
using Backend.Request;
using Backend.Response;
using Backend.Repository;

namespace Backend.Repository
{
	public class CalculatorRepository: ICalculatorRepository
	{
		private UserContext _userContext;
		public CalculatorRepository(UserContext userContext)
        {
			_userContext = userContext;
		}
		public List<Calculator> Operaciones() 
		{
			return _userContext.Calculators.ToList();
		}
		public ResponseApi Suma(CalculatorRequest request) 
		{
			var response = new ResponseApi();
			try
			{
				var calculator = new Calculator();
				calculator.Number1 = request.Number1;
				calculator.Number2 = request.Number2;
				calculator.Result = request.Number1 + request.Number2;
				calculator.Operation = Backend.Constants.Constants.Suma;

				_userContext.Calculators.Add(calculator);
				_userContext.SaveChanges();

				response.Result = calculator.Result;
			}
			catch (Exception ex)
			{
				response.Code = 500;
				response.Message = ex.Message;
			}
			return response;
		}
		public ResponseApi Multiplicar(CalculatorRequest request) 
		{
			var response = new ResponseApi();
			try
			{
				var calculator = new Calculator();
				calculator.Number1 = request.Number1;
				calculator.Number2 = request.Number2;
				calculator.Result = request.Number1 * request.Number2;
				calculator.Operation = Backend.Constants.Constants.Multiplicacion;

				_userContext.Calculators.Add(calculator);
				_userContext.SaveChanges();

				response.Result = calculator.Result;
			}
			catch (Exception ex)
			{
				response.Code = 500;
				response.Message = ex.Message;
			}


			return response;
		}
	}
}
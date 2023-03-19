using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace api.Services
{
	public interface IPaymentService
	{
        bool Charge(double total, ICard card);
    }
}


using System;
namespace api.Services
{
	public interface IShipmentService
	{
        void Ship(IAddressInfo info, IEnumerable<CartItem> items);
	}
}


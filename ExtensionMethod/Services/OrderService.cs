//----------------------------------------
// Tarteeb School (c) All rights reserved |
//----------------------------------------
using ExtensionMethod.Models;
namespace ExtensionMethod.Services
{
    internal class OrderService
    {
        private IList<Product> lineItems;
        private IShipping shipping;
        public OrderService()
        {
            lineItems = new List<Product> { new Product { Name = "Apple", Weight = 4.5 } };
        }
        public int GetTotal() => lineItems.Count;
        public double GetTotalWeight() => lineItems.Sum(x => x.Weight);
        public void SetShippingType(IShipping shippingType) => shipping = shippingType;

        public double GetShippingCost()
        {
            return shipping.GetCost(this);

        }
        public DateTime GetShippingDate() => DateTime.Now;
    }
}

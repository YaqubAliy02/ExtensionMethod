//----------------------------------------
// Tarteeb School (c) All rights reserved |
//----------------------------------------
namespace ExtensionMethod.Services
{
    internal class Sea : IShipping
    {
        public double GetCost(OrderService order)
        {
            if (order.GetTotal() < 100)
            {
                Console.WriteLine("Ground");
            }

            return Math.Max(10, order.GetTotalWeight() * 4);
        }
        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(8);
        }
    }
}

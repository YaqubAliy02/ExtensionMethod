//----------------------------------------
// Tarteeb School (c) All rights reserved |
//----------------------------------------
namespace ExtensionMethod.Services
{
    internal class Ground : IShipping
    {
        public double GetCost(OrderService order)
        {
            if (order.GetTotal() < 100)
            {
                Console.WriteLine("Ground");
            }
            return Math.Max(10, order.GetTotalWeight() * 3);
        }
        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(7);
        }
    }
}

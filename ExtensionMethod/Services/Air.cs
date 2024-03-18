//----------------------------------------
// Tarteeb School (c) All rights reserved |
//----------------------------------------


namespace ExtensionMethod.Services
{
    internal class Air : IShipping
    {
        public double GetCost(OrderService order)
        {
            if (order.GetTotal() < 100)
            {
                Console.WriteLine("Air");
            }
            return Math.Max(20, order.GetTotalWeight() * 3);
        }

        public DateTimeOffset GetDate()
        {
            return DateTime.Now.AddDays(4);
        }
    }
}

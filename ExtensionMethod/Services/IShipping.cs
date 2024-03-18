//----------------------------------------
// Tarteeb School (c) All rights reserved |
//----------------------------------------
namespace ExtensionMethod.Services
{
    internal interface IShipping
    {
        double GetCost(OrderService order);
        DateTimeOffset GetDate();

    }
}

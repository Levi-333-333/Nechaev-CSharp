using System;
using System.Diagnostics;
 
enum OrderStatus
{
    OrderCreated = 1,
    OrderPaid,
    OrderSent,
    OrderDelevered,
    OrderCanseled
}

class Order
{
    private uint id;
    private OrderStatus status;
    public Order(uint id) 
    { 
        this.id = id; 
        status = OrderStatus.OrderCreated;
    }
    public void ChangeStatus(OrderStatus newStatus) => status = newStatus;
    public void PrintInfo() => Console.WriteLine($"Номер заказа {id}: статус заказа {status.ToString()}"); // Да, в задании было через свитч, и вообще это делать в функции ChangeStatus, но я захотел поэксперементировать. Я редиска
}

class Source
{
    string whoIsMe = "я редиска";
    static void Main(string[] args)
    {
        Order order = new Order(1);

        order.PrintInfo();
        order.ChangeStatus(OrderStatus.OrderPaid);
        order.PrintInfo();
        order.ChangeStatus(OrderStatus.OrderSent);
        order.PrintInfo();
        order.ChangeStatus(OrderStatus.OrderDelevered);
        order.PrintInfo();
    }
}
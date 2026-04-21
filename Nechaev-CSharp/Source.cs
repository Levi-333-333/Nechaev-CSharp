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
    public void PrintInfo()
    {
        string currentOrderStatus;
        switch (status)
        {
            case OrderStatus.OrderCreated:
                currentOrderStatus = "Заказ создан";
                break;
            case OrderStatus.OrderPaid:
                currentOrderStatus = "Заказ оплачен";
                break;
            case OrderStatus.OrderSent:
                currentOrderStatus = "Заказ отправлен";
                break;
            case OrderStatus.OrderDelevered:
                currentOrderStatus = "Заказ доставлен";
                break;
            case OrderStatus.OrderCanseled:
                currentOrderStatus = "Заказ отменён";
                break;
            default:
                currentOrderStatus = "Неизвестно";
                break;
        }
        Console.WriteLine($"Номер заказа {id}: статус заказа {currentOrderStatus}");
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
using Domain.Entities.Inventories;
using Domain.Enums.Inventories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IOrderRepository : IModel<Order>
    {
        Order FindById(int orderId);
        Order[] FindByType(OrderType orderType);
        Order[] FindByStatus(OrderStatus status);
    }
}

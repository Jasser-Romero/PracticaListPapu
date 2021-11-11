using Domain.Entities.Inventories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IItemRepository : IModel<Item>
    {
        Item FindById(int id);        
        Item[] FindByProductId(int productId);
    }
}

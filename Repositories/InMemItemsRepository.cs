using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{

  public class InMemItemsRepository : IItemsRepository
  {
    private readonly List<Item> items = new()
    {
      new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedAt = DateTimeOffset.Now },
      new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedAt = DateTimeOffset.Now },
      new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, CreatedAt = DateTimeOffset.Now }
    };

    public IEnumerable<Item> GetItems()
    {
      return items;
    }

    public Item GetItem(Guid id)
    {
      return items.Where(item => item.Id == id).SingleOrDefault();
    }
  }
}
using System;
using System.Collections.Generic;
using Catalog.Entities;
using System.Linq;

namespace Catalog.Repositories
{


    public class InMemItemsRepositories : IItemsRepositories
    {
        private readonly List<Item> items = new()
        {
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Potion",
                Price = 9,
                CreatedDate = DateTimeOffset.UtcNow,
            },
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Iron Sword",
                Price = 20,
                CreatedDate = DateTimeOffset.UtcNow,
            },
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Brozen Shield",
                Price = 18,
                CreatedDate = DateTimeOffset.UtcNow,
            }
        };

        public IEnumerable<Item> GetItems() { return items; }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).FirstOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index = items.FindIndex(e => e.Id == item.Id);
            items[index] = item;
        }

        public void DeleteItem(Guid id)
        {
            var index = items.FindIndex(e => e.Id == id);
            items.RemoveAt(index);
        }
    }
}

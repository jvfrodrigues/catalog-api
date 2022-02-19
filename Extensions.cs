using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
  public static class Extensions
  {
    public static ItemDTO AsDTO(this Item item) //the current item can have a method asDTO()
    {
      return new ItemDTO
      {
        Id = item.Id,
        Name = item.Name,
        Price = item.Price,
        CreatedAt = item.CreatedAt
      };
    }
  }
}
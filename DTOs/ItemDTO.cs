using System;

namespace Catalog.Dtos
{
  public class ItemDTO
  {
    public Guid Id { get; init; } //init only property so the value can not be re set
    public string Name { get; init; }
    public decimal Price { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
  }
}
using System;

namespace Catalog.Entities
{
  public record Item // record instead of class for immutable objects
  {
    public Guid Id { get; init; } //init only property so the value can not be re set
    public string Name { get; init; }
    public decimal Price { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
  }
}
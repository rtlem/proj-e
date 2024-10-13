﻿using mvsshop.Domain;

namespace mvsshop.Domain;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? Image { get; set; }


    public Guid CategoryId { get; set; }

    public virtual Category? Category { get; set; }

}






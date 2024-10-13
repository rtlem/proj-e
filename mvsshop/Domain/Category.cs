﻿using System.ComponentModel.DataAnnotations;

namespace mvsshop.Domain;

public class Category
{
    public Guid Id { get; set; }

    [Display(Name = "Kategori Adı")]
    [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
}

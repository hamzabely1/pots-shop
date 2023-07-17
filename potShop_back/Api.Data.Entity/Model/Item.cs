using System;
using System.Collections.Generic;

namespace Api.Data.Context.Model;

public partial class Item
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float Price { get; set; }

    public int Stock { get; set; }

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public int IdCategory { get; set; }

    public int IdColor { get; set; }

    public int IdMaterial { get; set; }

    public virtual ICollection<BasketItem> BasketItems { get; set; } = new List<BasketItem>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Color IdColorNavigation { get; set; } = null!;

    public virtual Material IdMaterialNavigation { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}

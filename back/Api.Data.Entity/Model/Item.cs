using System;
using System.Collections.Generic;

namespace Api.Data.Entity.Model;

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
}

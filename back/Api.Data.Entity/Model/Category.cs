using System;
using System.Collections.Generic;

namespace Api.Data.Entity.Model;

public partial class Category
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;
}

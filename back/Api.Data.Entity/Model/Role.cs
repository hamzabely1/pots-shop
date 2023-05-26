using System;
using System.Collections.Generic;

namespace Api.Data.Entity.Model;

public partial class Role
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Api.Data.Context.Model;

public partial class Role
{
    public int Id { get; set; }

    public string Label { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}

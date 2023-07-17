using System;
using System.Collections.Generic;

namespace Api.Data.Context.Model;

public partial class Address
{
    public int Id { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int Code { get; set; }

    public virtual ICollection<AddressUser> AddressUsers { get; set; } = new List<AddressUser>();
}

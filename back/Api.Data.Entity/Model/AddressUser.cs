using System;
using System.Collections.Generic;

namespace Api.Data.Entity.Model;

public partial class AddressUser
{
    public int Id { get; set; }

    public int IdAddress { get; set; }

    public int IdUser { get; set; }
}

using System;
using System.Collections.Generic;

namespace Api.Data.Context.Model;

public partial class Panier
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdItem { get; set; }
}

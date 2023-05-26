using System;
using System.Collections.Generic;

namespace Api.Data.Entity.Model;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdRole { get; set; }

    public int IdAddress { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdateDate { get; set; }
}

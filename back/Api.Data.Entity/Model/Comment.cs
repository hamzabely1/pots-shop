using System;
using System.Collections.Generic;

namespace Api.Data.Entity.Model;

public partial class Comment
{
    public int Id { get; set; }

    public int IdItem { get; set; }

    public int IdUser { get; set; }

    public string Content { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime UpdateDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace Api.Data.Context.Model;

public partial class Order
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}

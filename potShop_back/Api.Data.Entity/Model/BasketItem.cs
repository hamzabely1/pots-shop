﻿using System;
using System.Collections.Generic;

namespace Api.Data.Context.Model;

public partial class BasketItem
{
    public int Id { get; set; }

    public int IdBasket { get; set; }

    public int IdItem { get; set; }

    public int Quantity { get; set; }

    public virtual Basket IdBasketNavigation { get; set; } = null!;

    public virtual Item IdItemNavigation { get; set; } = null!;
}

﻿using System;
using System.Collections.Generic;

namespace Api.Data.Entity.Model;

public partial class Order
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public DateTime CreatedDate { get; set; }
}

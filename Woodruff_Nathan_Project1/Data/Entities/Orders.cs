﻿using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class Orders
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public int? UsernameId { get; set; }
        public int? PizzaId { get; set; }

        public virtual Pizzas Pizza { get; set; }
        public virtual Users Username { get; set; }
    }
}

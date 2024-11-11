using System;
using System.Collections.Generic;

namespace APIBurgerKR.Data.Models;

public partial class Promo
{
    public int PromoId { get; set; }

    public string? Descipcion { get; set; }

    public DateTime FechaPromo { get; set; }

    public int BurgerId { get; set; }

    public virtual Burger Burger { get; set; } = null!;
}

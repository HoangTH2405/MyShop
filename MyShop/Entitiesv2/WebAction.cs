using System;
using System.Collections.Generic;

namespace MyShop.Entitiesv2;

public partial class WebAction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<RoleAction> RoleActions { get; set; } = new List<RoleAction>();
}

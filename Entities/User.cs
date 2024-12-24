using System;
using System.Collections.Generic;

namespace CRUDApp.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Middlename { get; set; } = null!;

    public byte[]? Photo { get; set; }

    public int? Role { get; set; }

    public virtual Role? RoleNavigation { get; set; }
}

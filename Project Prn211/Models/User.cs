using System;
using System.Collections.Generic;

namespace Project_Prn211.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public bool? IsBanned { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}

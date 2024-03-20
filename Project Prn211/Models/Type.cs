using System;
using System.Collections.Generic;

namespace Project_Prn211.Models;

public partial class Type
{
    public int TypeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}

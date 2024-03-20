using System;
using System.Collections.Generic;

namespace Project_Prn211.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? Name { get; set; }

    public int? TypeId { get; set; }

    public string? Description { get; set; }

    public int? AuthorId { get; set; }

    public int? PublisherId { get; set; }

    public bool? IsAvailable { get; set; }

    public int? HiredBy { get; set; }

    public DateTime? HiredDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Author? Author { get; set; }

    public virtual User? HiredByNavigation { get; set; }

    public virtual Publisher? Publisher { get; set; }

    public virtual Type? Type { get; set; }
}

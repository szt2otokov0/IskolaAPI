using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IskolaAPI.Models;

[MySqlCollation("utf8_general_ci")]
public partial class vezetok
{
    [Key]
    [Column("#", TypeName = "int(1)")]
    public int _ { get; set; }

    [StringLength(21)]
    public string? Név { get; set; }

    [StringLength(24)]
    public string? Email { get; set; }

    [StringLength(28)]
    public string? Megbízás { get; set; }
}

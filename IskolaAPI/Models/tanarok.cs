using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IskolaAPI.Models;

[MySqlCollation("utf8_general_ci")]
public partial class tanarok
{
    [Key]
    [Column("#", TypeName = "int(2)")]
    public int _ { get; set; }

    [StringLength(16)]
    public string? Oktató { get; set; }

    [StringLength(27)]
    public string? Email { get; set; }

    [StringLength(21)]
    public string? Tantárgy { get; set; }
}

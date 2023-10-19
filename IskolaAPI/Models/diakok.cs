using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IskolaAPI.Models;

[MySqlCollation("utf8_general_ci")]
public partial class diakok
{
    [Key]
    [Column("#", TypeName = "int(2)")]
    public int _ { get; set; }

    [StringLength(25)]
    public string? Tanuló { get; set; }

    [StringLength(22)]
    public string? Email { get; set; }

    [Column(TypeName = "int(1)")]
    public int? Érdemjegy { get; set; }
}

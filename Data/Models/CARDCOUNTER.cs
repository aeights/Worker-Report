using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class CARDCOUNTER
{
    [StringLength(50)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? LASTCOUNTER { get; set; }
}

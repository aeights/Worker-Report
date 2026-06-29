using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_REJECT_REASON_CODE
{
    [Key]
    [StringLength(255)]
    [Unicode(false)]
    public string REJECTREASONID { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? REJECTREASON { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CATEGORY { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? JANGKAWAKTUREPROSES { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EKSEPSIJANGKAWAKTUREPROSES { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EKSEPSIPDLR { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? KETERANGAN { get; set; }
}

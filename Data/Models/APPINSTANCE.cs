using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class APPINSTANCE
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string AP_REGNO { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? MODULE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PROCESSTYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? INSTANCE_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BATCH_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BARCODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STAGE { get; set; }

    [Precision(6)]
    public DateTime? STAGEDATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STAGEBY { get; set; }

    [Precision(6)]
    public DateTime? CREATEDATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CREATEBY { get; set; }

    [Precision(6)]
    public DateTime? UPDATEDATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UPDATEBY { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ACTIVE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? LSO { get; set; }

    [Precision(6)]
    public DateTime? LSODATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LSOBY { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LSOREASON { get; set; }
}

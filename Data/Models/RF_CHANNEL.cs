using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_CHANNEL
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string CHANNEL_ID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? CHANNEL_DESC { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? PREFIX { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ORG { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? LOGO { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCE_CODE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? SUBMIT_REPORT_PATH { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? REJECT_REPORT_PATH { get; set; }

    [Precision(6)]
    public DateTime? CREATE_DATE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ACTIVE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ISFINTECH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BIN { get; set; }
}

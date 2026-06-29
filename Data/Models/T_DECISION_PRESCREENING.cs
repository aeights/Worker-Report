using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_DECISION_PRESCREENING
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string APP_NUMBER { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string DECISION { get; set; } = null!;

    [Precision(19)]
    public long SUBMISSION_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CURRENT_TRACK_CODE { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? REJECT_REASON_CODE { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CREATED_BY { get; set; }

    [Precision(6)]
    public DateTime? UPDATED_AT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UPDATED_BY { get; set; }
}

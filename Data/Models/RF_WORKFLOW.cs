using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_WORKFLOW
{
    [Key]
    [Precision(19)]
    public long WF_ID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string WF_CLIENT_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? WF_CURRENT_STAGE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WF_SUCCESS_STAGE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? WF_FAILED_STAGE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? WF_DECISION { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WF_CREATED_BY { get; set; }

    [Precision(6)]
    public DateTime? WF_CREATED_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WF_UPDATED_BY { get; set; }

    [Precision(6)]
    public DateTime? WF_UPDATED_DATE { get; set; }
}

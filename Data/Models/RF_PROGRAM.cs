using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_PROGRAM
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string PR_CODE { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PR_DESC { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? PR_EMBOSSED_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ACTIVE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UPDATED_BY { get; set; }

    [Precision(6)]
    public DateTime? UPDATED_DATE { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_TOB_RISKGRADE
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CHANNELID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? GRADE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CREATE_BY { get; set; }

    [Precision(6)]
    public DateTime? CREATE_DATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ACTIVE { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("AGENT_CODE", Name = "IX_RF_AGENT_CODE")]
public partial class RF_AGENT
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? AGENT_CODE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AGENT_NAME { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? AGENT_TYPE { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? EXPIRY_DATE { get; set; }

    [Precision(15)]
    public long? FEE { get; set; }

    [Precision(10)]
    public int? TIME_LIMIT { get; set; }
}

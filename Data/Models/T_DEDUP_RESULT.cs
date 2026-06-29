using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_DEDUP_RESULT
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LEADSID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ISDUPLICATE { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? MESSAGE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OVERALLDECISION { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FINALDECISION { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FINALAPPNUMBER { get; set; }
}

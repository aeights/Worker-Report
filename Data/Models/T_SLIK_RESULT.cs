using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_SLIK_RESULT
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LEADSID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? CBASID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? APREGNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DECISION { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? STAGE { get; set; }

    [Precision(6)]
    public DateTime? CREATEDAT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CREATEDBY { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? MATCHINGRESULT { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? SLIKRESULT { get; set; }
}

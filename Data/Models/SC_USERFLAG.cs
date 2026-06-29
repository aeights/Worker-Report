using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class SC_USERFLAG
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string USERNAME { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? SC_LOGON { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SC_REVOKE { get; set; }

    [Precision(10)]
    public int? SC_FALSEPWDCOUNT { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? SC_LASTLOGON { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? SC_LASTACTIVITY { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SC_LASTHOST { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RECONTRACKDEDUP
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string RCD_ID { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? RCD_CODETRACK { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? RCD_NAMATRACK { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? RCD_CENTRALDEDUPSTAT { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? RCD_TRACKSTATUS { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class PROC_GENREGNO
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CHANNELID { get; set; } = null!;

    [Column(TypeName = "NUMBER(1)")]
    public bool? PROCFLAG { get; set; }

    [Precision(6)]
    public DateTime? PROCDATE { get; set; }

    [Precision(10)]
    public int? PROCSEQ { get; set; }
}

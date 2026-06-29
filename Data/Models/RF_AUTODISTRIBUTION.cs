using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_AUTODISTRIBUTION
{
    [Key]
    [StringLength(32)]
    [Unicode(false)]
    public string DS_ID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? USERID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ROLE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? DS_TYPE { get; set; }

    [Precision(10)]
    public int? DS_CAPACITY { get; set; }

    [Precision(6)]
    public DateTime? DS_START_DATE { get; set; }

    [Precision(6)]
    public DateTime? DS_END_DATE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ACTIVE { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class SEGMENT
{
    [Key]
    [Column(TypeName = "NUMBER(38)")]
    public decimal ID { get; set; }

    [Column("SEGMENT")]
    [StringLength(30)]
    [Unicode(false)]
    public string? SEGMENT1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CODE { get; set; }
}

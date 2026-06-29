using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class STATUS_KEPEGAWAIAN
{
    [Key]
    [Column(TypeName = "NUMBER(38)")]
    public decimal ID { get; set; }

    [Column("STATUS_KEPEGAWAIAN")]
    [StringLength(30)]
    [Unicode(false)]
    public string? STATUS_KEPEGAWAIAN1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CODE { get; set; }
}

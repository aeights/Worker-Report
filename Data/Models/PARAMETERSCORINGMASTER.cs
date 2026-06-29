using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class PARAMETERSCORINGMASTER
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SCORINGMSTNAME { get; set; }

    [Column(TypeName = "NUMBER(3,2)")]
    public decimal? RNDMIN { get; set; }

    [Column(TypeName = "NUMBER(3,2)")]
    public decimal? RNDMAX { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STATUSID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? STATUS { get; set; }
}

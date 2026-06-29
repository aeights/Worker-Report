using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class PARAMETERSCORING
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SCORINGCODE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SCORINGNAME { get; set; }

    [Precision(10)]
    public int? APPROVESCORE { get; set; }

    [Precision(10)]
    public int? BASEPOINT { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? KRITERIA { get; set; }

    [Precision(10)]
    public int? DECLINESCORE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STATUSID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [Precision(10)]
    public int? PARAMETERSCORINGMASTER { get; set; }
}

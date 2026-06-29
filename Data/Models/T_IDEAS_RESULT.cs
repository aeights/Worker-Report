using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_IDEAS_RESULT
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LEADSID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? APREGNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DECISION { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? TOTALSCORE { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? RECOMMENDEDCREDITLIMIT { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? OTHERSCORE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RISKLEVEL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SEGMENT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PRODUCTTYPE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DECISIONPROCESSTYPE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? REJECTREASON { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? APPDATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PRODUCTTYPEAPP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? STRATEGY { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVAR0 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARVALUE0 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARRC0 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVAR1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARVALUE1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARRC1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVAR2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARVALUE2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARRC2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVAR3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARVALUE3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARRC3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVAR4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARVALUE4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARRC4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVAR5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARVALUE5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARRC5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVAR6 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARVALUE6 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARRC6 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVAR7 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARVALUE7 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORECARDVARRC7 { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? CREATEDAT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RETRYINFO { get; set; }
}

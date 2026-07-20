using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class T_RULES_RESULT
{
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RULESTYPE { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? DECISION { get; set; }

    [Precision(6)]
    public DateTime? CHECKING_DATE { get; set; }

    [Precision(6)]
    public DateTime? FINISH_DATE { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? IDDATAINRULES { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_CONTAINS_MATRIX { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_CHECKING_COMPLETE { get; set; }
}

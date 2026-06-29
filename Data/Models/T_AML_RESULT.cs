using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_AML_RESULT
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LEADSID { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? HASHITSPEP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESULT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LISTID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DECISION { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ICRDECISION { get; set; }
}

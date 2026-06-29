using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class DECLINECODE
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Column("DECLINECODE")]
    [StringLength(3)]
    [Unicode(false)]
    public string? DECLINECODE1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ROLE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISPS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISVER { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISANALIS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISDEFAULTLETTER { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool RECONTEST { get; set; }
}

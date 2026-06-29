using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class EMAILTEMPLATES
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(200)]
    public string? NAME { get; set; }

    [StringLength(510)]
    public string? SUBJECT { get; set; }

    [Column(TypeName = "CLOB")]
    public string? HEADERHTML { get; set; }

    [Column(TypeName = "CLOB")]
    public string? BODYHTML { get; set; }

    [Column(TypeName = "CLOB")]
    public string? FOOTERHTML { get; set; }

    [Precision(6)]
    public DateTime? CREATEDAT { get; set; }

    [Precision(6)]
    public DateTime? UPDATEDAT { get; set; }

    [Precision(10)]
    public int? PREFIXCODEID { get; set; }

    [Precision(10)]
    public int? DECLINECODEID { get; set; }
}

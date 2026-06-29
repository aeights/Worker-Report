using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_SCREENING_INQUIRY
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LEADSID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DEBTORTYPE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? INQUIRYTYPE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? INQUIRYTYPENAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NAMA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KTP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NPWP { get; set; }
}

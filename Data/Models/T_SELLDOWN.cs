using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_SELLDOWN
{
    [Key]
    [Column(TypeName = "NUMBER(38)")]
    public decimal ID { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? MASTERDATA_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ORGLAMA { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LOGOLAMA { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OPERATOR { get; set; }

    [Precision(6)]
    public DateTime? WAKTU { get; set; }
}

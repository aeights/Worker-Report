using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_CHANGED_LOGO
{
    [Key]
    [Column(TypeName = "NUMBER(38)")]
    public decimal ID { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? MASTERDATA_ID { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? CCACCOUNT_OLD_ID { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? CCACCOUNT_NEW_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FIELD_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VALUE_OLD { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VALUE_NEW { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? OPERATOR { get; set; }

    [Precision(6)]
    public DateTime? WAKTU { get; set; }
}

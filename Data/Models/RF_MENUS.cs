using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_MENUS
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(150)]
    public string LABEL { get; set; } = null!;

    [StringLength(250)]
    public string? PATH { get; set; }

    [StringLength(100)]
    public string? ICON { get; set; }

    [Precision(10)]
    public int? PARENT_ID { get; set; }

    [Precision(10)]
    public int ORDER_NUMBER { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime? UPDATED_AT { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_JENIS_KARTU
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string ID { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string DESCRIPTION { get; set; } = null!;

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CREATED_BY { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? UPDATED_AT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UPDATED_BY { get; set; }
}

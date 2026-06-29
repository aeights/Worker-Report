using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_DASHBOARD_PERMISSION_MAPPING
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string TITLE_NAME { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string PERMISSION_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PROCESS_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ROLE_LEVEL { get; set; } = null!;

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime? UPDATED_AT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ENTRY_FIELD { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_DASHBOARD_HIERARCHY
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string PARENT_TITLE { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string CHILD_TITLE { get; set; } = null!;

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class ROLE_WORKFLOW_MAPPING
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string BEFORE_STATUS { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? AFTER_STATUS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NEXT_ADMIN_ROLE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime? CREATED_DATE { get; set; }

    [Precision(6)]
    public DateTime? UPDATED_DATE { get; set; }

    [InverseProperty("ROLE_MAPPING")]
    public virtual ICollection<ROLE_FIELD_UPDATES> ROLE_FIELD_UPDATES { get; set; } = new List<ROLE_FIELD_UPDATES>();
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_SUB_SECTION_CONDITION
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int SUB_SECTION_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CONDITION_FIELD { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string OPERATOR_CODE { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string CONDITION_VALUE { get; set; } = null!;

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [ForeignKey("SUB_SECTION_ID")]
    [InverseProperty("RF_SUB_SECTION_CONDITION")]
    public virtual RF_SUB_SECTION SUB_SECTION { get; set; } = null!;
}

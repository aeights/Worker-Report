using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("CODE", Name = "SYS_C009868", IsUnique = true)]
public partial class RF_SUB_SECTION
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int SECTION_ID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NAME { get; set; } = null!;

    [Precision(10)]
    public int ORDER_NUMBER { get; set; }

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime UPDATED_AT { get; set; }

    [InverseProperty("SUB_SECTION")]
    public virtual ICollection<RF_QUESTION> RF_QUESTION { get; set; } = new List<RF_QUESTION>();

    [InverseProperty("SUB_SECTION")]
    public virtual ICollection<RF_SUB_SECTION_CONDITION> RF_SUB_SECTION_CONDITION { get; set; } = new List<RF_SUB_SECTION_CONDITION>();

    [ForeignKey("SECTION_ID")]
    [InverseProperty("RF_SUB_SECTION")]
    public virtual RF_SECTION SECTION { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("CODE", Name = "SYS_C009857", IsUnique = true)]
public partial class RF_SECTION
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NAME { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }

    [Precision(10)]
    public int ORDER_NUMBER { get; set; }

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime UPDATED_AT { get; set; }

    [InverseProperty("SECTION")]
    public virtual ICollection<RF_QUESTION> RF_QUESTION { get; set; } = new List<RF_QUESTION>();

    [InverseProperty("SECTION")]
    public virtual ICollection<RF_SUB_SECTION> RF_SUB_SECTION { get; set; } = new List<RF_SUB_SECTION>();
}

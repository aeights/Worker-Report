using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("CODE", Name = "SYS_C009884", IsUnique = true)]
public partial class RF_QUESTION
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int SECTION_ID { get; set; }

    [Precision(10)]
    public int? SUB_SECTION_ID { get; set; }

    [Precision(10)]
    public int? PARENT_QUESTION_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string QUESTION_TEXT { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string ANSWER_TYPE { get; set; } = null!;

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_REQUIRED { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CONDITION_VALUE { get; set; }

    [Precision(10)]
    public int ORDER_NUMBER { get; set; }

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime UPDATED_AT { get; set; }

    [InverseProperty("PARENT_QUESTION")]
    public virtual ICollection<RF_QUESTION> InversePARENT_QUESTION { get; set; } = new List<RF_QUESTION>();

    [InverseProperty("QUESTION")]
    public virtual ICollection<MASTERDATA_QUESTION> MASTERDATA_QUESTION { get; set; } = new List<MASTERDATA_QUESTION>();

    [ForeignKey("PARENT_QUESTION_ID")]
    [InverseProperty("InversePARENT_QUESTION")]
    public virtual RF_QUESTION? PARENT_QUESTION { get; set; }

    [InverseProperty("QUESTION")]
    public virtual ICollection<RF_ANSWER_OPTION> RF_ANSWER_OPTION { get; set; } = new List<RF_ANSWER_OPTION>();

    [InverseProperty("QUESTION")]
    public virtual ICollection<RF_QUESTION_VARIABLE> RF_QUESTION_VARIABLE { get; set; } = new List<RF_QUESTION_VARIABLE>();

    [ForeignKey("SECTION_ID")]
    [InverseProperty("RF_QUESTION")]
    public virtual RF_SECTION SECTION { get; set; } = null!;

    [ForeignKey("SUB_SECTION_ID")]
    [InverseProperty("RF_QUESTION")]
    public virtual RF_SUB_SECTION? SUB_SECTION { get; set; }
}

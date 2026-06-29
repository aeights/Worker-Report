using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_QUESTION_VARIABLE
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int QUESTION_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string PLACEHOLDER { get; set; } = null!;

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime UPDATED_AT { get; set; }

    [ForeignKey("QUESTION_ID")]
    [InverseProperty("RF_QUESTION_VARIABLE")]
    public virtual RF_QUESTION QUESTION { get; set; } = null!;
}

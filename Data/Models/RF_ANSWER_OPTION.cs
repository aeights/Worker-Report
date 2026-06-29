using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_ANSWER_OPTION
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int QUESTION_ID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string OPTION_TEXT { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string OPTION_VALUE { get; set; } = null!;

    [Precision(10)]
    public int ORDER_NUMBER { get; set; }

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime UPDATED_AT { get; set; }

    [ForeignKey("QUESTION_ID")]
    [InverseProperty("RF_ANSWER_OPTION")]
    public virtual RF_QUESTION QUESTION { get; set; } = null!;
}

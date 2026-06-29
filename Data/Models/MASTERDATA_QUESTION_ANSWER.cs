using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_QUESTION_ANSWER
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int MASTERDATA_QUESTION_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ANSWER { get; set; }

    [ForeignKey("MASTERDATA_QUESTION_ID")]
    [InverseProperty("MASTERDATA_QUESTION_ANSWER")]
    public virtual MASTERDATA_QUESTION MASTERDATA_QUESTION { get; set; } = null!;
}

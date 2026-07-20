using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_QUESTION
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int MASTERDATA_FK { get; set; }

    [Precision(10)]
    public int QUESTION_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ANSWER { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ADDITIONAL_FIELD_VALUE { get; set; }

    [ForeignKey("MASTERDATA_FK")]
    [InverseProperty("MASTERDATA_QUESTION")]
    public virtual MASTER_DATA MASTERDATA_FKNavigation { get; set; } = null!;

    [InverseProperty("MASTERDATA_QUESTION")]
    public virtual ICollection<MASTERDATA_QUESTION_ANSWER> MASTERDATA_QUESTION_ANSWER { get; set; } = new List<MASTERDATA_QUESTION_ANSWER>();

    [ForeignKey("QUESTION_ID")]
    [InverseProperty("MASTERDATA_QUESTION")]
    public virtual RF_QUESTION QUESTION { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_EMAIL_RECONTEST
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? STATUS_EMAIL { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DECLINE_CODE { get; set; }
}

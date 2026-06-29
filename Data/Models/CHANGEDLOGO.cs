using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CHANGEDLOGO
{
    [Key]
    [Precision(10)]
    public int CHANGEDLOGO_ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_ID { get; set; }

    [Precision(10)]
    public int? ACCOUNT_OLD_FK { get; set; }

    [Precision(10)]
    public int? ACCOUNT_NEW_FK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FIELDNAME { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? VALUEOLD { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? VALUENEW { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? OPERATOR { get; set; }

    [Precision(6)]
    public DateTime? WAKTU { get; set; }
}

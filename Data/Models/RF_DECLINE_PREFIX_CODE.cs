using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_DECLINE_PREFIX_CODE
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PREFIXCODE { get; set; }

    [Precision(10)]
    public int? DECLINECODEID { get; set; }
}

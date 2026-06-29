using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class OPERATOR_ONLINE
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? OPERATOR_FK { get; set; }

    [Precision(6)]
    public DateTime? LASTLOGIN { get; set; }

    [Precision(6)]
    public DateTime? LASTLOGOUT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? FLAGONLINE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }
}

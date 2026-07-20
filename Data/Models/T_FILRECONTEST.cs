using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_FILRECONTEST
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? T_FILING_FK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NAMARECONTEST { get; set; } = null!;

    [Precision(6)]
    public DateTime? WAKTURECONTEST { get; set; }
}

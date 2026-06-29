using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class HARI_LIBUR
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(6)]
    public DateTime? TANGGALLIBUR { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? DESKRIPSILIBUR { get; set; }
}

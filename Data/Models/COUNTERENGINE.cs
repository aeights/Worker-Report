using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class COUNTERENGINE
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string COUNTERNAME { get; set; } = null!;

    [Precision(19)]
    public long LASTCOUNTER { get; set; }
}

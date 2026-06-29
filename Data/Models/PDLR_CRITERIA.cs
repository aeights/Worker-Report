using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class PDLR_CRITERIA
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PDLRCODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PDLRDESC { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PDLRKETENTUAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? FILTER { get; set; }
}

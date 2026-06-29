using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class TNMST_LOG
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TNMST_PK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [Precision(6)]
    public DateTime WAKTUDE { get; set; }

    [Precision(6)]
    public DateTime EMAILSENTAT { get; set; }
}

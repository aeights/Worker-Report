using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class ROLE
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Column("ROLE")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ROLE1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ROLEDESCRIPTION { get; set; }
}

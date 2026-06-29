using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_STATUS
{
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string ID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? EXPANSION { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }
}

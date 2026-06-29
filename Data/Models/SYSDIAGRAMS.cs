using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class SYSDIAGRAMS
{
    [StringLength(128)]
    public string NAME { get; set; } = null!;

    [Precision(10)]
    public int PRINCIPAL_ID { get; set; }

    [Key]
    [Precision(10)]
    public int DIAGRAM_ID { get; set; }

    [Precision(10)]
    public int? VERSION { get; set; }

    [Column(TypeName = "BLOB")]
    public byte[]? DEFINITION { get; set; }
}

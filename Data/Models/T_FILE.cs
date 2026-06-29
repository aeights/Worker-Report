using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_FILE
{
    [Key]
    [Precision(10)]
    public int T_FILE_PK { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? FILE_NAME { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BUCKET_NAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? KEY { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class GENERATE_PTCU_LOG
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JENIS_PTCU { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FILE_NAME { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? FILE_PATH { get; set; }

    [Precision(10)]
    public int? TOTAL_RECORD { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? ERROR_MESSAGE { get; set; }

    public double? DURATION_SECONDS { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }
}

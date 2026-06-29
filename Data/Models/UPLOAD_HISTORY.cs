using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class UPLOAD_HISTORY
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string BATCH_ID { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? PATH { get; set; }

    [Precision(6)]
    public DateTime? UPLOAD_DATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SIZE { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? UPLOADBY { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? FLAG { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? FLAG_STATUS { get; set; }

    [Precision(6)]
    public DateTime? LAST_UPDATE_DATE { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ORIGIN_FILE_NAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? GENERATED_FILE_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KODE_OUTLET { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KODE_WILAYAH { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NAMA_OUTLET { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TITLE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CHANNEL_ID { get; set; }
}

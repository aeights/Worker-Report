using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_CARDLINK_RESPONSE_PTCU
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string APPID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string JENISPTCU { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string FILENAME { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string STATUS { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string? RESPONSE_MESSAGE { get; set; }

    [Precision(10)]
    public int? TOTAL_READ { get; set; }

    [Precision(10)]
    public int? TOTAL_REJECTED { get; set; }

    [Precision(6)]
    public DateTime CREATEDATE { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CARD_HISTORY
{
    [Key]
    [Precision(19)]
    public long HISTORY_ID { get; set; }

    [Precision(19)]
    public long CARD_ID { get; set; }

    [StringLength(50)]
    public string EVENT_TYPE { get; set; } = null!;

    [StringLength(100)]
    public string? OLD_VALUE { get; set; }

    [StringLength(100)]
    public string? NEW_VALUE { get; set; }

    [StringLength(50)]
    public string SEQUENCE { get; set; } = null!;

    [StringLength(30)]
    public string CHANNEL { get; set; } = null!;

    [StringLength(50)]
    public string ACTION_BY { get; set; } = null!;

    [Precision(6)]
    public DateTime EXPIRE_DATE { get; set; }

    [Precision(6)]
    public DateTime ACTION_DATE { get; set; }

    [StringLength(10)]
    public string BIN_NO { get; set; } = null!;
}

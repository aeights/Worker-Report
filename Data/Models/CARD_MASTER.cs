using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CARD_MASTER
{
    [Key]
    [Precision(19)]
    public long CARD_ID { get; set; }

    [StringLength(16)]
    public string CARD_NUMBER { get; set; } = null!;

    [StringLength(16)]
    public string MASKED_NUMBER { get; set; } = null!;

    [StringLength(20)]
    public string ISSUE_TYPE { get; set; } = null!;

    [StringLength(30)]
    public string? REPLACE_REASON { get; set; }

    [StringLength(50)]
    public string SEQUENCE { get; set; } = null!;

    [StringLength(30)]
    public string CHANNEL { get; set; } = null!;

    [Precision(19)]
    public long? PARENT_CARD_ID { get; set; }

    [StringLength(20)]
    public string STATUS { get; set; } = null!;

    [Precision(6)]
    public DateTime EXPIRE_DATE { get; set; }

    [Precision(6)]
    public DateTime CREATED_DATE { get; set; }

    [StringLength(10)]
    public string BIN_NO { get; set; } = null!;
}

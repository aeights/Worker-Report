using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CARD_COUNTER
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [StringLength(20)]
    public string BIN_NO { get; set; } = null!;

    [Precision(19)]
    public long LAST_COUNTER { get; set; }

    [Precision(6)]
    public DateTime UPDATE_DATE { get; set; }
}

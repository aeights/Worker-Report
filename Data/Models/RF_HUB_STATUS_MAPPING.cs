using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_HUB_STATUS_MAPPING
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CURRENT_STATUS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DESTINATION_STATUS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DESTINATION_HUB_STATUS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TRACKING_CODE { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DECISION_KEY { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DECISION_VALUE { get; set; }
}

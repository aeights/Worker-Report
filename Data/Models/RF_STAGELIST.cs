using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_STAGELIST
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string STAGE_ID { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? STAGE_DESC { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? STAGE_GROUP_STATUS { get; set; }
}

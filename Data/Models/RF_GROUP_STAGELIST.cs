using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_GROUP_STAGELIST
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string GROUP_STAGE_ID { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? GROUP_STAGE_DESC { get; set; }
}

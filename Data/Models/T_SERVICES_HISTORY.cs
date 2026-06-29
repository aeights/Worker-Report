using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_SERVICES_HISTORY
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string APPID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? SERVICE_TYPE { get; set; }

    public string? SERVICE_REQUEST { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    public string? SERVICE_RESPONSE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CREATED_BY { get; set; }

    [Precision(6)]
    public DateTime? CREATED_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LAST_UPDATE_BY { get; set; }

    [Precision(6)]
    public DateTime? LAST_UPDATE_DATE { get; set; }
}

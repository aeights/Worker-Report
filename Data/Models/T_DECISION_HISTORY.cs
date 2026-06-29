using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_DECISION_HISTORY
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string APPID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? DECISION_TYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RESULT { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }

    [Precision(6)]
    public DateTime? CREATED_DATE { get; set; }
}

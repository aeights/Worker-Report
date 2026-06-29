using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_DISTRIBUTION_LIST
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string DISTRIBUTION_ID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? USERBY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USERROLE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TOTALDATA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TOTALUSER { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? FLAGSTATUS { get; set; }

    [Precision(6)]
    public DateTime? FLAGDATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISSENDAUTODISTRIBUTE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AUTODISTRIBUTETYPE { get; set; }
}

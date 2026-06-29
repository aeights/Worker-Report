using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MST_ADDONMISC
{
    [Key]
    [Precision(10)]
    public int MSTADDONMISC_PK { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? HUBUNGANADDON { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISBEKERJAADDON { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISTTDBASIC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISUPLOAD { get; set; }
}

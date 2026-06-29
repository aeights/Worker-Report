using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class RF_KODE_OUTLET_WILAYAH
{
    [StringLength(100)]
    [Unicode(false)]
    public string? KODEOUTLET_BRANCH { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ACCOFFICE_AREACODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAME { get; set; }
}

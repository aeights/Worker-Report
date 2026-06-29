using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class RF_GARUDA_CITY_CODE
{
    [Precision(19)]
    public long ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CITY_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CITY_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STATE_CODE { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? STATE_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? COUNTRY_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? COUNTRY_NAME { get; set; }
}

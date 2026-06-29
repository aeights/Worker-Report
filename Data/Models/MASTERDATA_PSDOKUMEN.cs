using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_PSDOKUMEN
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [Precision(10)]
    public int? RF_PSDOKUMEN_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string STATUSDOKUMEN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string STATUSAWALDOKUMEN { get; set; } = null!;
}

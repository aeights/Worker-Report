using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_FILDOKUMEN
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? T_FILING_FK { get; set; }

    [Precision(10)]
    public int? RF_PSDOKUMEN_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string FLAGPINJAM { get; set; } = null!;
}

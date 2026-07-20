using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class T_PDLRMEMO
{
    [Column(TypeName = "NUMBER")]
    public decimal PDLRMEMO_ID { get; set; }

    [Column(TypeName = "NUMBER")]
    public decimal MASTERDATA_FK { get; set; }

    [Column(TypeName = "NUMBER")]
    public decimal PDLRCRITERIA_FK { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? PDLRMEMO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UPDATEDBY { get; set; }

    [Precision(6)]
    public DateTime? LASTUPDATED { get; set; }
}

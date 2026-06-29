using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_FILPINJAM
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? T_FILING_FK { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string NAMAPEMINJAM { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string DEPTPEMINJAM { get; set; } = null!;

    [Column(TypeName = "DATE")]
    public DateTime? TGLPINJAM { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? TGLKEMBALI { get; set; }

    [Precision(10)]
    public int? RF_PARDEPTPEMINJAM_FK { get; set; }
}

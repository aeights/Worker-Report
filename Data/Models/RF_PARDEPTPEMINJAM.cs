using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_PARDEPTPEMINJAM
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string NAMADEPT { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string KETERANGAN { get; set; } = null!;
}

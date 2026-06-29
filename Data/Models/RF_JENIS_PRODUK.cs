using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_JENIS_PRODUK
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [Precision(10)]
    public int CODE { get; set; }

    [StringLength(16)]
    public string NAMA { get; set; } = null!;

    [Precision(6)]
    public DateTime CREATED_DATE { get; set; }
}

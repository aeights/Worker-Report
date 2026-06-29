using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class JENIS_PERUSAHAAN
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMA { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? KODE { get; set; }
}

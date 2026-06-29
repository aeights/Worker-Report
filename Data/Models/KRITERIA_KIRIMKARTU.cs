using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class KRITERIA_KIRIMKARTU
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }
}

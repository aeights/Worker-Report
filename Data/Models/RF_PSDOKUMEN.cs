using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_PSDOKUMEN
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string FIELDNAME { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string FIELDCAPTION { get; set; } = null!;
}

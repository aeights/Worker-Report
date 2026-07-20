using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class ORG_NEW
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ORG { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ORGNAME { get; set; }
}

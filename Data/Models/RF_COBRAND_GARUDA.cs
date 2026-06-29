using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_COBRAND_GARUDA
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? COBRANDCODE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LOGO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LOGONAME { get; set; }
}

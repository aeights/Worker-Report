using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class OPERATOR_LEVEL
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? OPERATORUSER_FK { get; set; }

    [Precision(10)]
    public int? ROLE_FK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LEVELROLE { get; set; }
}

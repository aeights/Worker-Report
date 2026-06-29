using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class PARAMETERLOGOFIELD
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? LOGO_FK { get; set; }

    [Precision(10)]
    public int? PARFIELD_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MANDATORY { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MANDATORYVER { get; set; }
}

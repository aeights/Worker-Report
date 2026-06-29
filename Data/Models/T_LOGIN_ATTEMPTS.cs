using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_LOGIN_ATTEMPTS
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [Precision(10)]
    public int? USER_FK { get; set; }

    [StringLength(45)]
    public string? IP_ADDRESS { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool IS_SUCCESS { get; set; }

    [Precision(6)]
    public DateTime ATTEMPTED_AT { get; set; }
}

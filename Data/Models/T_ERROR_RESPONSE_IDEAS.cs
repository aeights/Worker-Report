using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_ERROR_RESPONSE_IDEAS
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERRORCODE { get; set; }

    [Column("Error Description")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Error_Description { get; set; }

    [Precision(6)]
    public DateTime? INQUIRYDATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ENGINEVERSION { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ENGINESTACKTRACE { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }
}

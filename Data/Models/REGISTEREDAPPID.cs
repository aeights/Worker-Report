using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class REGISTEREDAPPID
{
    [Key]
    [Precision(10)]
    public int REGISTEREDAPPID_ID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? OPERATOR { get; set; }

    [Precision(6)]
    public DateTime? WAKTUDISTRIBUSI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUINPUT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APPID { get; set; }
}

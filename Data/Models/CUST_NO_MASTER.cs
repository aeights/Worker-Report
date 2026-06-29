using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CUST_NO_MASTER
{
    [Key]
    [Precision(19)]
    public long CUST_NO_ID { get; set; }

    [StringLength(16)]
    public string CUST_NUMBER { get; set; } = null!;

    public string SEQUENCE { get; set; } = null!;

    public string CHANNEL { get; set; } = null!;

    public string STATUS { get; set; } = null!;

    [Precision(6)]
    public DateTime CREATED_DATE { get; set; }

    public string? CREATED_BY { get; set; }

    public string LOGO_CODE { get; set; } = null!;

    public string ORG_CODE { get; set; } = null!;
}

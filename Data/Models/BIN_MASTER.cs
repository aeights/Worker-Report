using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class BIN_MASTER
{
    [Key]
    [Precision(10)]
    public int BIN_ID { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string BIN_NUMBER { get; set; } = null!;

    [Precision(10)]
    public int ORG_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string LOGO_CODE { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string PRODUCT_TYPE { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string STATUS { get; set; } = null!;

    [Precision(6)]
    public DateTime CREATED_DATE { get; set; }
}

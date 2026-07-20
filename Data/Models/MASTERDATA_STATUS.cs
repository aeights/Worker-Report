using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_STATUS
{
    [Key]
    public Guid ID { get; set; }

    [Precision(10)]
    public int MASTERDATA_FK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [Precision(5)]
    public short? ORDER_NO { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CREATED_BY { get; set; }

    [ForeignKey("MASTERDATA_FK")]
    [InverseProperty("MASTERDATA_STATUS")]
    public virtual MASTER_DATA MASTERDATA_FKNavigation { get; set; } = null!;
}

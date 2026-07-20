using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("MASTERDATA_FK", Name = "IX_MASTERDATA_RECONTEST_FK")]
public partial class MASTERDATA_RECONTEST
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RECONTESTREASON { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RECONTESTOPERATOR { get; set; }

    [Precision(6)]
    public DateTime? RECONTESTTIME { get; set; }

    [ForeignKey("MASTERDATA_FK")]
    [InverseProperty("MASTERDATA_RECONTEST")]
    public virtual MASTER_DATA? MASTERDATA_FKNavigation { get; set; }
}

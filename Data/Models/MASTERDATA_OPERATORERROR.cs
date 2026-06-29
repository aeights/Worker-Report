using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_OPERATORERROR
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [Precision(10)]
    public int? CHKERROR_FK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OPERATOR { get; set; }

    [Precision(6)]
    public DateTime? WAKTUCHECK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ROLE { get; set; }

    [Precision(10)]
    public int? CHKIMPACT_FK { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? KETERANGAN { get; set; }

    [ForeignKey("CHKERROR_FK")]
    [InverseProperty("MASTERDATA_OPERATORERROR")]
    public virtual RF_CHKERROR? CHKERROR_FKNavigation { get; set; }

    [ForeignKey("CHKIMPACT_FK")]
    [InverseProperty("MASTERDATA_OPERATORERROR")]
    public virtual RF_CHKIMPACT? CHKIMPACT_FKNavigation { get; set; }
}

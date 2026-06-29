using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class DECLINECODE_DETAIL
{
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [Precision(10)]
    public int DECLINECODE_FK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DECLINECODE { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }

    [Precision(6)]
    public DateTime? CREATEDAT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? REJECTREASON_ID { get; set; }

    [ForeignKey("DECLINECODE_FK")]
    public virtual DECLINECODE DECLINECODE_FKNavigation { get; set; } = null!;
}

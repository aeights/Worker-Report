using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class GFF_PRESCREENING_RESULT
{
    [StringLength(100)]
    [Unicode(false)]
    public string? AP_REGNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LEADS_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STATUS_MEMBER { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CUSTOMER_NAME { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ERROR_MESSAGE { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_NUMBER { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_MEMBER_BNI { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MEMBER_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DECISION { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? RETRY_INFO { get; set; }

    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }
}

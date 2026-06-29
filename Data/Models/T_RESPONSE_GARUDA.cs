using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_RESPONSE_GARUDA
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ISSUCCESS { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? STATUS_MEMBER { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CUSTOMER_NAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ERROR_MESSAGE { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_NUMBER { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ISMEMBERBNI { get; set; }

    [Precision(6)]
    public DateTime? CREATED { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? MEMBER_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STATUS_RESPONSE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FLAGGING_PENGECEKAN { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? MASTERDATA_ID { get; set; }
}

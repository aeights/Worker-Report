using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CC_ACCOUNT
{
    [Key]
    [Precision(10)]
    public int CCACCOUNT_ID { get; set; }

    [Precision(10)]
    public int? CUSTOMER_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ORG { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? LOGO { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string ACCNO { get; set; } = null!;

    [Precision(15)]
    public long? CREDITLIMIT { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? BLOCKCODE { get; set; }

    [Precision(6)]
    public DateTime? OPENDATE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CARDFEEDATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? TGLJATUHTEMPO { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? EXPDATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISCROSSSELL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OPERATORACCOUNT { get; set; }

    [Precision(6)]
    public DateTime? WAKTUACCOUNT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISJAMINAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EMPREFCODE { get; set; }

    [StringLength(23)]
    [Unicode(false)]
    public string? NOREKENING { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ASURANSI { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ASURANSISTATUS { get; set; }

    [Precision(6)]
    public DateTime? ASURANSIDATE { get; set; }

    [Precision(6)]
    public DateTime? ASURANSITGLLAHIR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ICCPLUS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ICCPLUSSTATUS { get; set; }

    [Precision(6)]
    public DateTime? ICCPLUSDATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CARDTYPE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BATCHBICFLAG { get; set; }

    [Precision(6)]
    public DateTime? BATCHBICDATE { get; set; }

    [Precision(6)]
    public DateTime? OPENDATECL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISINSTANTACC { get; set; }

    [Precision(15)]
    public long? CASHLIMIT { get; set; }

    [StringLength(26)]
    [Unicode(false)]
    public string? IDPADAKARTUACC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISACCCHANGELOGO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BATCHCLFLAG { get; set; }

    [Precision(6)]
    public DateTime? BATCHCLDATE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SUBTYPE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PRIORITYPASSACC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISPUBLISHACC { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? BLOCKCODECL { get; set; }
}

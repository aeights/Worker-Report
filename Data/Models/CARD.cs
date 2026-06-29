using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CARD
{
    [Key]
    [Precision(10)]
    public int CARD_ID { get; set; }

    [Precision(10)]
    public int? ACCOUNT_ID { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string CARDNO { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? IMAGENO { get; set; }

    [Precision(6)]
    public DateTime? OPENDATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISKARTU { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? BLOCKCODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BATCHCARDFLAG { get; set; }

    [Precision(6)]
    public DateTime? BATCHCARDDATE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAPADAKARTU { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMASESUAIKTP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISKELAMIN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCEGIFTCODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OPERATORCARD { get; set; }

    [Precision(6)]
    public DateTime? WAKTUCARD { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APPIDCARD { get; set; }

    [Precision(6)]
    public DateTime? CARDFEEDATE { get; set; }

    [Precision(15)]
    public long? CREDITLIMITCARD { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EMPREFCODESUP { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CARDTYPESUP { get; set; }

    [Precision(6)]
    public DateTime? OPENDATECL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISVIPAPP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISINSTANT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PRIORITYPASSSUP { get; set; }
}

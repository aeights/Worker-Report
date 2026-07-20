using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CARD_LOGO
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? ORG_FK { get; set; }

    [Precision(10)]
    public int? PARAMETERSCORING_FK { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? LOGO { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LOGONAME { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? BINNO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISSCORING { get; set; }

    [Precision(10)]
    public int? MINCREDITLINE { get; set; }

    [Precision(15)]
    public long? MAXCREDITLINE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISCORP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISKARTU { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISAFFINITY { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LOGOAFFCODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AFFCODE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? TGLJATUHTEMPO { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? EXPCARD { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AFFCODE2 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SUBLOGOCODE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SUBLOGODESC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISPARENT { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AFFCODE3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? VARIAN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAPRINCIPAL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PARTNERCOBRAND { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JENISPRODUK { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? ISJAMDEPO { get; set; }
}

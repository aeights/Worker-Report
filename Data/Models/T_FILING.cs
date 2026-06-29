using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_FILING
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? MASTER_DATA_FK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? KEPUTUSAN { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? ACCNO { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? CARDNO { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string NAMASESUAIKTP { get; set; } = null!;

    [Column(TypeName = "DATE")]
    public DateTime? TGLLAHIR { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string OPERATOR { get; set; } = null!;

    [Precision(6)]
    public DateTime? WAKTUMASUK { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ADADOKUMEN { get; set; } = null!;

    [Column(TypeName = "DATE")]
    public DateTime? TGLDESTROY { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? MFDATEMULAI { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? MFDATESELESAI { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MFOPERATOR { get; set; }

    [Precision(10)]
    public int? MFROLLNO { get; set; }

    [Precision(10)]
    public int? MFINDEXNO { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? TGLKEPUTUSAN { get; set; }

    [Precision(6)]
    public DateTime? WAKTUDOKUMEN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string FLAGPREEMBOSSED { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string REASONDECLINE { get; set; } = null!;
}

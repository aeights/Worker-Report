using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class OPERATOR_USER
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? USERNAME { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? PASSWORD { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NAMA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? POSISI { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BLOCKCODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISCHGPWD { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? USEREXPDATE { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? PASSWORDEXPDATE { get; set; }

    [Precision(15)]
    public long? MAXCREDITLIMIT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? LEVEL { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TELPPASSWORD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MANUALVERPHONE { get; set; }

    [Precision(6)]
    public DateTime? PASSWORDLASTUPDATED { get; set; }

    [Precision(5)]
    public short? LOGINATTEMPTCOUNT { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ISLOCK { get; set; }

    [Precision(6)]
    public DateTime? LASTLOGINAT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISSENDAUTODISTRIBUTE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AUTODISTRIBUTE_TYPE { get; set; }

    [Precision(10)]
    public int? AUTODISTRIBUTE_CAPACITY { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? AUTODISTRIBUTE_START_DATE { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? AUTODISTRIBUTE_END_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AUTODISTRIBUTE_ROLE { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? UNIT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [Precision(15)]
    public long? MINCREDITLIMIT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JABATAN { get; set; }

    [Precision(15)]
    public long? MINCREDITLIMITPDLR { get; set; }

    [Precision(15)]
    public long? MAXCREDITLIMITPDLR { get; set; }
}

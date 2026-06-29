using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
[Index("USERNAME", Name = "UK_SC_USER_USERNAME", IsUnique = true)]
public partial class SC_USER
{
    [StringLength(50)]
    [Unicode(false)]
    public string USERNAME { get; set; } = null!;

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

    [StringLength(20)]
    [Unicode(false)]
    public string? SC_ROLE { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? SC_LEVEL { get; set; }

    [StringLength(20)]
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

    [StringLength(20)]
    [Unicode(false)]
    public string? AUTODISTRIBUTE_TYPE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? BRANCHID { get; set; }
}

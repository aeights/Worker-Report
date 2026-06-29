using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("LEADSID", "KREDIT_ID", Name = "UK_T_INCOME_VERIFICATION", IsUnique = true)]
public partial class T_INCOME_VERIFICATION_CHECKING
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LEADSID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NAMA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KTP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DEBITUR_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KREDIT_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DEBITUR_POKOK_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LJK { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? LJK_KET { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CABANG { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CABANG_KET { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? BAKI_DEBET { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JENIS_KREDIT { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? JENIS_KREDIT_KET { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JENIS_PENGGUNAAN { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? JENIS_PENGGUNAAN_KET { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? PLAFON_AWAL { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? PLAFON { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KONDISI { get; set; }
}

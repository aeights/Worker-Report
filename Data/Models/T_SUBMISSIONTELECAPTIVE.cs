using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_SUBMISSIONTELECAPTIVE
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(50)]
    public string? CHANNELID { get; set; }

    [StringLength(50)]
    public string? CARDNUMBER { get; set; }

    [StringLength(3)]
    public string? ORG { get; set; }

    [StringLength(3)]
    public string? LOGO { get; set; }

    [StringLength(50)]
    public string? CUSTOMERNUMBER { get; set; }

    [StringLength(50)]
    public string? SOURCECODE { get; set; }

    [StringLength(50)]
    public string? ACCOUNTNUMBER { get; set; }

    [StringLength(50)]
    public string? OPENDATEACCOUNTNUMBER { get; set; }

    [StringLength(200)]
    public string? NAMALENGKAP { get; set; }

    [StringLength(50)]
    public string? TANGGALLAHIR { get; set; }

    [StringLength(200)]
    public string? NAMAIBUKANDUNG { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? INCOME { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? OUTSTANDINGCREDITCARD { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? BLOCKCARD { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? MEMOBALANCE { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? UTILIZATION { get; set; }

    [Precision(10)]
    public int? LIMIT { get; set; }

    [StringLength(20)]
    public string? NPWP { get; set; }

    [StringLength(20)]
    public string? NIK { get; set; }

    [StringLength(50)]
    public string? APPLICATIONNUMBER { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? FLAGKERJADIBANK { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? FLAGAMEX { get; set; }

    [Precision(10)]
    public int? JUMLAHKARTUBASICAKTIF { get; set; }

    [Precision(10)]
    public int? JUMLAHKARTUBASIC { get; set; }

    [Precision(6)]
    public DateTime? CREATEDAT { get; set; }

    [StringLength(50)]
    public string? STATUS { get; set; }
}

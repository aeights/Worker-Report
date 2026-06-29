using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_INCOME_VERIFICATION_RESULT
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

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? METHOD2_TOTAL_BAKI_DEBET { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? METHOD2_VERIFIED_INCOME { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? METHOD3_TOTAL_ANGSURAN { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? METHOD3_VERIFIED_INCOME { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? VERIFIED_INCOME_PROXY { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? VERIFIED_INCOME_ACCOUNT_BALANCE { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? FINAL_VERIFIED_INCOME { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }
}

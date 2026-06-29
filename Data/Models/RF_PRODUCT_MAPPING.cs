using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class RF_PRODUCT_MAPPING
{
    [StringLength(50)]
    [Unicode(false)]
    public string? JENIS_PRODUK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PARTNER_COBRAND { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? PARTNER_AFFINITY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NAMA_PRINCIPAL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VARIAN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KATEGORI_APLIKAN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DETAIL_KARTU { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? ORG { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? LOGO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PARENT_TYPE { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? BIN_NUMBER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MIN_CREDIT_LINE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MAX_CREDIT_LINE { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? CYCLE { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? EXPIRED_CARD { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? PRODUCT_CODE { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? PARTNER_CODE { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? PRINCIPAL_CODE { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? VARIAN_CODE { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? FAMILY_CODE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LOGO_NEW { get; set; }
}

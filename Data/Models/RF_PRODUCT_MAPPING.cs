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

    [StringLength(10)]
    [Unicode(false)]
    public string? ORG { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LOGO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PARENT_TYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BIN_NUMBER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MIN_CREDIT_LINE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MAX_CREDIT_LINE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CYCLE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EXPIRED_CARD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRODUCT_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PARTNER_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRINCIPAL_CODE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? VARIAN_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FAMILY_CODE { get; set; }
}

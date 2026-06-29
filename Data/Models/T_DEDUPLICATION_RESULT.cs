using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_DEDUPLICATION_RESULT
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NIK_APPLIKAN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NAMA_LENGKAP_APLIKAN { get; set; }

    [Precision(6)]
    public DateTime? TANGGAL_LAHIR_APPLIKAN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TEMPAT_LAHIR_APPLIKAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NO_HP_APPLIKAN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? IGNORE_KEY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? INCOME_TYPE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_DUPLICATE { get; set; }

    [Column(TypeName = "NUMBER")]
    public decimal? TBC { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? REQUEST_PRODUCT { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MESSAGE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OVERALL_DECISION { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FINAL_DECISION { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FINAL_APP_NUMBER { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? FINAL_MESSAGE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FINAL_REJECT_REASON_CODE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? FINAL_REJECT_REASON_DESCRIPTION { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? LOGO { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? APPID { get; set; }
}

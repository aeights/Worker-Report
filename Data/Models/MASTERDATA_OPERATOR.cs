using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_OPERATOR
{
    [Key]
    [Precision(10)]
    public int MASTERDATAOPERATOR_ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMADE { get; set; }

    [Precision(6)]
    public DateTime? WAKTUDEMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUDE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAPS { get; set; }

    [Precision(6)]
    public DateTime? WAKTUPSMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUPS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAKOR { get; set; }

    [Precision(6)]
    public DateTime? WAKTUKORMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUKOR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAFILING { get; set; }

    [Precision(6)]
    public DateTime? WAKTUFILINGMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUFILING { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAQCMAKER { get; set; }

    [Precision(6)]
    public DateTime? WAKTUQCMAKERMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUQCMAKER { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAQCCHECKER { get; set; }

    [Precision(6)]
    public DateTime? WAKTUQCCHECKERMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUQCCHECKER { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAQCAPPROVAL { get; set; }

    [Precision(6)]
    public DateTime? WAKTUQCAPPROVALMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUQCAPPROVAL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAVER { get; set; }

    [Precision(6)]
    public DateTime? WAKTUVERMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUVER { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAANALIS { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALISMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALIS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAANALIS2 { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALIS2MULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALIS2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAANALIS3 { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALIS3MULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALIS3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMARATING { get; set; }

    [Precision(6)]
    public DateTime? WAKTURATINGMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTURATING { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMADECISION { get; set; }

    [Precision(6)]
    public DateTime? WAKTUDECISIONMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUDECISION { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMACHECKER { get; set; }

    [Precision(6)]
    public DateTime? WAKTUCHECKERMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUCHECKER { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAPSDIS { get; set; }

    [Precision(6)]
    public DateTime? WAKTUPSDIS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAKORDIS { get; set; }

    [Precision(6)]
    public DateTime? WAKTUKORDIS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAVERDIS { get; set; }

    [Precision(6)]
    public DateTime? WAKTUVERDIS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAANALISDIS { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALISDIS { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? TANGGALMULAI { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? TANGGALSELESAI { get; set; }

    [Precision(10)]
    public int? SLI_DE { get; set; }

    [Precision(10)]
    public int? SLI_PS { get; set; }

    [Precision(10)]
    public int? SLI_KOR { get; set; }

    [Precision(10)]
    public int? SLI_FILING { get; set; }

    [Precision(10)]
    public int? SLI_QCMAKER { get; set; }

    [Precision(10)]
    public int? SLI_QCCHECKER { get; set; }

    [Precision(10)]
    public int? SLI_QCAPPROVAL { get; set; }

    [Precision(10)]
    public int? SLI_VER { get; set; }

    [Precision(10)]
    public int? SLI_ANALIS { get; set; }

    [Precision(10)]
    public int? SLI_ANALIS2 { get; set; }

    [Precision(10)]
    public int? SLI_ANALIS3 { get; set; }

    [Precision(10)]
    public int? SLI_RATING { get; set; }

    [Precision(10)]
    public int? SLI_CHECKER { get; set; }

    [Precision(10)]
    public int? SLI_TOTAL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMACHECKERDIS { get; set; }

    [Precision(6)]
    public DateTime? WAKTUCHECKERDIS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAANALIS4 { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALIS4MULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUANALIS4 { get; set; }

    [Precision(10)]
    public int? SLI_ANALIS4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAPIMPINANLNC { get; set; }

    [Precision(6)]
    public DateTime? WAKTUPIMPINANLNCMULAI { get; set; }

    [Precision(6)]
    public DateTime? WAKTUPIMPINANLNC { get; set; }

    [Precision(10)]
    public int? SLI_PIMPINANLNC { get; set; }

    [Precision(6)]
    public DateTime? FIRST_DECISION_TIME { get; set; }
}

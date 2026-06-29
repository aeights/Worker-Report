using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("APPID", Name = "APPID_UNIQUE", IsUnique = true)]
public partial class MASTER_DATA
{
    [Key]
    [Precision(10)]
    public int MASTERDATA_ID { get; set; }

    [Precision(10)]
    public int? LOGO_FK { get; set; }

    [Precision(10)]
    public int? ACCOUNT_FK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string APPID { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISAPLIKASI { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OPERATOR { get; set; }

    [Precision(10)]
    public int? SCORE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? REKOMENDASI { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISCROSSSELL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISURGENT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISBL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISDUPLIKASI { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? FLAGDISTRIBUSI { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? DECLINECODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DECLINELETTER { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? DECLINELETTERTYPE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? XSELLCUSTNO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISCHECKED { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? CORPCUSTNO { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? KORESPONDENREQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STATUSXTERNAL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? KRITERIAAPLIKASI { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? KRITERIAKIRIM { get; set; }

    [Precision(10)]
    public int? CARD_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ENTRYTYPE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISTNMSTSCORE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? REKOMENDASIAPPROVE { get; set; }

    [Precision(15)]
    public long? REKOMENDASILIMIT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISSCORE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? APPROVECODE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? DELEGASIAPPCODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISDUPLIKASIKONV { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISCHANGELOGO { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? ACCNOCHANGELOGO { get; set; }

    [Precision(10)]
    public int? TNACCOUNT_CL_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISOBC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISIDEAS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IDEASSTATUS { get; set; }

    [Column(TypeName = "NUMBER(5,1)")]
    public decimal? IDEASSCORE { get; set; }

    [Precision(6)]
    public DateTime? IDEASTIME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISROBOTIC { get; set; }

    [Precision(10)]
    public int? IDEASCOUNTER { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISSLIK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SLIKSTATUS { get; set; }

    [Precision(6)]
    public DateTime? SLIKTIME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISFRAUD { get; set; }

    [Precision(6)]
    public DateTime? FRAUDTIME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISVERCHECK { get; set; }

    [Precision(6)]
    public DateTime? VERCHECKTIME { get; set; }

    [Precision(10)]
    public int? SLIKCOUNTER { get; set; }

    [Precision(10)]
    public int? FRAUDCOUNTER { get; set; }

    [Precision(10)]
    public int? VERCHECKCOUNTER { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISDIGIISSUE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISSMDIGIDECISION { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CHANNEL_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UNIT_FK { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ISPRESCREENED { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TITLE { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NAMA_OUTLET { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KODE_WILAYAH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KODE_OUTLET { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CREATED_BY { get; set; }
}

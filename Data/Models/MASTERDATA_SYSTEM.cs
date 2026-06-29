using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_SYSTEM
{
    [Key]
    [Precision(10)]
    public int MASTERDATASYSTEM_ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCEGIFTCODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCEGIFTCODE1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCEGIFTCODE2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCEGIFTCODE3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCEGIFTCODE4 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCEGIFTCODE5 { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? AFFCODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EMPREFCODE { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? NOTPP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STATEMENT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CARDMAILER { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? TGLJATUHTEMPO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ASURANSIBNI { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ICCPLUS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISPHOTO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISTTD { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SPECIALDELIVERYADDRESS { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CARDTYPE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISCREDITLIMITOPT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WEBID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EBILLING { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PRIORITYPASS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RM { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISPUBLISH { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CHANNEL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OTHERCARDCLUSTER { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? STAGE { get; set; }

    [Precision(6)]
    public DateTime? STAGE_DATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? STAGE_UPDATE_BY { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? MIN_CREDIT { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? MAX_CREDIT { get; set; }
}

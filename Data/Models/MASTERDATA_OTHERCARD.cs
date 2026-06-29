using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_OTHERCARD
{
    [Key]
    [Precision(10)]
    public int MASTERDATAOTHERCARD_ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [Precision(10)]
    public int? ISSUER_FK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOKARTU { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? TAHUNTERBIT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OPENDATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CREDITLIMIT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? HIGHBALANCE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OUTSTANDING { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PAYMENT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CASH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DELQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ALREADYRATING { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NAMARATING { get; set; }

    [Precision(6)]
    public DateTime? WAKTURATING { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISNOVALID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MEMORATING { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISTB { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? JENISKARTU { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELQSTATUS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PAYHISTORY { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? XDAYS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? D30 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? D60 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? D90 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PAY { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? DSTAT { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? BILLADDRESS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAIBUKANDUNG { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NOTELPRUMAH { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NOTELPKANTOR { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? HP { get; set; }

    [Precision(6)]
    public DateTime? WAKTUDOWNLOAD { get; set; }

    [Precision(6)]
    public DateTime? WAKTUUPLOAD { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? OPRDOWNLOAD { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? OPRUPLOAD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? RATINGSTATUS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TGLLHR { get; set; }
}

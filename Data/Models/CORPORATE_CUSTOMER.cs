using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CORPORATE_CUSTOMER
{
    [Key]
    [Precision(10)]
    public int CORPORATE_ID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ORG { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? LOGO { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? CUSTNOCORP { get; set; }

    [Precision(15)]
    public long? CREDITLINE { get; set; }

    [Precision(15)]
    public long? CREDITLINEUSED { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? TGLJATUHTEMPO { get; set; }

    [Precision(6)]
    public DateTime? OPENDATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? BLOCKCODE { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? OPERATORCORP { get; set; }

    [Precision(6)]
    public DateTime? WAKTUCORP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SOURCEGIFTCODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BATCHCORPFLAG { get; set; }

    [Precision(6)]
    public DateTime? BATCHCORPDATE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAPERUSAHAAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATKANTOR1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATKANTOR2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATKANTOR3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATKANTOR4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? KOTAKANTOR { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KODEPOSKANTOR { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KOWILTLPKANTOR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NOTLPKANTOR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NOFAXKANTOR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISPERUSAHAAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BIDANGUSAHA { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JMLKARYAWAN { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SIUP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NPWPDOC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AKTEPENDIRIAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? LAPKEUANGAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? REKKORAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? KTP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOSPK { get; set; }

    [Precision(6)]
    public DateTime? TGLSPK { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMADARURAT { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? JABATANDARURAT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATDARURAT1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATDARURAT2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATDARURAT3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATDARURAT4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? KOTADARURAT { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KODEPOSDARURAT { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KOWILTLPDARURAT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NOTLPDARURAT { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? NOHPDARURAT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? EMAILDARURAT { get; set; }

    [Precision(15)]
    public long? CASHLINE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SUBLOGO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IND { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CORPLIABILITY { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SALESFORCE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MIS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? REBATEFREQ { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? REBATEPERCENT { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? NPWP { get; set; }
}

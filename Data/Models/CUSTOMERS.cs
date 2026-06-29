using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class CUSTOMERS
{
    [Key]
    [Precision(10)]
    public int CUSTOMER_ID { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string CUSTNO { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? TGLJATUHTEMPO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STATEMENTFLAG { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CARDMAILERFLAG { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BATCHCUSTOMERFLAG { get; set; }

    [Precision(6)]
    public DateTime? BATCHCUSTOMERDATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OPERATORCUSTOMER { get; set; }

    [Precision(6)]
    public DateTime? WAKTUCUSTOMER { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAKTP { get; set; }

    [Precision(6)]
    public DateTime? TGLLAHIR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISKELAMIN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TANDAPENGENAL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAIBU { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? STATUSKAWIN { get; set; }

    [Precision(10)]
    public int? JMLTANGGUNGAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATRUMAH1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATRUMAH2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATRUMAH3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATRUMAH4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? KOTARUMAH { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KODEPOSRUMAH { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KOWILTLPRUMAH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOTLPRUMAH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOHP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STATUSRUMAH { get; set; }

    [Precision(10)]
    public int? LAMATINGGALTH { get; set; }

    [Precision(10)]
    public int? LAMATINGGALBLN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMADARURAT { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KOWILTLPDARURAT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOTLPDARURAT { get; set; }

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

    [StringLength(20)]
    [Unicode(false)]
    public string? NOTLPKANTOR { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? EXTKANTOR { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAPRS { get; set; }

    [Precision(10)]
    public int? LAMAKERJATH { get; set; }

    [Precision(10)]
    public int? LAMAKERJABLN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BIDANGUSAHA { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISPERUSAHAAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PEKERJAAN { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? GOLPANGKAT { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? JABATAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOTPP { get; set; }

    [Precision(15)]
    public long? SLIPGAJI { get; set; }

    [Precision(10)]
    public int? CORPORATE_FK { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ORG { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISVIPCUST { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISEBILLING { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISCUSTDUPKONV { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RMCUST { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SLIPPENGHASILAN { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SLIPPENGHASILANDATE { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? NPWP { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? TEMPATLAHIR { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? EMPLOYEEID { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? COSTCENTRE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IND { get; set; }
}

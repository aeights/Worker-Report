using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_MISC
{
    [Key]
    [Precision(10)]
    public int MASTERDATAMISC_PK { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? REKENING { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BILLSTATEMENT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISREKENING { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMABANKREKENING { get; set; }

    [StringLength(23)]
    [Unicode(false)]
    public string? NOREKENING { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? TAHUNREKENING { get; set; }

    [Precision(15)]
    public long? SALDOREKBNI { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? TAHUNREKBNI { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? STATERESIDEN { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? SUMBERAPLIKASI { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? REFMANAJEMEN { get; set; }

    [StringLength(23)]
    [Unicode(false)]
    public string? PEMBERIREF { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? WILCABDIV { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NOKARTUTB { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAKARTUTB { get; set; }

    [Precision(15)]
    public long? JUMLAHTB { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAISSUERTB { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PROSEDURTB { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? REGULERTB { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISJAMINAN { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NOACC1 { get; set; }

    [Precision(11)]
    public long? NOMJAMINAN1 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? JATUHTEMPO1 { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? NOBILYET1 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NOACC2 { get; set; }

    [Precision(11)]
    public long? NOMJAMINAN2 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? JATUHTEMPO2 { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? NOBILYET2 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NOACC3 { get; set; }

    [Precision(11)]
    public long? NOMJAMINAN3 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? JATUHTEMPO3 { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? NOBILYET3 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? LOKASIPASAR { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? EMPLOYEEID { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? COSTCENTRE { get; set; }
}

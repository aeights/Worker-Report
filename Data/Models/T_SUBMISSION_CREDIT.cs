using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_SUBMISSION_CREDIT
{
    [Key]
    [Precision(10)]
    public int SUBMISSIONCREDITID { get; set; }

    [StringLength(100)]
    public string? APPNUMBER { get; set; }

    [StringLength(50)]
    public string? ENTITAS { get; set; }

    [StringLength(100)]
    public string? TIPEPRODUK { get; set; }

    [Precision(6)]
    public DateTime? CREATEDAT { get; set; }

    [Precision(6)]
    public DateTime? UPDATEDAT { get; set; }

    [StringLength(50)]
    public string? NIKAPPLIKAN { get; set; }

    [StringLength(200)]
    public string? NAMALENGKAPAPPLIKAN { get; set; }

    [Precision(6)]
    public DateTime? TANGGALLAHIRAPPLIKAN { get; set; }

    [StringLength(50)]
    public string? PHONENUMBERAPPLIKAN { get; set; }

    [StringLength(100)]
    public string? TEMPATLAHIRAPPLIKAN { get; set; }

    [StringLength(50)]
    public string? NPWPAPPLIKAN { get; set; }

    [StringLength(50)]
    public string? INCOMETYPE { get; set; }

    [StringLength(200)]
    public string? NAMABADANUSAHA { get; set; }

    [StringLength(50)]
    public string? NPWPBADANUSAHA { get; set; }

    [StringLength(50)]
    public string? NIBBADANUSAHA { get; set; }

    [StringLength(50)]
    public string? NIKKEYPERSON { get; set; }

    [StringLength(200)]
    public string? NAMAKEYPERSON { get; set; }

    [Precision(6)]
    public DateTime? TANGGALLAHIRKEYPERSON { get; set; }

    [StringLength(50)]
    public string? PHONENUMBERKEYPERSON { get; set; }

    [StringLength(100)]
    public string? TEMPATLAHIRKEYPERSON { get; set; }

    [StringLength(100)]
    public string? STATUS { get; set; }

    [StringLength(100)]
    public string? LOANACCOUNTNUMBER { get; set; }

    [StringLength(100)]
    public string? CARDNUMBER { get; set; }

    [Precision(6)]
    public DateTime? LUNASDATE { get; set; }

    [Precision(6)]
    public DateTime? CLOSEDDATE { get; set; }

    [StringLength(50)]
    public string? CANCELREASONCODE { get; set; }

    [Precision(6)]
    public DateTime? CANCELDATE { get; set; }

    [StringLength(50)]
    public string? REJECTREASONCODE { get; set; }

    [Precision(6)]
    public DateTime? REJECTDATE { get; set; }

    [Precision(6)]
    public DateTime? DISBURSEMENTDATE { get; set; }

    [Precision(6)]
    public DateTime? GENERATIONDATE { get; set; }

    [Precision(6)]
    public DateTime? CANCELLEDDATE { get; set; }

    [Precision(6)]
    public DateTime? APPROVEDDATE { get; set; }

    [StringLength(100)]
    public string? JENISCOLLATERAL { get; set; }

    [StringLength(100)]
    public string? SHM { get; set; }

    [StringLength(200)]
    public string? LOGO { get; set; }

    [StringLength(50)]
    public string? SOURCECODE { get; set; }

    [StringLength(200)]
    public string? ADDITIONALKEY { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? ISACTIVE { get; set; }
}

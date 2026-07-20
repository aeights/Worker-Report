using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_SCREENING_INQUIRY
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LEADSID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DEBTORTYPE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? INQUIRYTYPE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? INQUIRYTYPENAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NAMA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KTP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NPWP { get; set; }

    [Precision(6)]
    public DateTime? TANGGALLAHIR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TEMPATLAHIR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAIBU { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal? MAKSKREDIT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SEKTOREKONOMI { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ALAMAT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KOTA { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PROVINSI { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KODEPOS { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? JENISKELAMIN { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GROUPPRODUCT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SCORINGSTAGE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOKK { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? CBASID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WORKFLOWCODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? INCOMETYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PHONENUMBER { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CHANNELID { get; set; }
}

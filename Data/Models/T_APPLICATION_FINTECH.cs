using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_APPLICATION_FINTECH
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string LEADS_ID { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? CHANNEL_ID { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NAMA_SESUAI_KTP { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NAMA_PADA_KARTU { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? TANGGAL_LAHIR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JENIS_KELAMIN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NOMOR_KTP { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NAMA_IBU_KANDUNG { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? POSISI { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? PEMASUKAN_PER_TAHUN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NOMOR_REKENING { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? LIMIT_AMOUNT { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALAMAT_RUMAH_1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALAMAT_RUMAH_2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALAMAT_RUMAH_3 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALAMAT_RUMAH_4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KOTA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODE_POS { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODE_AREA_RUMAH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOMOR_TELEPON_RUMAH { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR_1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR_2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR_3 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR_4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KOTA_KANTOR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODE_POS_KANTOR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODE_AREA_KANTOR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOMOR_TELEPON_KANTOR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOMOR_TELEPON_APLIKAN { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? NAMA_EMERGENCY_CONTACT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? HUBUNGAN_DENGAN_EMERGENCY_CONTACT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NOMOR_TELEPON_EMERGENCY_CONTACT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PENGIRIMAN_BILLING { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PENGIRIMAN_KARTU { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NOMOR_KARTU_KREDIT_BANK_LAIN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? IDENTITAS_PADA_KARTU { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? CASH_LIMIT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NPWP { get; set; }

    [Precision(10)]
    public int? TENOR_CICILAN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TEMPAT_LAHIR { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JENIS_PRODUK { get; set; }

    [Precision(6)]
    public DateTime? BANK_APPROVED_DATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? TANGGAL_TAGIHAN { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RISK_SCORE { get; set; }

    [Precision(6)]
    public DateTime? SUBMIT_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STAGE { get; set; }

    [Precision(6)]
    public DateTime? STAGE_DATE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? STAGE_UPDATE_BY { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_UPLOADED { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_LIMIT_BINNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ACCNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CARDNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ORG { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LOGO { get; set; }
}

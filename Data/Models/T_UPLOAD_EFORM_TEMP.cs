using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_UPLOAD_EFORM_TEMP
{
    [Column(TypeName = "NUMBER(38)")]
    public decimal? ORG { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LOGO { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? SUBTYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SGC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EMP_REF_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LOKASI_PASAR { get; set; }

    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string APP_ID { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? NAMA_KARTU { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMA_KTP { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NO_IDENTITAS { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? WNI { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TEMPAT_LAHIR { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? TGL_LAHIR { get; set; }

    [Precision(3)]
    public byte? UMUR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JK { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_RUMAH1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_RUMAH2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_RUMAH3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_RUMAH4 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KELURAHAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KECAMATAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KOTA_RUMAH { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODEPOS_RUMAH { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODE_TLP_RUMAH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NO_TLP_RUMAH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NO_HP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? STATUS_RUMAH { get; set; }

    [Precision(3)]
    public byte? LAMA_TINGGAL_TH { get; set; }

    [Precision(3)]
    public byte? LAMA_TINGGAL_BL { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? STATUS_KAWIN { get; set; }

    [Precision(3)]
    public byte? JML_TANGGUNGAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PENDIDIKAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? IBU_KANDUNG { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMA_DARURAT { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? HUB_DARURAT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_DARURAT1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_DARURAT2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_DARURAT3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_DARURAT4 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KOTA_DARURAT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODEPOS_DARURAT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODE_TLP_DARURAT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NO_TLP_DARURAT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PEKERJAAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? JENIS_PERUSAHAAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMA_PERUSAHAAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BIDANG_USAHA { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? JABATAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GOLONGAN_PANGKAT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BAGIAN { get; set; }

    [Precision(3)]
    public byte? LAMA_KERJA_TH { get; set; }

    [Precision(3)]
    public byte? LAMA_KERJA_BL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR4 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KOTA_KANTOR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODEPOS_KANTOR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODE_TLP_KANTOR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NO_TLP_KANTOR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NO_TLP_KANTOR_EXT { get; set; }

    [Precision(6)]
    public int? JML_KARYAWAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMA_PERUSAHAAN_SBLM { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR_SBLM1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR_SBLM2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMAT_KANTOR_SBLM3 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? JABATAN_SBLM { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? BAGIAN_SBLM { get; set; }

    [Precision(3)]
    public byte? LAMA_KERJA_SBLM_TH { get; set; }

    [Precision(3)]
    public byte? LAMA_KERJA_SBLM_BL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NPWP { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ID_PADA_KARTU { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? PENGHASILAN { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? PENGHASILAN_LAIN_BERSIH { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? PENGHASILAN_LAIN_KOTOR { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? PENGHASILAN_LAIN_TOTAL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SLIP_GAJI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SUMBER_PENGHASILAN_LAIN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? JENIS_REKENING { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMA_BANK { get; set; }

    [Precision(4)]
    public byte? SEJAK_TH { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NO_REKENING { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? SALDO { get; set; }

    [Precision(4)]
    public byte? SALDO_SEJAK_TH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ALAMAT_KIRIM_TAGIHAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ALAMAT_KIRIM_KARTU { get; set; }

    [Precision(2)]
    public byte? TGL_JATUH_TEMPO { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ASURANSI { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ICC_PLUS { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? IS_PHOTO { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? IS_TTD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WEB_ID { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? E_BILLING { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NO_KARTU_TBR { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? MISC_NAMA_KARTU { get; set; }

    [Precision(10)]
    public int? JML_TRANSFER { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMA_ISSUER { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PERSETUJUAN_PROSEDUR { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PERSETUJUAN_REGULAR { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NO_KARTU1 { get; set; }

    [Precision(4)]
    public byte? TH_TERBIT1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NO_KARTU2 { get; set; }

    [Precision(4)]
    public byte? TH_TERBIT2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NO_KARTU3 { get; set; }

    [Precision(4)]
    public byte? TH_TERBIT3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NO_KARTU4 { get; set; }

    [Precision(4)]
    public byte? TH_TERBIT4 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMA_DE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MEMO { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? JENIS_JAMINAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NOACCOUNT1 { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? NOM_JAMINAN1 { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? JATUHTEMPO1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NOBILYET1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NOACCOUNT2 { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? NOM_JAMINAN2 { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? JATUHTEMPO2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NOBILYET2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NOACCOUNT3 { get; set; }

    [Column(TypeName = "NUMBER(18,2)")]
    public decimal? NOM_JAMINAN3 { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? JATUHTEMPO3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NOBILYET3 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? PRIORITYPASS { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ISPUBLISH { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_PROCESSED { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UPLOAD_BY { get; set; }

    [Precision(6)]
    public DateTime? UPLOAD_AT { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_LIMIT_BINNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MIN_MAX_CREDIT_LIMIT { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? APAKAH_MEMILIKI_KARTU_KREDIT_BANK_LAIN { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BANK_PENERBIT { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? KODE_KARTU { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? TIPE_KARTU_YANG_DIPILIH { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NO_REFERAL_ID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? KODE_REFERAL { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? LEAD { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PILIHAN_GIMMICK { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? APAKAH_ANDA_MEMILIKI_FASILITAS_KREDIT_DI_BANK { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ALAMAT_1_KTP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ALAMAT_2_KTP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ALAMAT_3_KTP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ALAMAT_4_KTP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? KELURAHAN_KTP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? KECAMATAN_KTP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? KOTA_KTP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? KODE_POS_KTP { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NO_KARTU_KELUARGA { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FRAUD_CHECK { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? VERIFICATION_CHECK { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? IDEAS_DECISION { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? IDEAS_DECISION_2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? REKOMENDASI_LIMIT { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ALASAN_PENOLAKAN { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FINAL_INCOME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KODE_OUTLET { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMA_OUTLET { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? KODE_WILAYAH { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TITLE { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? APP_ID_ORIGINAL { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_PEKERJAAN
{
    [Key]
    [Precision(10)]
    public int MASTERDATAPEKERJAAN_ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PEKERJAAN { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SIPROFESI { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SIUP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SKJABATAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISPERUSAHAAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAPERUSAHAAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BIDANGUSAHA { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? JABATAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? GOLPANGKAT { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? BAGIAN { get; set; }

    [Precision(10)]
    public int? LAMAKERJATH { get; set; }

    [Precision(10)]
    public int? LAMAKERJABLN { get; set; }

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

    [StringLength(5)]
    [Unicode(false)]
    public string? EXTKANTOR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JMLKARYAWAN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAPRSSBLM { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATPRSSBLM1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATPRSSBLM2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ALAMATPRSSBLM3 { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? JABATANSBLM { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? BAGIANSBLM { get; set; }

    [Precision(10)]
    public int? LAMAKERJASBLMTH { get; set; }

    [Precision(10)]
    public int? LAMAKERJASBLMBLN { get; set; }

    [Precision(15)]
    public long? GAJIBERSIH { get; set; }

    [Precision(15)]
    public long? SLIPGAJI { get; set; }

    [Precision(15)]
    public long? GAJIEXTRABERSIH { get; set; }

    [Precision(15)]
    public long? GAJIEXTRAKOTOR { get; set; }

    [Precision(15)]
    public long? TOTALGAJIEXTRA { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SUMBERGAJILAIN { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? NPWP { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NOFAXKANTOR { get; set; }

    [StringLength(26)]
    [Unicode(false)]
    public string? IDPADAKARTU { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SLIPPENGHASILAN { get; set; }

    [Precision(10)]
    public int? JMLLAMAKERJA { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STATUS_KEPEGAWAIAN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STATUS_PEKERJAAN { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_DUKCAPIL_RESULT
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LEADSID { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? EKTPSTATUS { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? DUSUN { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NAMA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AGAMA { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? EKTPCREATED { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? JENISPEKERJAAN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PDDKAKH { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TMPTLAHIR { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? TGLLAHIR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? STATUSKAWIN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GOLONGANDARAH { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NOAKTAKAWIN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? JENISKELAMIN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NOKK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NIK { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NAMAAYAH { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NAMAIBU { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAKELURAHAN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAKECAMATAN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAKABUPATEN { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NAMAPROVINSI { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NORW { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NORT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NOKELURAHAN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NOKECAMATAN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NOKABUPATEN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NOPROVINSI { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KODEPOS { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ALAMAT { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? REMARKDATA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ICRDECISION { get; set; }
}

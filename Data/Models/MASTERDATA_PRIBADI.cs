using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_PRIBADI
{
    [Key]
    [Precision(10)]
    public int MASTERDATAPRIBADI_ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAPADAKARTU { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMASESUAIKTP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TANDAPENGENAL { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? WARGANEGARA { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TEMPATLAHIR { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? TGLLAHIR { get; set; }

    [Precision(10)]
    public int? UMUR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JENISKELAMIN { get; set; }

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

    [StringLength(20)]
    [Unicode(false)]
    public string? KELURAHANRUMAH { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KECAMATANRUMAH { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? KOTARUMAH { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KODEPOSRUMAH { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KOWILTLPRUMAH { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NOTLPRUMAH { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? NOHP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EMAIL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STATUSRUMAH { get; set; }

    [Precision(10)]
    public int? LAMATINGGALTH { get; set; }

    [Precision(10)]
    public int? LAMATINGGALBLN { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? STATUSKAWIN { get; set; }

    [Precision(10)]
    public int? JMLTANGGUNGAN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PENDIDIKANAKHIR { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMAIBU { get; set; }

    [Precision(10)]
    public int? JMLLAMATINGGAL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AGAMA { get; set; }
}

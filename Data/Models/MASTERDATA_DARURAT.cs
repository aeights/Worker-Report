using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MASTERDATA_DARURAT
{
    [Key]
    [Precision(10)]
    public int MASTERDATADARURAT_ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NAMADARURAT { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? HUBUNGANDARURAT { get; set; }

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
    public string? RTRWDARURAT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? KOTADARURAT { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KODEPOSDARURAT { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? KOWILTLPDARURAT { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? NOTLPDARURAT { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? NOHPDARURAT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? EMAILDARURAT { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? JABATANDARURAT { get; set; }
}

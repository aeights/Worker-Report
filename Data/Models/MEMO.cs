using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class MEMO
{
    [Key]
    [Precision(10)]
    public int MEMO_ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [Column("MEMO")]
    [StringLength(255)]
    [Unicode(false)]
    public string? MEMO1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OPERATOR { get; set; }

    [Precision(6)]
    public DateTime? WAKTU { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? MEMOROLE { get; set; }
}

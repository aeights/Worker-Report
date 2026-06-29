using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("MASTERDATA_FK", Name = "IX_KOR_MSTFK")]
public partial class MASTERDATA_KORESPONDEN
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? PURPOSE { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? RETURN_DATE { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? CALLING_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CALLING_STATUS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DELIVERY_TYPE { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? INCOMING_DOC_DATE { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? OUTGOING_DATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? INITIAL_STATUS { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RETURN_STATUS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RETURN_OPERATOR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RETURN_COLUMN { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? KOR_RECOMMENDATION { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? KOR_VALUE { get; set; }
}

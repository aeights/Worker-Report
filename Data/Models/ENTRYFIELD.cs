using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class ENTRYFIELD
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? FIELDNAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FIELDCAPTION { get; set; }

    [Precision(10)]
    public int? FIELDLENGTH { get; set; }

    [Precision(10)]
    public int? FIELDLENGTHMAX { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FIELDTYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? INPUTTYPE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? KODEINPUTTYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ENTRY_TYPE { get; set; }
}

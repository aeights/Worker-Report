using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class RF_AUDIT_CONFIG
{
    [StringLength(100)]
    [Unicode(false)]
    public string? ENTITY_NAME { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ENABLED { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IS_MODE { get; set; }

    [Unicode(false)]
    public string? IGNORED_FIELDS { get; set; }
}

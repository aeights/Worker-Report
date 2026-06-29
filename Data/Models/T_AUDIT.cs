using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_AUDIT
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int USER_ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? USERNAME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ACTION { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MODULE { get; set; }

    public string? DESCRIPTION { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ENTITY_NAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ENTITY_PK { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FIELD { get; set; }

    public string? OLD_VALUE { get; set; }

    public string? NEW_VALUE { get; set; }

    [StringLength(50)]
    public string? IP_ADDRESS { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? USER_AGENT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STATUS { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ENTITY_ID { get; set; } = null!;
}

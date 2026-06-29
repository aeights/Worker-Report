using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_TIERING_MAPPING
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TITLE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PREFIX { get; set; } = null!;

    [Precision(10)]
    public int LEVEL { get; set; }

    [Precision(10)]
    public int? PROPOSE_TO { get; set; }

    [Precision(15)]
    public long? MIN_CREDIT_LIMIT { get; set; }

    [Precision(15)]
    public long? MAX_CREDIT_LIMIT { get; set; }

    [Precision(15)]
    public long? MIN_CREDIT_LIMIT_PDLR { get; set; }

    [Precision(15)]
    public long? MAX_CREDIT_LIMIT_PDLR { get; set; }

    [Required]
    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }

    [InverseProperty("PROPOSE_TONavigation")]
    public virtual ICollection<RF_TIERING_MAPPING> InversePROPOSE_TONavigation { get; set; } = new List<RF_TIERING_MAPPING>();

    [ForeignKey("PROPOSE_TO")]
    [InverseProperty("InversePROPOSE_TONavigation")]
    public virtual RF_TIERING_MAPPING? PROPOSE_TONavigation { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class ROLE_FIELD_UPDATES
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [Column(TypeName = "NUMBER")]
    public decimal ROLE_MAPPING_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FIELD_NAME { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string FIELD_VALUE_TYPE { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? CUSTOM_VALUE { get; set; }

    [Column(TypeName = "NUMBER")]
    public decimal? UPDATE_ORDER { get; set; }

    [ForeignKey("ROLE_MAPPING_ID")]
    [InverseProperty("ROLE_FIELD_UPDATES")]
    public virtual ROLE_WORKFLOW_MAPPING ROLE_MAPPING { get; set; } = null!;
}

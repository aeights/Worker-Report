using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_STATUS_PERKAWINAN
{
    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string STATUS_CODE { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string STATUS_NAME { get; set; } = null!;

    [Column(TypeName = "DATE")]
    public DateTime? CREATED_AT { get; set; }

    [Column(TypeName = "DATE")]
    public DateTime? UPDATED_AT { get; set; }
}

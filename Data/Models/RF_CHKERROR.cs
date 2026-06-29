using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class RF_CHKERROR
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? KODEERROR { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DESKRIPSIERROR { get; set; }

    [Column(TypeName = "NUMBER(38)")]
    public decimal TNCHKERROR_PK { get; set; }

    [InverseProperty("CHKERROR_FKNavigation")]
    public virtual ICollection<MASTERDATA_OPERATORERROR> MASTERDATA_OPERATORERROR { get; set; } = new List<MASTERDATA_OPERATORERROR>();
}

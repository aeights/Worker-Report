using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("ROLE_FK", "LEVEL_ROLE", "MENU_FK", Name = "UNIQUE_ROLE_LEVEL_MENU", IsUnique = true)]
public partial class RF_ROLE_MENU_PERMISSIONS
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [Precision(10)]
    public int ROLE_FK { get; set; }

    [Precision(10)]
    public int MENU_FK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string LEVEL_ROLE { get; set; } = null!;

    [Column(TypeName = "NUMBER(1)")]
    public bool CAN_CREATE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool CAN_READ { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool CAN_UPDATE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool CAN_DELETE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool IS_ACTIVE { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime? UPDATED_AT { get; set; }
}

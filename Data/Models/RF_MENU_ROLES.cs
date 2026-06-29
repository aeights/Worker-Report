using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[PrimaryKey("MENU_ID", "ROLE_ID")]
public partial class RF_MENU_ROLES
{
    [Key]
    [Precision(10)]
    public int MENU_ID { get; set; }

    [Key]
    [Precision(10)]
    public int ROLE_ID { get; set; }

    [Precision(6)]
    public DateTime CREATED_AT { get; set; }
}

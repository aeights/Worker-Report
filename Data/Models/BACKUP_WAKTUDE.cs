using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Keyless]
public partial class BACKUP_WAKTUDE
{
    [Precision(10)]
    public int? MASTERDATA_FK { get; set; }

    [Precision(6)]
    public DateTime? WAKTUDE { get; set; }
}

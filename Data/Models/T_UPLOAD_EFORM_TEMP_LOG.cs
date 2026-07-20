using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_UPLOAD_EFORM_TEMP_LOG
{
    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FILE_NAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? APPLICATION_ID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BATCH_ID { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? ERROR_MESSAGE { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_RESOLVED { get; set; }

    [Precision(6)]
    public DateTime? RESOLVED_AT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RESOLVED_BY { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_SUCCESS { get; set; }

    [Key]
    [Column(TypeName = "NUMBER(38)")]
    public decimal ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? IDEAS_DECISION_2 { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? DEVELOPER_ERROR_MESSAGE { get; set; }
}

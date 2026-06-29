using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_SUCCESS_RESPONSE_IDEAS
{
    [Key]
    [Precision(10)]
    public int ID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DECISION { get; set; }

    [Precision(10)]
    public int? TOTAL_SCORE { get; set; }

    [Precision(18)]
    public long? RECOMMENDED_CREDIT_LIMIT { get; set; }

    [Precision(10)]
    public int? OTHER_SCORE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SCORE_CARD { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? RISK_LEVEL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SEGMENT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PRODUCT_TYPE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DECISION_PROCESS_TYPE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? REJECT_REASON { get; set; }

    [Precision(6)]
    public DateTime? APP_DATE { get; set; }

    [Precision(10)]
    public int? PRODUCT_TYPE_APP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STRATEGY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_0 { get; set; }

    [Precision(10)]
    public int? SCORECARD_VAR_VALUE_0 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_RC_0 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_1 { get; set; }

    [Precision(10)]
    public int? SCORECARD_VAR_VALUE_1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_RC_1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_2 { get; set; }

    [Precision(10)]
    public int? SCORECARD_VAR_VALUE_2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_RC_2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_3 { get; set; }

    [Precision(10)]
    public int? SCORECARD_VAR_VALUE_3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_RC_3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_4 { get; set; }

    [Precision(10)]
    public int? SCORECARD_VAR_VALUE_4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_RC_4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_5 { get; set; }

    [Precision(10)]
    public int? SCORECARD_VAR_VALUE_5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_RC_5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_6 { get; set; }

    [Precision(10)]
    public int? SCORECARD_VAR_VALUE_6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_RC_6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_7 { get; set; }

    [Precision(10)]
    public int? SCORECARD_VAR_VALUE_7 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SCORECARD_VAR_RC_7 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NO_HP { get; set; }

    [Precision(18)]
    public long? SISA_LIMIT { get; set; }

    [Precision(18)]
    public long? MAX_LIMIT_OTH_BANK { get; set; }

    [Precision(18)]
    public long? LIMIT_BY_SCORE { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }
}

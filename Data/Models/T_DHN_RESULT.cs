using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

public partial class T_DHN_RESULT
{
    [Key]
    [Column(TypeName = "NUMBER")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LEADSID { get; set; } = null!;

    [Column(TypeName = "NUMBER")]
    public decimal? SUSPECTDATA { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RESULT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DECISION { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DHNRESID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DHNNO { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? CUSTADDRESS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CUSTTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BANKCODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? BANKNAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CUSTNAME { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CUSTADDRESS_1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CUSTADDRESS_2 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CUSTADDRESS_3 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CUSTADDRESS_4 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CUSTADDRESSPROV { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CUSTADDRESSCITY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PROCFLAG { get; set; }

    [Precision(6)]
    public DateTime? CUSTBIRTHDATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CUSTNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CUSTPOSTCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CUSTNOINBNI { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CUSTIDNO { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CUSTTFNNO { get; set; }

    [Precision(6)]
    public DateTime? DHNEXPDATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DHNSEQNO { get; set; }

    [Precision(6)]
    public DateTime? DHNMODIFIEDDATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CUSTSTATUS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FUZZYNAME { get; set; }
}

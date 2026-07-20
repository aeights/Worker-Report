using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("APPID", "M_ACCOUNT", Name = "T_GENERATE_PTCU_CUSTOMER_UNIQUE", IsUnique = true)]
public partial class T_GENERATE_PTCU_CUSTOMER
{
    [Key]
    [Precision(19)]
    public long ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? APPID { get; set; }

    [Precision(6)]
    public DateTime? CREATED_AT { get; set; }

    [Precision(6)]
    public DateTime? UPDATE_AT { get; set; }

    [Column(TypeName = "NUMBER(1)")]
    public bool? IS_PROCESSED { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? STATUS_CARDLINK { get; set; }

    [Precision(6)]
    public DateTime? STATUS_DATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? M_REC_TYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? M_ORG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? M_TYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? M_ACCOUNT { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? M_FILE_TYPE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? M_JULIAN_DAY { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? M_TIME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? M_TERMINAL_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? M_SIGNON_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? M_SOURCE_CODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_01_NAME_LINE_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NC_01_HOME_PHONE { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? NC_01_FOREIGN_IND { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? NC_01_REGULER_CUST { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? NC_01_CUST_IND { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_02_NAME_LINE_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NC_02_CO_PHONE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_03_ADDR_LINE_1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_03_SHORT_NAME { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_04_ADDR_LINE_2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_04_SMSA { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_04_CENSUS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_05_CITY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_05_STATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_05_ZIP_CODE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_06_CO_OWNER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_06_CREDIT_LINE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_06_MBR_SINCE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_06_OVERLIMIT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_07_TAX_ID_NBR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NC_07_TAX_ID_FLAG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_07_BIRTH_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_07_CO_TAX_ID_NBR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NC_07_CO_TAX_ID_FLAG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_07_CO_BIRTH_DATE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_08_EMPLOYER { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NC_08_WORK_PHONE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NC_08_WORK_PHONE_FLAG { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_09_CO_EMPLOYER { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_09_BILLING_CYCLE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_10_MEMO_1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_11_MEMO_2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_12_STATUS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_12_CASH_LINE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_12_RM { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_13_NAME_LINE_3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_13_CIF_NMBR { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_14_EU_SURN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_14_EU_INIT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_14_EU_TITLE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NC_14_EU_SEX { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_BEHAV_SCORE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_HOME_OWNER { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_TYPE_OF_RES { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_PER_OF_RES { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_ACORN_CODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_LEZ_CODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_BANK_ACCT_IND { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_MARITAL_STATUS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_NBR_OF_DEPS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_OCCPN_CODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_PER_OCCPN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_CUSTOMER_CLASS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_15_EU_EMPLOYER_CODE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_15_EU_DIRECT_MAIL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_JNT_OWNERSHIP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_GUARANTOR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_EU_STATUS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_15_CRT_LIABLE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_16_CRLINE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_16_CRLINE_PERM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_16_CRLINE_TEMP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_16_CRLINE_TEMP_EFF_DTE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_16_CRLINE_TEMP_EXP_DTE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_17_ADDL_ADDR_1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_17_ADDL_EXP_DATE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_18_ADDL_ADDR_2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_18_ADDL_ZIP { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_19_ADDL_ADDR_3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NC_20_ADDL_CITY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_20_ADDL_USAGE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_21_INCOME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_21_IC_PP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_21_LAST_IC_PP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_21_USR_DEF1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_21_USR_DEF2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_21_SUBMIT_DTE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_22_MOTHER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_40_SUP1_CRDNBR1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_40_SUP1_CRDNBR2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_40_SUP1_REL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_40_SUP1_BDTE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_41_SUP1_IC_PP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_41_SUP1_ADDRTYP { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_41_SUP1_ADDR1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_41_SUP1_POSTAL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_42_SUP1_ADDR2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_42_SUP1_HOMETEL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_42_SUP1_ST { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_43_SUP1_ADDR3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_43_SUP1_WRKTEL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NCA_44_SUP1_CITY { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_44_SUP1_HPHONE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_45_SUP1_EMPLOYER { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_46_SUP1_MOTHER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_46_SUP1_INCOME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_47_SUP2_CRDNBR1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_47_SUP2_CRDNBR2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_47_SUP2_REL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_47_SUP2_BDTE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_48_SUP2_IC_PP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_48_SUP2_ADDRTYP { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_48_SUP2_ADDR1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_48_SUP2_POSTAL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_49_SUP2_ADDR2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_49_SUP2_HOMETEL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_49_SUP2_ST { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_50_SUP2_ADDR3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_50_SUP2_WRKTEL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NCA_51_SUP2_CITY { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_51_SUP2_HPHONE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_52_SUP2_EMPLOYER { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_53_SUP2_MOTHER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_53_SUP2_INCOME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_54_SUP3_CRDNBR1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_54_SUP3_CRDNBR2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_54_SUP3_REL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_54_SUP3_BDTE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_55_SUP3_IC_PP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_55_SUP3_ADDRTYP { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_55_SUP3_ADDR1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_55_SUP3_POSTAL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_56_SUP3_ADDR2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_56_SUP3_HOMETEL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_56_SUP3_ST { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_57_SUP3_ADDR3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_57_SUP3_WRKTEL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NCA_58_SUP3_CITY { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_58_SUP3_HPHONE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_59_SUP3_EMPLOYER { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_60_SUP3_MOTHER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_60_SUP3_INCOME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_61_SUP4_CRDNBR1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_61_SUP4_CRDNBR2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_61_SUP4_REL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_61_SUP4_BDTE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_62_SUP4_IC_PP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_62_SUP4_ADDRTYP { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_62_SUP4_ADDR1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_62_SUP4_POSTAL { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_63_SUP4_ADDR2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_63_SUP4_HOMETEL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NCA_63_SUP4_ST { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_64_SUP4_ADDR3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_64_SUP4_WRKTEL { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NCA_65_SUP4_CITY { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NCA_65_SUP4_HPHONE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_66_SUP4_EMPLOYER { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NCA_67_SUP4_MOTHER { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NCA_67_SUP4_INCOME { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NC_23_ADDL_ADDR_4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NC_23_CRLINE_USG { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NC_23_CORP_FLAG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_23_CORP_BATCHDATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NC_23_CUST_FLAG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NC_23_CUST_BATCHDATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IS_GENERATE { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? IS_INSTANT { get; set; }
}

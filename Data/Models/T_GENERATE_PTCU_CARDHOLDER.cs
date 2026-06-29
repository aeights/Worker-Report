using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Worker_Report.Data.Models;

[Index("APPID", "M_ACCOUNT", Name = "T_GENERATE_PTCU_CARDHOLDER_UNIQUE", IsUnique = true)]
public partial class T_GENERATE_PTCU_CARDHOLDER
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

    [StringLength(1)]
    [Unicode(false)]
    public string? M_REC_TYPE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? M_ORG { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? M_TYPE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? M_ACCOUNT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? M_FILE { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? M_JULIAN { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? M_TIME { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? M_TRANS { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? M_TERMINAL_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? M_SIGNON_NAME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? M_SOURCE_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NH_01_ALPHA_KEY { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NH_01_DUP_STMT_ORG { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NH_01_DUP_STMT_NBR { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? NH_01_DUP_STMT_EXPIRY { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_01_CREDIT_LIMIT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_01_FIRST_USG_FLAG { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_01_BLOCK_RSN_CODE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NH_02_CUST_ORG { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NH_02_CUST { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NH_02_ALT_CUST_ORG { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NH_02_ALT_CUST_NBR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_02_CASH_ADV_LIMIT { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? NH_02_ALT_CUST_EXPIRE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_02_AUTH_TOL_GRP { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_03_CYCLE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_03_STMT_FREQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_03_NEXT_STMT_DATE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NH_03_OFFICER { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? NH_03_AGENT_BANK { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? NH_03_BRANCH_NBR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_03_BLOCK_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_03_ALT_BLOCK_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_03_STATUS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_03_PAYMENT_TYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_03_FIXED_PAYMENT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_03_SHORT_NAME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_04_ACH_FLAG { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? NH_04_ACH_BANK { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NH_04_ACH_ACCT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_04_OWNERSHIP_FLAG { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_04_COLLATERAL_CODE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NH_04_CORP_ACCT { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NH_04_CORP_ACCT_ORG { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? NH_04_EP_PIN_RETRIES_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_05_DATE_OPENED { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_05_DATE_CLOSED { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? NH_05_WARN_BULLETIN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_05_DATE_USER1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_05_DATE_USER2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_05_DATE_CARD_FEE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_05_1098_FLAG { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_05_PIN_RETRIES { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NH_05_PIN_CURR_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_05_ICL_COUNTER { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_06_USER_CODE_1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_06_USER_CODE_2 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_06_USER_CODE_3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_06_INSURANCE_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_06_STATEMENT_FLAG { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_06_DISPLAY_REQUEST { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_06_BONUS_BUCKS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_06_BONUS_USED { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_06_COLL_CARD_REQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_06_HIGH_BALANCE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_06_TABLE_HIGH_BAL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_06_PREPAID_AMT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_07_EMBOSS_NAME_1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_07_EMBOSS_ACTION_1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_07_EMBOSS_REQ_1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_07_EMBOSS_TYPE_1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_07_EMBOSS_OUT_1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_07_EMBOSS_RET_1 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_07_EMBOSS_RQTYPE_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_08_EMBOSS_NAME_2 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_08_EMBOSS_ACTION_2 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_08_EMBOSS_REQ_2 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_08_EMBOSS_TYPE_2 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_08_EMBOSS_OUT_2 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_08_EMBOSS_RET_2 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_08_EMBOSS_RQTYPE_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_09_EMBOSS_NAME_3 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_09_EMBOSS_ACTION_3 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_09_EMBOSS_REQ_3 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_09_EMBOSS_TYPE_3 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_09_EMBOSS_OUT_3 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_09_EMBOSS_RET_3 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_09_EMBOSS_RQTYPE_3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_10_EMBOSS_NAME_4 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_10_EMBOSS_ACTION_4 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_10_EMBOSS_REQ_4 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_10_EMBOSS_TYPE_4 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_10_EMBOSS_OUT_4 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_10_EMBOSS_RET_4 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_10_EMBOSS_RQTYPE_4 { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NH_11_CHECKING_ACCT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_11_USER_ACCT { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NH_11_PHOTO_CODE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NH_12_SAVINGS_ACCT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_12_PIN_OFFSET_FLAG { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? NH_12_CARD_EXPIRES { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_12_AFFINITY_GROUP { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_12_DELQ_HIST { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_12_REAGE_REQUEST { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_12_OFFLINE_BLOCK { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_13_CURR_DUE_AMT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_13_PAST_DUE_AMT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_13_30_DELQ_AMT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_13_60_DELQ_AMT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_13_90_DELQ_AMT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_14_120_DELQ_AMT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_14_150_DELQ_AMT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_14_180_DELQ_AMT { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_14_210_DELQ_AMT { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_15_PAST_DUE_TIMES { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_15_30_DELQ_TIMES { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_15_60_DELQ_TIMES { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_15_90_DELQ_TIMES { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_15_120_DELQ_TIMES { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_15_150_DELQ_TIMES { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_15_180_DELQ_TIMES { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_15_210_DELQ_TIMES { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_16_PERM_COLLECTOR { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_16_CURR_COLLECTOR { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_16_DATE_INTO_COLL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_16_REASON_INTO_COLL { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_16_NBR_RETURNED_CHECKS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_16_DATE_LAST_RET_CHECK { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_16_SOURCE_GIFT_CODE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_ANNUAL_FEES { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_TRANSFER_ACCT_NBR { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_DATE_TRANSFER_EFF { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_RTL_INT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_CASH_INT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_LATE_CHGS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_LATE_NOTICES { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_OVERLIMIT_CHGS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_SERVICES_CHGS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_PREPAY { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_17_WAIVE_JOINING_FEE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_POT_SELECT_CODE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_POT_EXP_DATE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_PEND_POT_SELECT_CODE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_PEND_POT_EXP_DATE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_RTL_RATE_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_RTL_LIMIT_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_RTL_RATE_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_RTL_PR_SIGN_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_RTL_ADJ_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_RTL_PR_SIGN_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_RTL_ADJ_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_18_RTL_RATE_CHG_FLAG { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_19_RTL_RATE_3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_19_RTL_LIMIT_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_19_RTL_PR_SIGN_3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_19_RTL_ADJ_3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_19_R_YTD_INT_PAID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_19_R_LST_YTD_INT_PAID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_20_CASH_RATE_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_20_CASH_LIMIT_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_20_CASH_RATE_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_20_CASH_PR_SIGN_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_20_CASH_ADJ_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_20_CASH_PR_SIGN_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_20_CASH_ADJ_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_20_CASH_RATE_CHG_FLAG { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_21_CASH_RATE_3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_21_CASH_LIMIT_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_21_CASH_PR_SIGN_3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_21_CASH_ADJ_3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_21_C_YTD_INT_PAID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_21_C_LST_YTD_INT_PAID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_22_EXCPT_CODE_DATA { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_22_EXCEPTION_PURGE_DATE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_22_CHGOFF_STATUS_FLAG { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_22_DTE_CHGOFF_STAT_CHG { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_22_CHGOFF_RSN_CD_1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_22_CHGOFF_RSN_CD_2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_23_MULTIPLE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_23_PLN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_23_CH_TYPE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_23_CLASS { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_23_SHADOW_LIMIT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_24_CRLIMIT { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_24_CRLIMIT_PERM { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_24_CRLIMIT_TEMP { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_24_CRLIMIT_TEMP_EFF_DTE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_24_CRLIMIT_TEMP_EXP_DTE { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? NH_24_CASH_LIMIT { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_26_POSTING_FLAG { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NH_26_POSTING_ORGN { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? NH_26_POSTING_TYPE { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? NH_26_POSTING_ACCT_NMBR { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_81_INSURED_DOB { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_81_COINSURED_DOB { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_82_PRODUCT_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_82_POLICY_STATUS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? NH_82_CANCEL_CODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_82_EFFECT_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_82_LAST_CLAIM_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_82_CANCEL_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_82_REINST_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_82_PREMIUM_AMT { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_82_USER_CODE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? NH_88_PRODUCT_DESC { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? NH_88_REPAY_TERM { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? NH_88_INT_FREE_SETTL { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_88_FIRST_INST_DATE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_88_INT_FREE_PERIOD { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? NH_88_BATCH_CARD_FLAG { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NH_88_BATCH_CARD_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IS_GENERATE { get; set; } = null!;
}

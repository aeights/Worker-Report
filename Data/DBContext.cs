using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Worker_Report.Data.Models;

namespace Worker_Report.Data;

public partial class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<APPINSTANCE> APPINSTANCE { get; set; }

    public virtual DbSet<BACKUP_WAKTUDE> BACKUP_WAKTUDE { get; set; }

    public virtual DbSet<BIDANG_USAHA> BIDANG_USAHA { get; set; }

    public virtual DbSet<BIN_MASTER> BIN_MASTER { get; set; }

    public virtual DbSet<CARD> CARD { get; set; }

    public virtual DbSet<CARD_COUNTER> CARD_COUNTER { get; set; }

    public virtual DbSet<CARD_HISTORY> CARD_HISTORY { get; set; }

    public virtual DbSet<CARD_MASTER> CARD_MASTER { get; set; }

    public virtual DbSet<CC_ACCOUNT> CC_ACCOUNT { get; set; }

    public virtual DbSet<CHANGEDLOGO> CHANGEDLOGO { get; set; }

    public virtual DbSet<CORPORATE_CUSTOMER> CORPORATE_CUSTOMER { get; set; }

    public virtual DbSet<COUNTERENGINE> COUNTERENGINE { get; set; }

    public virtual DbSet<COUNTER_ENGINE> COUNTER_ENGINE { get; set; }

    public virtual DbSet<CUSTOMERS> CUSTOMERS { get; set; }

    public virtual DbSet<CUST_NO_COUNTER> CUST_NO_COUNTER { get; set; }

    public virtual DbSet<CUST_NO_MASTER> CUST_NO_MASTER { get; set; }

    public virtual DbSet<DECLINECODE> DECLINECODE { get; set; }

    public virtual DbSet<DECLINECODE_DETAIL> DECLINECODE_DETAIL { get; set; }

    public virtual DbSet<EMAILTEMPLATES> EMAILTEMPLATES { get; set; }

    public virtual DbSet<ENTRYFIELD> ENTRYFIELD { get; set; }

    public virtual DbSet<GENERATE_PTCU_HISTORY> GENERATE_PTCU_HISTORY { get; set; }

    public virtual DbSet<GENERATE_PTCU_LOG> GENERATE_PTCU_LOG { get; set; }

    public virtual DbSet<HARI_LIBUR> HARI_LIBUR { get; set; }

    public virtual DbSet<JENIS_PERUSAHAAN> JENIS_PERUSAHAAN { get; set; }

    public virtual DbSet<KRITERIA_APLIKASI> KRITERIA_APLIKASI { get; set; }

    public virtual DbSet<KRITERIA_KIRIMKARTU> KRITERIA_KIRIMKARTU { get; set; }

    public virtual DbSet<KRITERIA_PROSES> KRITERIA_PROSES { get; set; }

    public virtual DbSet<LOGO> LOGO { get; set; }

    public virtual DbSet<MASTERDATA_DARURAT> MASTERDATA_DARURAT { get; set; }

    public virtual DbSet<MASTERDATA_KORESPONDEN> MASTERDATA_KORESPONDEN { get; set; }

    public virtual DbSet<MASTERDATA_MISC> MASTERDATA_MISC { get; set; }

    public virtual DbSet<MASTERDATA_OPERATOR> MASTERDATA_OPERATOR { get; set; }

    public virtual DbSet<MASTERDATA_OPERATORERROR> MASTERDATA_OPERATORERROR { get; set; }

    public virtual DbSet<MASTERDATA_OPERATOR_OLD> MASTERDATA_OPERATOR_OLD { get; set; }

    public virtual DbSet<MASTERDATA_OTHERCARD> MASTERDATA_OTHERCARD { get; set; }

    public virtual DbSet<MASTERDATA_PEKERJAAN> MASTERDATA_PEKERJAAN { get; set; }

    public virtual DbSet<MASTERDATA_PRIBADI> MASTERDATA_PRIBADI { get; set; }

    public virtual DbSet<MASTERDATA_PSDOKUMEN> MASTERDATA_PSDOKUMEN { get; set; }

    public virtual DbSet<MASTERDATA_QUESTION> MASTERDATA_QUESTION { get; set; }

    public virtual DbSet<MASTERDATA_QUESTION_ANSWER> MASTERDATA_QUESTION_ANSWER { get; set; }

    public virtual DbSet<MASTERDATA_RECONTEST> MASTERDATA_RECONTEST { get; set; }

    public virtual DbSet<MASTERDATA_STATUS> MASTERDATA_STATUS { get; set; }

    public virtual DbSet<MASTERDATA_SYSTEM> MASTERDATA_SYSTEM { get; set; }

    public virtual DbSet<MASTER_DATA> MASTER_DATA { get; set; }

    public virtual DbSet<MEMO> MEMO { get; set; }

    public virtual DbSet<MST_ADDONMISC> MST_ADDONMISC { get; set; }

    public virtual DbSet<OPERATOR_LEVEL> OPERATOR_LEVEL { get; set; }

    public virtual DbSet<OPERATOR_ONLINE> OPERATOR_ONLINE { get; set; }

    public virtual DbSet<OPERATOR_USER> OPERATOR_USER { get; set; }

    public virtual DbSet<ORG> ORG { get; set; }

    public virtual DbSet<PARAMETERLOGOFIELD> PARAMETERLOGOFIELD { get; set; }

    public virtual DbSet<PARAMETERSCORING> PARAMETERSCORING { get; set; }

    public virtual DbSet<PARAMETERSCORINGMASTER> PARAMETERSCORINGMASTER { get; set; }

    public virtual DbSet<PARAMETER_SYSTEM> PARAMETER_SYSTEM { get; set; }

    public virtual DbSet<PDLR_CRITERIA> PDLR_CRITERIA { get; set; }

    public virtual DbSet<PEKERJAAN> PEKERJAAN { get; set; }

    public virtual DbSet<PENDIDIKANTERAKHIR> PENDIDIKANTERAKHIR { get; set; }

    public virtual DbSet<PROC_GENREGNO> PROC_GENREGNO { get; set; }

    public virtual DbSet<RECONTRACKDEDUP> RECONTRACKDEDUP { get; set; }

    public virtual DbSet<REGISTEREDAPPID> REGISTEREDAPPID { get; set; }

    public virtual DbSet<RF_AGENT> RF_AGENT { get; set; }

    public virtual DbSet<RF_ANSWER_OPTION> RF_ANSWER_OPTION { get; set; }

    public virtual DbSet<RF_AUDIT_CONFIG> RF_AUDIT_CONFIG { get; set; }

    public virtual DbSet<RF_AUTODISTRIBUTION> RF_AUTODISTRIBUTION { get; set; }

    public virtual DbSet<RF_CHANNEL> RF_CHANNEL { get; set; }

    public virtual DbSet<RF_CHKERROR> RF_CHKERROR { get; set; }

    public virtual DbSet<RF_CHKIMPACT> RF_CHKIMPACT { get; set; }

    public virtual DbSet<RF_COBRAND_GARUDA> RF_COBRAND_GARUDA { get; set; }

    public virtual DbSet<RF_DASHBOARD_HIERARCHY> RF_DASHBOARD_HIERARCHY { get; set; }

    public virtual DbSet<RF_DASHBOARD_PERMISSION_MAPPING> RF_DASHBOARD_PERMISSION_MAPPING { get; set; }

    public virtual DbSet<RF_DECLINE_PREFIX_CODE> RF_DECLINE_PREFIX_CODE { get; set; }

    public virtual DbSet<RF_GARUDA_CITY_CODE> RF_GARUDA_CITY_CODE { get; set; }

    public virtual DbSet<RF_GROUP_STAGELIST> RF_GROUP_STAGELIST { get; set; }

    public virtual DbSet<RF_HUB_STATUS_MAPPING> RF_HUB_STATUS_MAPPING { get; set; }

    public virtual DbSet<RF_JENIS_PRODUK> RF_JENIS_PRODUK { get; set; }

    public virtual DbSet<RF_KODE_OUTLET_WILAYAH> RF_KODE_OUTLET_WILAYAH { get; set; }

    public virtual DbSet<RF_MENUS> RF_MENUS { get; set; }

    public virtual DbSet<RF_MENU_ROLES> RF_MENU_ROLES { get; set; }

    public virtual DbSet<RF_PARDEPTPEMINJAM> RF_PARDEPTPEMINJAM { get; set; }

    public virtual DbSet<RF_PRODUCT_MAPPING> RF_PRODUCT_MAPPING { get; set; }

    public virtual DbSet<RF_PROGRAM> RF_PROGRAM { get; set; }

    public virtual DbSet<RF_PSDOKUMEN> RF_PSDOKUMEN { get; set; }

    public virtual DbSet<RF_QUESTION> RF_QUESTION { get; set; }

    public virtual DbSet<RF_QUESTION_VARIABLE> RF_QUESTION_VARIABLE { get; set; }

    public virtual DbSet<RF_REJECT_REASON_CODE> RF_REJECT_REASON_CODE { get; set; }

    public virtual DbSet<RF_ROLE_MENU_PERMISSIONS> RF_ROLE_MENU_PERMISSIONS { get; set; }

    public virtual DbSet<RF_SECTION> RF_SECTION { get; set; }

    public virtual DbSet<RF_STAGELIST> RF_STAGELIST { get; set; }

    public virtual DbSet<RF_STATUS> RF_STATUS { get; set; }

    public virtual DbSet<RF_STATUS_PERKAWINAN> RF_STATUS_PERKAWINAN { get; set; }

    public virtual DbSet<RF_SUB_SECTION> RF_SUB_SECTION { get; set; }

    public virtual DbSet<RF_TIERING_MAPPING> RF_TIERING_MAPPING { get; set; }

    public virtual DbSet<RF_TOB_AGE> RF_TOB_AGE { get; set; }

    public virtual DbSet<RF_TOB_CITIZEN> RF_TOB_CITIZEN { get; set; }

    public virtual DbSet<RF_TOB_CREDIT_LIMIT> RF_TOB_CREDIT_LIMIT { get; set; }

    public virtual DbSet<RF_TOB_CUST> RF_TOB_CUST { get; set; }

    public virtual DbSet<RF_TOB_RISKGRADE> RF_TOB_RISKGRADE { get; set; }

    public virtual DbSet<RF_TOB_TENOR> RF_TOB_TENOR { get; set; }

    public virtual DbSet<RF_UNIT> RF_UNIT { get; set; }

    public virtual DbSet<RF_WORKFLOW> RF_WORKFLOW { get; set; }

    public virtual DbSet<ROLE> ROLE { get; set; }

    public virtual DbSet<ROLE_FIELD_UPDATES> ROLE_FIELD_UPDATES { get; set; }

    public virtual DbSet<ROLE_WORKFLOW_MAPPING> ROLE_WORKFLOW_MAPPING { get; set; }

    public virtual DbSet<SC_USER> SC_USER { get; set; }

    public virtual DbSet<SC_USERFLAG> SC_USERFLAG { get; set; }

    public virtual DbSet<SEGMENT> SEGMENT { get; set; }

    public virtual DbSet<STATUSTEMPATTINGGAL> STATUSTEMPATTINGGAL { get; set; }

    public virtual DbSet<STATUS_KEPEGAWAIAN> STATUS_KEPEGAWAIAN { get; set; }

    public virtual DbSet<STATUS_PEKERJAAN> STATUS_PEKERJAAN { get; set; }

    public virtual DbSet<SYSDIAGRAMS> SYSDIAGRAMS { get; set; }

    public virtual DbSet<TNMST_LOG> TNMST_LOG { get; set; }

    public virtual DbSet<T_AML_RESULT> T_AML_RESULT { get; set; }

    public virtual DbSet<T_APPLICATION_FINTECH> T_APPLICATION_FINTECH { get; set; }

    public virtual DbSet<T_APPLICATION_FINTECH_LOG> T_APPLICATION_FINTECH_LOG { get; set; }

    public virtual DbSet<T_AUDIT> T_AUDIT { get; set; }

    public virtual DbSet<T_CARDLINK_RESPONSE_PTCU> T_CARDLINK_RESPONSE_PTCU { get; set; }

    public virtual DbSet<T_CHANGED_LOGO> T_CHANGED_LOGO { get; set; }

    public virtual DbSet<T_DECISION_HISTORY> T_DECISION_HISTORY { get; set; }

    public virtual DbSet<T_DECISION_PRESCREENING> T_DECISION_PRESCREENING { get; set; }

    public virtual DbSet<T_DEDUPLICATION_RESULT> T_DEDUPLICATION_RESULT { get; set; }

    public virtual DbSet<T_DEDUP_RESULT> T_DEDUP_RESULT { get; set; }

    public virtual DbSet<T_DHN_RESULT> T_DHN_RESULT { get; set; }

    public virtual DbSet<T_DISTRIBUTION_LIST> T_DISTRIBUTION_LIST { get; set; }

    public virtual DbSet<T_DUKCAPIL_RESULT> T_DUKCAPIL_RESULT { get; set; }

    public virtual DbSet<T_EMAIL_RECONTEST> T_EMAIL_RECONTEST { get; set; }

    public virtual DbSet<T_ERROR_RESPONSE_IDEAS> T_ERROR_RESPONSE_IDEAS { get; set; }

    public virtual DbSet<T_FILDOKUMEN> T_FILDOKUMEN { get; set; }

    public virtual DbSet<T_FILE> T_FILE { get; set; }

    public virtual DbSet<T_FILING> T_FILING { get; set; }

    public virtual DbSet<T_FILMEMO> T_FILMEMO { get; set; }

    public virtual DbSet<T_FILPINJAM> T_FILPINJAM { get; set; }

    public virtual DbSet<T_FILRECONTEST> T_FILRECONTEST { get; set; }

    public virtual DbSet<T_GENERATE_PTCU_CARDHOLDER> T_GENERATE_PTCU_CARDHOLDER { get; set; }

    public virtual DbSet<T_GENERATE_PTCU_CUSTOMER> T_GENERATE_PTCU_CUSTOMER { get; set; }

    public virtual DbSet<T_IDEAS_RESULT> T_IDEAS_RESULT { get; set; }

    public virtual DbSet<T_INCOME_VERIFICATION_CHECKING> T_INCOME_VERIFICATION_CHECKING { get; set; }

    public virtual DbSet<T_INCOME_VERIFICATION_RESULT> T_INCOME_VERIFICATION_RESULT { get; set; }

    public virtual DbSet<T_LOGIN_ATTEMPTS> T_LOGIN_ATTEMPTS { get; set; }

    public virtual DbSet<T_PDLRMEMO> T_PDLRMEMO { get; set; }

    public virtual DbSet<T_RESPONSE_GARUDA> T_RESPONSE_GARUDA { get; set; }

    public virtual DbSet<T_RULES_RESULT> T_RULES_RESULT { get; set; }

    public virtual DbSet<T_SCREENING_INQUIRY> T_SCREENING_INQUIRY { get; set; }

    public virtual DbSet<T_SELLDOWN> T_SELLDOWN { get; set; }

    public virtual DbSet<T_SERVICES_HISTORY> T_SERVICES_HISTORY { get; set; }

    public virtual DbSet<T_SLIK_RESULT> T_SLIK_RESULT { get; set; }

    public virtual DbSet<T_SUBMISSIONTELECAPTIVE> T_SUBMISSIONTELECAPTIVE { get; set; }

    public virtual DbSet<T_SUBMISSION_CREDIT> T_SUBMISSION_CREDIT { get; set; }

    public virtual DbSet<T_SUCCESS_RESPONSE_IDEAS> T_SUCCESS_RESPONSE_IDEAS { get; set; }

    public virtual DbSet<T_UPLOAD_EFORM_TEMP> T_UPLOAD_EFORM_TEMP { get; set; }

    public virtual DbSet<T_UPLOAD_EFORM_TEMP_LOG> T_UPLOAD_EFORM_TEMP_LOG { get; set; }

    public virtual DbSet<UPLOAD_HISTORY> UPLOAD_HISTORY { get; set; }

    public virtual DbSet<VW_GENERATE_TEXT_CARDHOLDER> VW_GENERATE_TEXT_CARDHOLDER { get; set; }

    public virtual DbSet<VW_GENERATE_TEXT_CUSTOMERS> VW_GENERATE_TEXT_CUSTOMERS { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("RCTCCOS")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<BIDANG_USAHA>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<BIN_MASTER>(entity =>
        {
            entity.Property(e => e.BIN_ID).ValueGeneratedNever();
            entity.Property(e => e.BIN_NUMBER).IsFixedLength();
        });

        modelBuilder.Entity<CHANGEDLOGO>(entity =>
        {
            entity.Property(e => e.CHANGEDLOGO_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<DECLINECODE>(entity =>
        {
            entity.Property(e => e.ISANALIS).IsFixedLength();
            entity.Property(e => e.ISDEFAULTLETTER).IsFixedLength();
            entity.Property(e => e.ISPS).IsFixedLength();
            entity.Property(e => e.ISVER).IsFixedLength();
            entity.Property(e => e.ROLE).IsFixedLength();
        });

        modelBuilder.Entity<DECLINECODE_DETAIL>(entity =>
        {
            entity.Property(e => e.CREATEDAT).HasDefaultValueSql("SYSTIMESTAMP");
            entity.Property(e => e.ID).ValueGeneratedOnAdd();

            entity.HasOne(d => d.DECLINECODE_FKNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DECLINECODE_DETAIL");
        });

        modelBuilder.Entity<ENTRYFIELD>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<JENIS_PERUSAHAAN>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<KRITERIA_APLIKASI>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.CODE).IsFixedLength();
        });

        modelBuilder.Entity<KRITERIA_KIRIMKARTU>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.CODE).IsFixedLength();
        });

        modelBuilder.Entity<KRITERIA_PROSES>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.CODE).IsFixedLength();
        });

        modelBuilder.Entity<LOGO>(entity =>
        {
            entity.Property(e => e.ISJAMDEPO).HasDefaultValueSql("0 ");
        });

        modelBuilder.Entity<MASTERDATA_KORESPONDEN>(entity =>
        {
            entity.Property(e => e.CALLING_DATE).HasDefaultValueSql("NULL");
            entity.Property(e => e.CALLING_STATUS)
                .HasDefaultValueSql("NULL")
                .IsFixedLength();
            entity.Property(e => e.DELIVERY_TYPE)
                .HasDefaultValueSql("NULL")
                .IsFixedLength();
            entity.Property(e => e.INCOMING_DOC_DATE).HasDefaultValueSql("NULL");
            entity.Property(e => e.INITIAL_STATUS).HasDefaultValueSql("NULL");
            entity.Property(e => e.OUTGOING_DATE).HasDefaultValueSql("NULL");
            entity.Property(e => e.PURPOSE).HasDefaultValueSql("NULL");
            entity.Property(e => e.RETURN_DATE).HasDefaultValueSql("NULL");
            entity.Property(e => e.STATUS)
                .HasDefaultValueSql("NULL")
                .IsFixedLength();
        });

        modelBuilder.Entity<MASTERDATA_OPERATOR>(entity =>
        {
            entity.Property(e => e.SLI_ANALIS)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_ANALIS2)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_ANALIS3)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_ANALIS4)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_CHECKER)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_DE)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_FILING)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_KOR)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_PIMPINANLNC)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_PS)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_QCAPPROVAL)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_QCCHECKER)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_QCMAKER)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_RATING)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_TOTAL)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
            entity.Property(e => e.SLI_VER)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("0");
        });

        modelBuilder.Entity<MASTERDATA_OPERATORERROR>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009450");

            entity.Property(e => e.ROLE)
                .HasDefaultValueSql("''")
                .IsFixedLength();

            entity.HasOne(d => d.CHKERROR_FKNavigation).WithMany(p => p.MASTERDATA_OPERATORERROR).HasConstraintName("FK_OPERATORERROR_CHKERROR");

            entity.HasOne(d => d.CHKIMPACT_FKNavigation).WithMany(p => p.MASTERDATA_OPERATORERROR).HasConstraintName("FK_OPERATORERROR_CHKIMPACT");
        });

        modelBuilder.Entity<MASTERDATA_OPERATOR_OLD>(entity =>
        {
            entity.Property(e => e.MASTERDATAOPERATOR_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<MASTERDATA_OTHERCARD>(entity =>
        {
            entity.HasKey(e => e.MASTERDATAOTHERCARD_ID).HasName("MASTERDATA_OTHERCARD_PK");
        });

        modelBuilder.Entity<MASTERDATA_PEKERJAAN>(entity =>
        {
            entity.Property(e => e.STATUS_KEPEGAWAIAN).HasDefaultValueSql("'PT'");
            entity.Property(e => e.STATUS_PEKERJAAN).HasDefaultValueSql("'ND'");
        });

        modelBuilder.Entity<MASTERDATA_PRIBADI>(entity =>
        {
            entity.Property(e => e.JENISKELAMIN).IsFixedLength();
            entity.Property(e => e.PENDIDIKANAKHIR).IsFixedLength();
            entity.Property(e => e.STATUSRUMAH).IsFixedLength();
        });

        modelBuilder.Entity<MASTERDATA_PSDOKUMEN>(entity =>
        {
            entity.Property(e => e.STATUSAWALDOKUMEN).IsFixedLength();
            entity.Property(e => e.STATUSDOKUMEN).IsFixedLength();
        });

        modelBuilder.Entity<MASTERDATA_QUESTION>(entity =>
        {
            entity.HasOne(d => d.QUESTION).WithMany(p => p.MASTERDATA_QUESTION)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MDQUESTION_RFQUESTION");
        });

        modelBuilder.Entity<MASTERDATA_QUESTION_ANSWER>(entity =>
        {
            entity.HasOne(d => d.MASTERDATA_QUESTION).WithMany(p => p.MASTERDATA_QUESTION_ANSWER)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MDQA_MASTERDATA_QUESTION");
        });

        modelBuilder.Entity<MASTERDATA_RECONTEST>(entity =>
        {
            entity.Property(e => e.RECONTESTOPERATOR).HasDefaultValueSql("NULL");
            entity.Property(e => e.RECONTESTREASON).HasDefaultValueSql("NULL");
            entity.Property(e => e.RECONTESTTIME).HasDefaultValueSql("NULL");
        });

        modelBuilder.Entity<MASTERDATA_STATUS>(entity =>
        {
            entity.Property(e => e.ID).HasDefaultValueSql("SYS_GUID() ");
            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSTIMESTAMP");
        });

        modelBuilder.Entity<MASTERDATA_SYSTEM>(entity =>
        {
            entity.Property(e => e.CARDMAILER).ValueGeneratedOnAdd();
            entity.Property(e => e.EBILLING).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MASTER_DATA>(entity =>
        {
            entity.Property(e => e.ACCNOCHANGELOGO).IsFixedLength();
            entity.Property(e => e.APPROVECODE).IsFixedLength();
            entity.Property(e => e.CORPCUSTNO).IsFixedLength();
            entity.Property(e => e.DECLINELETTER).IsFixedLength();
            entity.Property(e => e.DECLINELETTERTYPE).IsFixedLength();
            entity.Property(e => e.DELEGASIAPPCODE).IsFixedLength();
            entity.Property(e => e.ENTRYTYPE).IsFixedLength();
            entity.Property(e => e.FLAGDISTRIBUSI).IsFixedLength();
            entity.Property(e => e.FRAUDCOUNTER);
            entity.Property(e => e.IDEASCOUNTER);
            entity.Property(e => e.IDEASSCORE);
            entity.Property(e => e.IDEASSTATUS).IsFixedLength();
            entity.Property(e => e.ISBL).IsFixedLength();
            entity.Property(e => e.ISCHANGELOGO).IsFixedLength();
            entity.Property(e => e.ISCHECKED).IsFixedLength();
            entity.Property(e => e.ISCROSSSELL).IsFixedLength();
            entity.Property(e => e.ISDIGIISSUE).IsFixedLength();
            entity.Property(e => e.ISDUPLIKASI).IsFixedLength();
            entity.Property(e => e.ISDUPLIKASIKONV).IsFixedLength();
            entity.Property(e => e.ISFRAUD);
            entity.Property(e => e.ISIDEAS).IsFixedLength();
            entity.Property(e => e.ISOBC).IsFixedLength();
            entity.Property(e => e.ISPRESCREENED).HasDefaultValueSql("0");
            entity.Property(e => e.ISROBOTIC).IsFixedLength();
            entity.Property(e => e.ISSCORE).IsFixedLength();
            entity.Property(e => e.ISSLIK);
            entity.Property(e => e.ISSMDIGIDECISION).IsFixedLength();
            entity.Property(e => e.ISTNMSTSCORE).IsFixedLength();
            entity.Property(e => e.ISURGENT).IsFixedLength();
            entity.Property(e => e.ISVERCHECK);
            entity.Property(e => e.JENISAPLIKASI).IsFixedLength();
            entity.Property(e => e.KORESPONDENREQ);
            entity.Property(e => e.KRITERIAAPLIKASI).IsFixedLength();
            entity.Property(e => e.KRITERIAKIRIM).IsFixedLength();
            entity.Property(e => e.REKOMENDASI).IsFixedLength();
            entity.Property(e => e.REKOMENDASIAPPROVE).IsFixedLength();
            entity.Property(e => e.REKOMENDASILIMIT).HasDefaultValueSql("0");
            entity.Property(e => e.SCORE).HasDefaultValueSql("0");
            entity.Property(e => e.SLIKCOUNTER);
            entity.Property(e => e.SLIKSTATUS).IsFixedLength();
            entity.Property(e => e.STATUSXTERNAL).IsFixedLength();
            entity.Property(e => e.VERCHECKCOUNTER);
            entity.Property(e => e.XSELLCUSTNO).IsFixedLength();
        });

        modelBuilder.Entity<MST_ADDONMISC>(entity =>
        {
            entity.Property(e => e.MSTADDONMISC_PK).ValueGeneratedNever();
        });

        modelBuilder.Entity<OPERATOR_ONLINE>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.DESCRIPTION).IsFixedLength();
        });

        modelBuilder.Entity<OPERATOR_USER>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<PARAMETERSCORING>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<PARAMETERSCORINGMASTER>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.STATUSID).IsFixedLength();
        });

        modelBuilder.Entity<PDLR_CRITERIA>(entity =>
        {
            entity.Property(e => e.FILTER).IsFixedLength();
        });

        modelBuilder.Entity<PEKERJAAN>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<PENDIDIKANTERAKHIR>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<RF_AGENT>(entity =>
        {
            entity.Property(e => e.AGENT_CODE).HasDefaultValueSql("NULL");
            entity.Property(e => e.AGENT_NAME).HasDefaultValueSql("NULL");
            entity.Property(e => e.AGENT_TYPE).HasDefaultValueSql("NULL");
            entity.Property(e => e.EXPIRY_DATE).HasDefaultValueSql("NULL");
            entity.Property(e => e.FEE).HasDefaultValueSql("0");
            entity.Property(e => e.TIME_LIMIT).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<RF_ANSWER_OPTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009897");

            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSTIMESTAMP ");
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1 ");
            entity.Property(e => e.UPDATED_AT).HasDefaultValueSql("SYSTIMESTAMP ");

            entity.HasOne(d => d.QUESTION).WithMany(p => p.RF_ANSWER_OPTION)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OPTION_QUESTION");
        });

        modelBuilder.Entity<RF_CHANNEL>(entity =>
        {
            entity.Property(e => e.ISFINTECH).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<RF_CHKERROR>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009446");
        });

        modelBuilder.Entity<RF_CHKIMPACT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009448");
        });

        modelBuilder.Entity<RF_COBRAND_GARUDA>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009472");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RF_DASHBOARD_HIERARCHY>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1 ");
        });

        modelBuilder.Entity<RF_DASHBOARD_PERMISSION_MAPPING>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("CURRENT_TIMESTAMP");
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1 ");
        });

        modelBuilder.Entity<RF_DECLINE_PREFIX_CODE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_RF_DECLINEPREFIXCODE");
        });

        modelBuilder.Entity<RF_HUB_STATUS_MAPPING>(entity =>
        {
            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        modelBuilder.Entity<RF_JENIS_PRODUK>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<RF_PARDEPTPEMINJAM>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<RF_PSDOKUMEN>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<RF_QUESTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009883");

            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSTIMESTAMP ");
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1 ");
            entity.Property(e => e.IS_REQUIRED).HasDefaultValueSql("1 ");
            entity.Property(e => e.UPDATED_AT).HasDefaultValueSql("SYSTIMESTAMP ");

            entity.HasOne(d => d.PARENT_QUESTION).WithMany(p => p.InversePARENT_QUESTION).HasConstraintName("FK_QUESTION_PARENT");

            entity.HasOne(d => d.SECTION).WithMany(p => p.RF_QUESTION)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QUESTION_SECTION");

            entity.HasOne(d => d.SUB_SECTION).WithMany(p => p.RF_QUESTION).HasConstraintName("FK_QUESTION_SUBSECTION");
        });

        modelBuilder.Entity<RF_QUESTION_VARIABLE>(entity =>
        {
            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("CURRENT_TIMESTAMP ");
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1 ");
            entity.Property(e => e.UPDATED_AT).HasDefaultValueSql("CURRENT_TIMESTAMP ");

            entity.HasOne(d => d.QUESTION).WithMany(p => p.RF_QUESTION_VARIABLE)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RF_QUESTION_VARIABLE_QUESTION");
        });

        modelBuilder.Entity<RF_REJECT_REASON_CODE>(entity =>
        {
            entity.HasKey(e => e.REJECTREASONID).HasName("SYS_C009925");
        });

        modelBuilder.Entity<RF_SECTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009856");

            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSTIMESTAMP ");
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1 ");
            entity.Property(e => e.UPDATED_AT).HasDefaultValueSql("SYSTIMESTAMP ");
        });

        modelBuilder.Entity<RF_STATUS>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009496");
        });

        modelBuilder.Entity<RF_STATUS_PERKAWINAN>(entity =>
        {
            entity.HasKey(e => e.STATUS_CODE).HasName("SYS_C009667");

            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSDATE");
        });

        modelBuilder.Entity<RF_SUB_SECTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009867");

            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSTIMESTAMP ");
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1 ");
            entity.Property(e => e.UPDATED_AT).HasDefaultValueSql("SYSTIMESTAMP ");

            entity.HasOne(d => d.SECTION).WithMany(p => p.RF_SUB_SECTION)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUBSECTION_SECTION");
        });

        modelBuilder.Entity<RF_TIERING_MAPPING>(entity =>
        {
            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("CURRENT_TIMESTAMP ");
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1 ");

            entity.HasOne(d => d.PROPOSE_TONavigation).WithMany(p => p.InversePROPOSE_TONavigation).HasConstraintName("FK_TIERING_MAPPING_PROPOSE_TO");
        });

        modelBuilder.Entity<RF_TOB_AGE>(entity =>
        {
            entity.HasKey(e => e.CHANNELID).HasName("RF_TOB_AGE");
        });

        modelBuilder.Entity<RF_TOB_CITIZEN>(entity =>
        {
            entity.HasKey(e => e.CHANNELID).HasName("RF_TOB_CITIZEN");
        });

        modelBuilder.Entity<RF_TOB_CREDIT_LIMIT>(entity =>
        {
            entity.HasKey(e => e.CHANNELID).HasName("RF_TOB_CREDIT_LIMIT");
        });

        modelBuilder.Entity<RF_TOB_CUST>(entity =>
        {
            entity.HasKey(e => e.CHANNELID).HasName("RF_TOB_CUST");
        });

        modelBuilder.Entity<RF_TOB_RISKGRADE>(entity =>
        {
            entity.HasKey(e => e.CHANNELID).HasName("RF_TOB_RISKGRADE");
        });

        modelBuilder.Entity<RF_TOB_TENOR>(entity =>
        {
            entity.HasKey(e => e.CHANNELID).HasName("RF_TOB_TENOR");
        });

        modelBuilder.Entity<RF_UNIT>(entity =>
        {
            entity.HasKey(e => e.UNIT_ID).HasName("PK_RF_RF_UNIT");
        });

        modelBuilder.Entity<RF_WORKFLOW>(entity =>
        {
            entity.Property(e => e.WF_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<ROLE>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<ROLE_FIELD_UPDATES>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009487");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.UPDATE_ORDER).HasDefaultValueSql("1");

            entity.HasOne(d => d.ROLE_MAPPING).WithMany(p => p.ROLE_FIELD_UPDATES)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROLE_FIELD_UPDATES");
        });

        modelBuilder.Entity<ROLE_WORKFLOW_MAPPING>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009481");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.CREATED_DATE).HasDefaultValueSql("CURRENT_TIMESTAMP");
            entity.Property(e => e.IS_ACTIVE).HasDefaultValueSql("1");
        });

        modelBuilder.Entity<SC_USER>(entity =>
        {
            entity.Property(e => e.ISLOCK).HasDefaultValueSql("0");
            entity.Property(e => e.LOGINATTEMPTCOUNT).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<SC_USERFLAG>(entity =>
        {
            entity.Property(e => e.SC_LOGON).IsFixedLength();
            entity.Property(e => e.SC_REVOKE).IsFixedLength();
        });

        modelBuilder.Entity<SEGMENT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009466");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<STATUSTEMPATTINGGAL>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<STATUS_KEPEGAWAIAN>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009454");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<STATUS_PEKERJAAN>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009456");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SYSDIAGRAMS>(entity =>
        {
            entity.Property(e => e.DIAGRAM_ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<T_AML_RESULT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009534");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_APPLICATION_FINTECH_LOG>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("T_APPLICATION_FINTECH_LOG_PK");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.IS_RESOLVED).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<T_CHANGED_LOGO>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C0010058");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_DECISION_PRESCREENING>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009591");

            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSTIMESTAMP");
        });

        modelBuilder.Entity<T_DEDUPLICATION_RESULT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009035");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSDATE");
        });

        modelBuilder.Entity<T_DEDUP_RESULT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009525");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_DHN_RESULT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009531");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_DISTRIBUTION_LIST>(entity =>
        {
            entity.Property(e => e.FLAGSTATUS).IsFixedLength();
        });

        modelBuilder.Entity<T_DUKCAPIL_RESULT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009528");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_EMAIL_RECONTEST>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("T_EMAIL_RECONTEST_PK");

            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.STATUS_EMAIL).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<T_FILDOKUMEN>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
            entity.Property(e => e.FLAGPINJAM).IsFixedLength();
        });

        modelBuilder.Entity<T_FILE>(entity =>
        {
            entity.HasKey(e => e.T_FILE_PK).HasName("T_FILE_PK");

            entity.Property(e => e.BUCKET_NAME).HasDefaultValueSql("NULL ");
            entity.Property(e => e.FILE_NAME).HasDefaultValueSql("NULL");
            entity.Property(e => e.ID).HasDefaultValueSql("NULL");
            entity.Property(e => e.KEY).HasDefaultValueSql("NULL ");
        });

        modelBuilder.Entity<T_FILING>(entity =>
        {
            entity.Property(e => e.ADADOKUMEN).IsFixedLength();
            entity.Property(e => e.FLAGPREEMBOSSED).IsFixedLength();
            entity.Property(e => e.KEPUTUSAN).IsFixedLength();
        });

        modelBuilder.Entity<T_FILPINJAM>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<T_GENERATE_PTCU_CARDHOLDER>(entity =>
        {
            entity.Property(e => e.IS_GENERATE)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength();
        });

        modelBuilder.Entity<T_GENERATE_PTCU_CUSTOMER>(entity =>
        {
            entity.Property(e => e.IS_GENERATE)
                .HasDefaultValueSql("'N' ")
                .IsFixedLength();
        });

        modelBuilder.Entity<T_IDEAS_RESULT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009773");
        });

        modelBuilder.Entity<T_INCOME_VERIFICATION_CHECKING>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_T_INCOME_VERIFICATION");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSDATE");
        });

        modelBuilder.Entity<T_INCOME_VERIFICATION_RESULT>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.CREATED_AT).HasDefaultValueSql("SYSDATE");
        });

        modelBuilder.Entity<T_PDLRMEMO>(entity =>
        {
            entity.Property(e => e.PDLRMEMO).HasDefaultValueSql("'' ");
            entity.Property(e => e.PDLRMEMO_ID).ValueGeneratedOnAdd();
            entity.Property(e => e.UPDATEDBY).HasDefaultValueSql("'' ");
        });

        modelBuilder.Entity<T_RESPONSE_GARUDA>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_T_RESPONSE_GRAUDA");

            entity.Property(e => e.FLAGGING_PENGECEKAN).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<T_RULES_RESULT>(entity =>
        {
            entity.Property(e => e.CHECKING_DATE).HasDefaultValueSql("SYSTIMESTAMP ");
            entity.Property(e => e.FINISH_DATE).HasDefaultValueSql("SYSTIMESTAMP");
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_SCREENING_INQUIRY>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009510");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_SELLDOWN>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C0010060");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_SLIK_RESULT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("SYS_C009537");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<T_SUBMISSION_CREDIT>(entity =>
        {
            entity.Property(e => e.SUBMISSIONCREDITID).ValueGeneratedNever();
        });

        modelBuilder.Entity<T_UPLOAD_EFORM_TEMP>(entity =>
        {
            entity.HasKey(e => e.APP_ID).HasName("T_UPLOAD_EFORM_TEMP_PK");
        });

        modelBuilder.Entity<T_UPLOAD_EFORM_TEMP_LOG>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("T_UPLOAD_EFORM_TEMP_LOG_PK");

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UPLOAD_HISTORY>(entity =>
        {
            entity.Property(e => e.FLAG).IsFixedLength();
        });

        modelBuilder.Entity<VW_GENERATE_TEXT_CARDHOLDER>(entity =>
        {
            entity.ToView("VW_GENERATE_TEXT_CARDHOLDER");

            entity.Property(e => e.M_FILE).IsFixedLength();
            entity.Property(e => e.M_REC_TYPE).IsFixedLength();
            entity.Property(e => e.M_SIGNON_NAME).IsFixedLength();
            entity.Property(e => e.M_SOURCE_CODE).IsFixedLength();
            entity.Property(e => e.M_TERMINAL_ID).IsFixedLength();
            entity.Property(e => e.M_TRANS).IsFixedLength();
            entity.Property(e => e.NH_01_BLOCK_RSN_CODE).IsFixedLength();
            entity.Property(e => e.NH_01_DUP_STMT_EXPIRY).IsFixedLength();
            entity.Property(e => e.NH_01_DUP_STMT_NBR).IsFixedLength();
            entity.Property(e => e.NH_01_DUP_STMT_ORG).IsFixedLength();
            entity.Property(e => e.NH_01_FIRST_USG_FLAG).IsFixedLength();
            entity.Property(e => e.NH_02_ALT_CUST_EXPIRE).IsFixedLength();
            entity.Property(e => e.NH_02_ALT_CUST_NBR).IsFixedLength();
            entity.Property(e => e.NH_02_ALT_CUST_ORG).IsFixedLength();
            entity.Property(e => e.NH_02_AUTH_TOL_GRP).IsFixedLength();
            entity.Property(e => e.NH_03_AGENT_BANK).IsFixedLength();
            entity.Property(e => e.NH_03_ALT_BLOCK_CODE).IsFixedLength();
            entity.Property(e => e.NH_03_BRANCH_NBR).IsFixedLength();
            entity.Property(e => e.NH_03_FIXED_PAYMENT).IsFixedLength();
            entity.Property(e => e.NH_03_NEXT_STMT_DATE).IsFixedLength();
            entity.Property(e => e.NH_03_OFFICER).IsFixedLength();
            entity.Property(e => e.NH_03_PAYMENT_TYPE).IsFixedLength();
            entity.Property(e => e.NH_03_STATUS).IsFixedLength();
            entity.Property(e => e.NH_03_STMT_FREQ).IsFixedLength();
            entity.Property(e => e.NH_04_ACH_ACCT).IsFixedLength();
            entity.Property(e => e.NH_04_ACH_BANK).IsFixedLength();
            entity.Property(e => e.NH_04_ACH_FLAG).IsFixedLength();
            entity.Property(e => e.NH_04_COLLATERAL_CODE).IsFixedLength();
            entity.Property(e => e.NH_04_CORP_ACCT).IsFixedLength();
            entity.Property(e => e.NH_04_CORP_ACCT_ORG).IsFixedLength();
            entity.Property(e => e.NH_04_EP_PIN_RETRIES_DATE).IsFixedLength();
            entity.Property(e => e.NH_05_1098_FLAG).IsFixedLength();
            entity.Property(e => e.NH_05_DATE_CLOSED).IsFixedLength();
            entity.Property(e => e.NH_05_DATE_USER1).IsFixedLength();
            entity.Property(e => e.NH_05_DATE_USER2).IsFixedLength();
            entity.Property(e => e.NH_05_ICL_COUNTER).IsFixedLength();
            entity.Property(e => e.NH_05_PIN_CURR_CODE).IsFixedLength();
            entity.Property(e => e.NH_05_PIN_RETRIES).IsFixedLength();
            entity.Property(e => e.NH_05_WARN_BULLETIN).IsFixedLength();
            entity.Property(e => e.NH_06_BONUS_BUCKS).IsFixedLength();
            entity.Property(e => e.NH_06_BONUS_USED).IsFixedLength();
            entity.Property(e => e.NH_06_COLL_CARD_REQ).IsFixedLength();
            entity.Property(e => e.NH_06_DISPLAY_REQUEST).IsFixedLength();
            entity.Property(e => e.NH_06_HIGH_BALANCE).IsFixedLength();
            entity.Property(e => e.NH_06_INSURANCE_CODE).IsFixedLength();
            entity.Property(e => e.NH_06_PREPAID_AMT).IsFixedLength();
            entity.Property(e => e.NH_06_STATEMENT_FLAG).IsFixedLength();
            entity.Property(e => e.NH_06_TABLE_HIGH_BAL).IsFixedLength();
            entity.Property(e => e.NH_06_USER_CODE_1).IsFixedLength();
            entity.Property(e => e.NH_06_USER_CODE_2).IsFixedLength();
            entity.Property(e => e.NH_06_USER_CODE_3).IsFixedLength();
            entity.Property(e => e.NH_07_EMBOSS_ACTION_1).IsFixedLength();
            entity.Property(e => e.NH_07_EMBOSS_OUT_1).IsFixedLength();
            entity.Property(e => e.NH_07_EMBOSS_REQ_1).IsFixedLength();
            entity.Property(e => e.NH_07_EMBOSS_RET_1).IsFixedLength();
            entity.Property(e => e.NH_07_EMBOSS_RQTYPE_1).IsFixedLength();
            entity.Property(e => e.NH_07_EMBOSS_TYPE_1).IsFixedLength();
            entity.Property(e => e.NH_08_EMBOSS_ACTION_2).IsFixedLength();
            entity.Property(e => e.NH_08_EMBOSS_NAME_2).IsFixedLength();
            entity.Property(e => e.NH_08_EMBOSS_OUT_2).IsFixedLength();
            entity.Property(e => e.NH_08_EMBOSS_REQ_2).IsFixedLength();
            entity.Property(e => e.NH_08_EMBOSS_RET_2).IsFixedLength();
            entity.Property(e => e.NH_08_EMBOSS_RQTYPE_2).IsFixedLength();
            entity.Property(e => e.NH_08_EMBOSS_TYPE_2).IsFixedLength();
            entity.Property(e => e.NH_09_EMBOSS_ACTION_3).IsFixedLength();
            entity.Property(e => e.NH_09_EMBOSS_NAME_3).IsFixedLength();
            entity.Property(e => e.NH_09_EMBOSS_OUT_3).IsFixedLength();
            entity.Property(e => e.NH_09_EMBOSS_REQ_3).IsFixedLength();
            entity.Property(e => e.NH_09_EMBOSS_RET_3).IsFixedLength();
            entity.Property(e => e.NH_09_EMBOSS_RQTYPE_3).IsFixedLength();
            entity.Property(e => e.NH_09_EMBOSS_TYPE_3).IsFixedLength();
            entity.Property(e => e.NH_10_EMBOSS_ACTION_4).IsFixedLength();
            entity.Property(e => e.NH_10_EMBOSS_OUT_4).IsFixedLength();
            entity.Property(e => e.NH_10_EMBOSS_REQ_4).IsFixedLength();
            entity.Property(e => e.NH_10_EMBOSS_RET_4).IsFixedLength();
            entity.Property(e => e.NH_10_EMBOSS_RQTYPE_4).IsFixedLength();
            entity.Property(e => e.NH_10_EMBOSS_TYPE_4).IsFixedLength();
            entity.Property(e => e.NH_11_CHECKING_ACCT).IsFixedLength();
            entity.Property(e => e.NH_11_PHOTO_CODE).IsFixedLength();
            entity.Property(e => e.NH_12_AFFINITY_GROUP).IsFixedLength();
            entity.Property(e => e.NH_12_DELQ_HIST).IsFixedLength();
            entity.Property(e => e.NH_12_OFFLINE_BLOCK).IsFixedLength();
            entity.Property(e => e.NH_12_PIN_OFFSET_FLAG).IsFixedLength();
            entity.Property(e => e.NH_12_REAGE_REQUEST).IsFixedLength();
            entity.Property(e => e.NH_14_120_DELQ_AMT).IsFixedLength();
            entity.Property(e => e.NH_14_150_DELQ_AMT).IsFixedLength();
            entity.Property(e => e.NH_14_180_DELQ_AMT).IsFixedLength();
            entity.Property(e => e.NH_14_210_DELQ_AMT).IsFixedLength();
            entity.Property(e => e.NH_15_120_DELQ_TIMES).IsFixedLength();
            entity.Property(e => e.NH_15_150_DELQ_TIMES).IsFixedLength();
            entity.Property(e => e.NH_15_180_DELQ_TIMES).IsFixedLength();
            entity.Property(e => e.NH_15_210_DELQ_TIMES).IsFixedLength();
            entity.Property(e => e.NH_15_30_DELQ_TIMES).IsFixedLength();
            entity.Property(e => e.NH_15_60_DELQ_TIMES).IsFixedLength();
            entity.Property(e => e.NH_15_90_DELQ_TIMES).IsFixedLength();
            entity.Property(e => e.NH_15_PAST_DUE_TIMES).IsFixedLength();
            entity.Property(e => e.NH_16_CURR_COLLECTOR).IsFixedLength();
            entity.Property(e => e.NH_16_DATE_INTO_COLL).IsFixedLength();
            entity.Property(e => e.NH_16_DATE_LAST_RET_CHECK).IsFixedLength();
            entity.Property(e => e.NH_16_PERM_COLLECTOR).IsFixedLength();
            entity.Property(e => e.NH_16_REASON_INTO_COLL).IsFixedLength();
            entity.Property(e => e.NH_17_DATE_TRANSFER_EFF).IsFixedLength();
            entity.Property(e => e.NH_17_TRANSFER_ACCT_NBR).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_ANNUAL_FEES).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_CASH_INT).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_JOINING_FEE).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_LATE_CHGS).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_LATE_NOTICES).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_OVERLIMIT_CHGS).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_PREPAY).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_RTL_INT).IsFixedLength();
            entity.Property(e => e.NH_17_WAIVE_SERVICES_CHGS).IsFixedLength();
            entity.Property(e => e.NH_18_PEND_POT_EXP_DATE).IsFixedLength();
            entity.Property(e => e.NH_18_PEND_POT_SELECT_CODE).IsFixedLength();
            entity.Property(e => e.NH_18_POT_EXP_DATE).IsFixedLength();
            entity.Property(e => e.NH_18_POT_SELECT_CODE).IsFixedLength();
            entity.Property(e => e.NH_18_RTL_ADJ_1).IsFixedLength();
            entity.Property(e => e.NH_18_RTL_ADJ_2).IsFixedLength();
            entity.Property(e => e.NH_18_RTL_LIMIT_1).IsFixedLength();
            entity.Property(e => e.NH_18_RTL_PR_SIGN_1).IsFixedLength();
            entity.Property(e => e.NH_18_RTL_PR_SIGN_2).IsFixedLength();
            entity.Property(e => e.NH_18_RTL_RATE_1).IsFixedLength();
            entity.Property(e => e.NH_18_RTL_RATE_2).IsFixedLength();
            entity.Property(e => e.NH_18_RTL_RATE_CHG_FLAG).IsFixedLength();
            entity.Property(e => e.NH_19_RTL_ADJ_3).IsFixedLength();
            entity.Property(e => e.NH_19_RTL_LIMIT_2).IsFixedLength();
            entity.Property(e => e.NH_19_RTL_PR_SIGN_3).IsFixedLength();
            entity.Property(e => e.NH_19_RTL_RATE_3).IsFixedLength();
            entity.Property(e => e.NH_19_R_LST_YTD_INT_PAID).IsFixedLength();
            entity.Property(e => e.NH_19_R_YTD_INT_PAID).IsFixedLength();
            entity.Property(e => e.NH_20_CASH_ADJ_1).IsFixedLength();
            entity.Property(e => e.NH_20_CASH_ADJ_2).IsFixedLength();
            entity.Property(e => e.NH_20_CASH_LIMIT_1).IsFixedLength();
            entity.Property(e => e.NH_20_CASH_PR_SIGN_1).IsFixedLength();
            entity.Property(e => e.NH_20_CASH_PR_SIGN_2).IsFixedLength();
            entity.Property(e => e.NH_20_CASH_RATE_1).IsFixedLength();
            entity.Property(e => e.NH_20_CASH_RATE_2).IsFixedLength();
            entity.Property(e => e.NH_20_CASH_RATE_CHG_FLAG).IsFixedLength();
            entity.Property(e => e.NH_21_CASH_ADJ_3).IsFixedLength();
            entity.Property(e => e.NH_21_CASH_LIMIT_2).IsFixedLength();
            entity.Property(e => e.NH_21_CASH_PR_SIGN_3).IsFixedLength();
            entity.Property(e => e.NH_21_CASH_RATE_3).IsFixedLength();
            entity.Property(e => e.NH_21_C_LST_YTD_INT_PAID).IsFixedLength();
            entity.Property(e => e.NH_21_C_YTD_INT_PAID).IsFixedLength();
            entity.Property(e => e.NH_22_CHGOFF_RSN_CD_1).IsFixedLength();
            entity.Property(e => e.NH_22_CHGOFF_RSN_CD_2).IsFixedLength();
            entity.Property(e => e.NH_22_CHGOFF_STATUS_FLAG).IsFixedLength();
            entity.Property(e => e.NH_22_DTE_CHGOFF_STAT_CHG).IsFixedLength();
            entity.Property(e => e.NH_22_EXCEPTION_PURGE_DATE).IsFixedLength();
            entity.Property(e => e.NH_22_EXCPT_CODE_DATA).IsFixedLength();
            entity.Property(e => e.NH_23_CH_TYPE).IsFixedLength();
            entity.Property(e => e.NH_23_CLASS).IsFixedLength();
            entity.Property(e => e.NH_23_MULTIPLE).IsFixedLength();
            entity.Property(e => e.NH_23_PLN).IsFixedLength();
            entity.Property(e => e.NH_23_SHADOW_LIMIT).IsFixedLength();
            entity.Property(e => e.NH_24_CRLIMIT_TEMP_EFF_DTE).IsFixedLength();
            entity.Property(e => e.NH_24_CRLIMIT_TEMP_EXP_DTE).IsFixedLength();
            entity.Property(e => e.NH_26_POSTING_FLAG).IsFixedLength();
            entity.Property(e => e.NH_81_COINSURED_DOB).IsFixedLength();
            entity.Property(e => e.NH_82_CANCEL_CODE).IsFixedLength();
            entity.Property(e => e.NH_82_CANCEL_DATE).IsFixedLength();
            entity.Property(e => e.NH_82_LAST_CLAIM_DATE).IsFixedLength();
            entity.Property(e => e.NH_82_POLICY_STATUS).IsFixedLength();
            entity.Property(e => e.NH_82_REINST_DATE).IsFixedLength();
            entity.Property(e => e.NH_82_USER_CODE).IsFixedLength();
            entity.Property(e => e.NH_88_FIRST_INST_DATE).IsFixedLength();
            entity.Property(e => e.NH_88_INT_FREE_PERIOD).IsFixedLength();
            entity.Property(e => e.NH_88_INT_FREE_SETTL).IsFixedLength();
            entity.Property(e => e.NH_88_PRODUCT_DESC).IsFixedLength();
            entity.Property(e => e.NH_88_REPAY_TERM).IsFixedLength();
        });

        modelBuilder.Entity<VW_GENERATE_TEXT_CUSTOMERS>(entity =>
        {
            entity.ToView("VW_GENERATE_TEXT_CUSTOMERS");

            entity.Property(e => e.M_FILE_TYPE).IsFixedLength();
            entity.Property(e => e.M_REC_TYPE).IsFixedLength();
            entity.Property(e => e.M_SOURCE_CODE).IsFixedLength();
            entity.Property(e => e.M_TRANS).IsFixedLength();
            entity.Property(e => e.M_TYPE).IsFixedLength();
            entity.Property(e => e.NC_01_REGULER_CUST).IsFixedLength();
            entity.Property(e => e.NC_06_MBR_SINCE).IsFixedLength();
            entity.Property(e => e.NC_07_CO_BIRTH_DATE).IsFixedLength();
            entity.Property(e => e.NC_07_CO_TAX_ID_FLAG).IsFixedLength();
            entity.Property(e => e.NC_07_TAX_ID_FLAG).IsFixedLength();
            entity.Property(e => e.NC_08_WORK_PHONE_FLAG).IsFixedLength();
            entity.Property(e => e.NC_12_STATUS).IsFixedLength();
            entity.Property(e => e.NC_15_CRT_LIABLE).IsFixedLength();
            entity.Property(e => e.NC_15_EU_BANK_ACCT_IND).IsFixedLength();
            entity.Property(e => e.NC_15_EU_BEHAV_SCORE).IsFixedLength();
            entity.Property(e => e.NC_15_EU_DIRECT_MAIL).IsFixedLength();
            entity.Property(e => e.NC_15_EU_STATUS).IsFixedLength();
            entity.Property(e => e.NC_16_CRLINE_TEMP_EFF_DTE).IsFixedLength();
            entity.Property(e => e.NC_16_CRLINE_TEMP_EXP_DTE).IsFixedLength();
            entity.Property(e => e.NC_17_ADDL_EXP_DATE).IsFixedLength();
            entity.Property(e => e.NC_21_SUBMIT_DTE).IsFixedLength();
            entity.Property(e => e.NC_21_USR_DEF2).IsFixedLength();
        });
        modelBuilder.HasSequence("SEQ_T_APPLICATION_FINTECH_LOG");
        modelBuilder.HasSequence("SEQ_T_UPLOAD_EFORM_TEMP_LOG");
        modelBuilder.HasSequence("SEQUENCE_CARD");
        modelBuilder.HasSequence("SEQUENCE_CARD_COUNTER");
        modelBuilder.HasSequence("SEQUENCE_CARD_HISTORY");
        modelBuilder.HasSequence("SEQUENCE_CARD_MASTER");
        modelBuilder.HasSequence("SEQUENCE_CARDS");
        modelBuilder.HasSequence("SEQUENCE_CC_ACCOUNT");
        modelBuilder.HasSequence("SEQUENCE_CORPORATE_CUSTOMER");
        modelBuilder.HasSequence("SEQUENCE_CUST_NO_COUNTER");
        modelBuilder.HasSequence("SEQUENCE_CUST_NO_MASTER");
        modelBuilder.HasSequence("SEQUENCE_CUSTOMERS");
        modelBuilder.HasSequence("SEQUENCE_DECLINECODE");
        modelBuilder.HasSequence("SEQUENCE_EMAILTEMPLATES");
        modelBuilder.HasSequence("SEQUENCE_ENTRYFIELD");
        modelBuilder.HasSequence("SEQUENCE_GENERATE_PTCU_HISTORY");
        modelBuilder.HasSequence("SEQUENCE_GENERATE_PTCU_LOG");
        modelBuilder.HasSequence("SEQUENCE_HARI_LIBUR");
        modelBuilder.HasSequence("SEQUENCE_LOGO");
        modelBuilder.HasSequence("SEQUENCE_MASTER_ADD_ON_MISC");
        modelBuilder.HasSequence("SEQUENCE_MASTER_DATA");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_DARURAT");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_KORESPONDEN");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_MISC");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_OPERATOR");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_OTHERCARD");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_PEKERJAAN");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_PRIBADI");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_PSDOKUMEN");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_RECONTEST");
        modelBuilder.HasSequence("SEQUENCE_MASTERDATA_SYSTEM");
        modelBuilder.HasSequence("SEQUENCE_MEMO");
        modelBuilder.HasSequence("SEQUENCE_OPERATOR_LEVEL");
        modelBuilder.HasSequence("SEQUENCE_OPERATOR_USER");
        modelBuilder.HasSequence("SEQUENCE_ORG");
        modelBuilder.HasSequence("SEQUENCE_PARAMETERLOGOFIELD");
        modelBuilder.HasSequence("SEQUENCE_RF_DASHBOARD_PERMISSION_MAPPING");
        modelBuilder.HasSequence("SEQUENCE_RF_DECLINEPREFIXCODE");
        modelBuilder.HasSequence("SEQUENCE_RF_HUB_STATUS_MAPPING");
        modelBuilder.HasSequence("SEQUENCE_RF_MENUS");
        modelBuilder.HasSequence("SEQUENCE_RF_ROLE_MENU_PERMISSIONS");
        modelBuilder.HasSequence("SEQUENCE_T_APPLICATION_FINTECH_LOG");
        modelBuilder.HasSequence("SEQUENCE_T_AUDIT");
        modelBuilder.HasSequence("SEQUENCE_T_CARDLINK_RESPONSE_PTCU");
        modelBuilder.HasSequence("SEQUENCE_T_DECISION_PRESCREENING");
        modelBuilder.HasSequence("SEQUENCE_T_ERROR_RESPONSE_IDEAS");
        modelBuilder.HasSequence("SEQUENCE_T_FILING");
        modelBuilder.HasSequence("SEQUENCE_T_FILMEMO");
        modelBuilder.HasSequence("SEQUENCE_T_FILRECONTEST");
        modelBuilder.HasSequence("SEQUENCE_T_GENERATE_PTCU_CARDHOLDER");
        modelBuilder.HasSequence("SEQUENCE_T_GENERATE_PTCU_CUSTOMER");
        modelBuilder.HasSequence("SEQUENCE_T_LOGIN_ATTEMPTS");
        modelBuilder.HasSequence("SEQUENCE_T_SUBMISSIONTELECAPTIVE");
        modelBuilder.HasSequence("SEQUENCE_T_SUCCESS_RESPONSE_IDEAS");
        modelBuilder.HasSequence("SEQUENCE_T_UPLOAD_EFORM_TEMP_LOG");
        modelBuilder.HasSequence("SEQUENCE_TABLE_ACCOUNT");
        modelBuilder.HasSequence("SEQUENCE_TABLE_CARD");
        modelBuilder.HasSequence("SEQUENCE_TABLE_CUSTOMER");
        modelBuilder.HasSequence("SEQUENCE_TABLE_PARAMETER_SYSTEM");
        modelBuilder.HasSequence("SEQUENCE_TABLE_PDLR_CRITERIA");
        modelBuilder.HasSequence("SEQUENCE_TNMST_LOG");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

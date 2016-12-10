using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KUP.Authentication.Data.Models
{
    public partial class UniversityPortal_KVUContext : DbContext
    {
        public virtual DbSet<AccountProvisioningProgramVersion> AccountProvisioningProgramVersion { get; set; }
        public virtual DbSet<ActivityStreamSsislogs> ActivityStreamSsislogs { get; set; }
        public virtual DbSet<AdAuthenticationDomain> AdAuthenticationDomain { get; set; }
        public virtual DbSet<AdminAccountProvisioning> AdminAccountProvisioning { get; set; }
        public virtual DbSet<AttendancePostingMethod> AttendancePostingMethod { get; set; }
        public virtual DbSet<AttendancePostingMethodType> AttendancePostingMethodType { get; set; }
        public virtual DbSet<AuthenticationType> AuthenticationType { get; set; }
        public virtual DbSet<BadgevillePlayer> BadgevillePlayer { get; set; }
        public virtual DbSet<BadgevilleSite> BadgevilleSite { get; set; }
        public virtual DbSet<BadgevilleUser> BadgevilleUser { get; set; }
        public virtual DbSet<CmsAsset> CmsAsset { get; set; }
        public virtual DbSet<CmsContentBlock> CmsContentBlock { get; set; }
        public virtual DbSet<CmsContentBlockAudience> CmsContentBlockAudience { get; set; }
        public virtual DbSet<CmsContentBlockAudienceCultureXhtml> CmsContentBlockAudienceCultureXhtml { get; set; }
        public virtual DbSet<CmsContentBlockAudienceCultureXhtmlversion> CmsContentBlockAudienceCultureXhtmlversion { get; set; }
        public virtual DbSet<CmsContentScheduleEntry> CmsContentScheduleEntry { get; set; }
        public virtual DbSet<CmsContentScheduleEntryVersion> CmsContentScheduleEntryVersion { get; set; }
        public virtual DbSet<CmsCultureCode> CmsCultureCode { get; set; }
        public virtual DbSet<CmsEditSession> CmsEditSession { get; set; }
        public virtual DbSet<CmsPage> CmsPage { get; set; }
        public virtual DbSet<CmsPageScheduleEntry> CmsPageScheduleEntry { get; set; }
        public virtual DbSet<CmsPageScheduleEntryVersion> CmsPageScheduleEntryVersion { get; set; }
        public virtual DbSet<CmsPhysicalPageContentAreaCache> CmsPhysicalPageContentAreaCache { get; set; }
        public virtual DbSet<CmsProject> CmsProject { get; set; }
        public virtual DbSet<CmsSiteMapNode> CmsSiteMapNode { get; set; }
        public virtual DbSet<CmsSiteMapNodeVersion> CmsSiteMapNodeVersion { get; set; }
        public virtual DbSet<CmsSiteMapNodeVersionMetadata> CmsSiteMapNodeVersionMetadata { get; set; }
        public virtual DbSet<CmsSystem> CmsSystem { get; set; }
        public virtual DbSet<CmsTemplatePage> CmsTemplatePage { get; set; }
        public virtual DbSet<CmsVirtualPage> CmsVirtualPage { get; set; }
        public virtual DbSet<CmsVirtualPageContentAreaCache> CmsVirtualPageContentAreaCache { get; set; }
        public virtual DbSet<CmsVirtualPageVersion> CmsVirtualPageVersion { get; set; }
        public virtual DbSet<CmswfContentBlockAudienceCultureXhtmlversionApprovalState> CmswfContentBlockAudienceCultureXhtmlversionApprovalState { get; set; }
        public virtual DbSet<CmswfContentScheduleEntryVersionApprovalState> CmswfContentScheduleEntryVersionApprovalState { get; set; }
        public virtual DbSet<CmswfPageScheduleEntryVersionApprovalState> CmswfPageScheduleEntryVersionApprovalState { get; set; }
        public virtual DbSet<CmswfVirtualPageVersionApprovalState> CmswfVirtualPageVersionApprovalState { get; set; }
        public virtual DbSet<CmxActivityFromEventConfig> CmxActivityFromEventConfig { get; set; }
        public virtual DbSet<CourseCatalogRequirements> CourseCatalogRequirements { get; set; }
        public virtual DbSet<CourseTutor> CourseTutor { get; set; }
        public virtual DbSet<CvueDatabaseMap> CvueDatabaseMap { get; set; }
        public virtual DbSet<DegreePlanTicket> DegreePlanTicket { get; set; }
        public virtual DbSet<DiagCategory> DiagCategory { get; set; }
        public virtual DbSet<DiagCategoryLog> DiagCategoryLog { get; set; }
        public virtual DbSet<DiagLog> DiagLog { get; set; }
        public virtual DbSet<DiagTraceLog> DiagTraceLog { get; set; }
        public virtual DbSet<DirAffiliation> DirAffiliation { get; set; }
        public virtual DbSet<DirAffiliationType> DirAffiliationType { get; set; }
        public virtual DbSet<DirComplaintType> DirComplaintType { get; set; }
        public virtual DbSet<DirContactRequestStatus> DirContactRequestStatus { get; set; }
        public virtual DbSet<DirCountry> DirCountry { get; set; }
        public virtual DbSet<DirDegreeType> DirDegreeType { get; set; }
        public virtual DbSet<DirEducationHistory> DirEducationHistory { get; set; }
        public virtual DbSet<DirEducationInstitution> DirEducationInstitution { get; set; }
        public virtual DbSet<DirInstitutionType> DirInstitutionType { get; set; }
        public virtual DbSet<DirPrivacySetting> DirPrivacySetting { get; set; }
        public virtual DbSet<DirStateProvince> DirStateProvince { get; set; }
        public virtual DbSet<DirTitle> DirTitle { get; set; }
        public virtual DbSet<DirUserAffiliation> DirUserAffiliation { get; set; }
        public virtual DbSet<DirUserComplaint> DirUserComplaint { get; set; }
        public virtual DbSet<DirUserContactRequest> DirUserContactRequest { get; set; }
        public virtual DbSet<DirUserPrivacySetting> DirUserPrivacySetting { get; set; }
        public virtual DbSet<DirUserProfile> DirUserProfile { get; set; }
        public virtual DbSet<DirWorkHistory> DirWorkHistory { get; set; }
        public virtual DbSet<DirZipInfo> DirZipInfo { get; set; }
        public virtual DbSet<DocumentLog> DocumentLog { get; set; }
        public virtual DbSet<ECollegeHomeroomAuditLog> ECollegeHomeroomAuditLog { get; set; }
        public virtual DbSet<ECollegeProgramVersionHomeroom> ECollegeProgramVersionHomeroom { get; set; }
        public virtual DbSet<ECollegeRoles> ECollegeRoles { get; set; }
        public virtual DbSet<EnCommunicationEndpoint> EnCommunicationEndpoint { get; set; }
        public virtual DbSet<EnCommunicationTracking> EnCommunicationTracking { get; set; }
        public virtual DbSet<EnEvent> EnEvent { get; set; }
        public virtual DbSet<EnEventMessageTemplate> EnEventMessageTemplate { get; set; }
        public virtual DbSet<EnEventQueryColumnSchema> EnEventQueryColumnSchema { get; set; }
        public virtual DbSet<EnEventQueryExecutionStateHistory> EnEventQueryExecutionStateHistory { get; set; }
        public virtual DbSet<EnEventStoredProcedure> EnEventStoredProcedure { get; set; }
        public virtual DbSet<EnEventStoredProcedureParameter> EnEventStoredProcedureParameter { get; set; }
        public virtual DbSet<EnSmsprovider> EnSmsprovider { get; set; }
        public virtual DbSet<EnUserContactSettings> EnUserContactSettings { get; set; }
        public virtual DbSet<EnUserEventSubscription> EnUserEventSubscription { get; set; }
        public virtual DbSet<FacultyTutor> FacultyTutor { get; set; }
        public virtual DbSet<Functionality> Functionality { get; set; }
        public virtual DbSet<IdentityVerificationLog> IdentityVerificationLog { get; set; }
        public virtual DbSet<ImImpersonatedView> ImImpersonatedView { get; set; }
        public virtual DbSet<ImImpersonatingView> ImImpersonatingView { get; set; }
        public virtual DbSet<ImImpersonationAudit> ImImpersonationAudit { get; set; }
        public virtual DbSet<InsConcern> InsConcern { get; set; }
        public virtual DbSet<InsConcernStatus> InsConcernStatus { get; set; }
        public virtual DbSet<InsConcernType> InsConcernType { get; set; }
        public virtual DbSet<InsConcernVisualAlert> InsConcernVisualAlert { get; set; }
        public virtual DbSet<InstructorAccountProvisioning> InstructorAccountProvisioning { get; set; }
        public virtual DbSet<LiveHelp> LiveHelp { get; set; }
        public virtual DbSet<LiveHelpBusinessUnit> LiveHelpBusinessUnit { get; set; }
        public virtual DbSet<MilitaryTuitionParentRates> MilitaryTuitionParentRates { get; set; }
        public virtual DbSet<MilitaryTuitionRates> MilitaryTuitionRates { get; set; }
        public virtual DbSet<MilitaryTuitionRatesCdltracking> MilitaryTuitionRatesCdltracking { get; set; }
        public virtual DbSet<OnlineFormsRequest> OnlineFormsRequest { get; set; }
        public virtual DbSet<OnlineFormsRequestStatus> OnlineFormsRequestStatus { get; set; }
        public virtual DbSet<OnlineFormsRequestType> OnlineFormsRequestType { get; set; }
        public virtual DbSet<OrionBusinessUnitTicketType> OrionBusinessUnitTicketType { get; set; }
        public virtual DbSet<OrionEndSystems> OrionEndSystems { get; set; }
        public virtual DbSet<OrionTicketDescription> OrionTicketDescription { get; set; }
        public virtual DbSet<OutcomesReport> OutcomesReport { get; set; }
        public virtual DbSet<OutcomesReportV1> OutcomesReportV1 { get; set; }
        public virtual DbSet<PasswordChangeLog> PasswordChangeLog { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PortalBillingStatementSubscriptions> PortalBillingStatementSubscriptions { get; set; }
        public virtual DbSet<PortalNotification> PortalNotification { get; set; }
        public virtual DbSet<PortalUser> PortalUser { get; set; }
        public virtual DbSet<PortalUserAttribute> PortalUserAttribute { get; set; }
        public virtual DbSet<PortalUserLogin> PortalUserLogin { get; set; }
        public virtual DbSet<PortalUserMapping> PortalUserMapping { get; set; }
        public virtual DbSet<PortalUserMessenger> PortalUserMessenger { get; set; }
        public virtual DbSet<PortalUserMessengerChat> PortalUserMessengerChat { get; set; }
        public virtual DbSet<PortalUserMessengerChatMessage> PortalUserMessengerChatMessage { get; set; }
        public virtual DbSet<PortalUserMessengerChatParticipator> PortalUserMessengerChatParticipator { get; set; }
        public virtual DbSet<PortalUserMessengerSignInLog> PortalUserMessengerSignInLog { get; set; }
        public virtual DbSet<PortalUserRole> PortalUserRole { get; set; }
        public virtual DbSet<PortalUserSystemActionAudit> PortalUserSystemActionAudit { get; set; }
        public virtual DbSet<Presentation> Presentation { get; set; }
        public virtual DbSet<PresentationAnswer> PresentationAnswer { get; set; }
        public virtual DbSet<PresentationAssignment> PresentationAssignment { get; set; }
        public virtual DbSet<PresentationFile> PresentationFile { get; set; }
        public virtual DbSet<PresentationGroupType> PresentationGroupType { get; set; }
        public virtual DbSet<PresentationPresentationFile> PresentationPresentationFile { get; set; }
        public virtual DbSet<PresentationQuestion> PresentationQuestion { get; set; }
        public virtual DbSet<PresentationQuestionAnswer> PresentationQuestionAnswer { get; set; }
        public virtual DbSet<PresentationQuestionType> PresentationQuestionType { get; set; }
        public virtual DbSet<PresentationUserType> PresentationUserType { get; set; }
        public virtual DbSet<PresentationViewLog> PresentationViewLog { get; set; }
        public virtual DbSet<QbInquiry> QbInquiry { get; set; }
        public virtual DbSet<QbInquiryAudit> QbInquiryAudit { get; set; }
        public virtual DbSet<QbInquiryType> QbInquiryType { get; set; }
        public virtual DbSet<QbResponseState> QbResponseState { get; set; }
        public virtual DbSet<QbResponseStatePermission> QbResponseStatePermission { get; set; }
        public virtual DbSet<QbResponseStateTransition> QbResponseStateTransition { get; set; }
        public virtual DbSet<QbSubject> QbSubject { get; set; }
        public virtual DbSet<QbSubjectMatterExpert> QbSubjectMatterExpert { get; set; }
        public virtual DbSet<ReservedUsername> ReservedUsername { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<SelfRegistrationConfiguration> SelfRegistrationConfiguration { get; set; }
        public virtual DbSet<SelfRegistrationSearchPreference> SelfRegistrationSearchPreference { get; set; }
        public virtual DbSet<StudentAccountProvisioning> StudentAccountProvisioning { get; set; }
        public virtual DbSet<StudentAccountProvisioningMapping> StudentAccountProvisioningMapping { get; set; }
        public virtual DbSet<StudentFormsLog> StudentFormsLog { get; set; }
        public virtual DbSet<StudentGradeRequest> StudentGradeRequest { get; set; }
        public virtual DbSet<StudentGradeRequestReason> StudentGradeRequestReason { get; set; }
        public virtual DbSet<StudentGradeRequestReasonType> StudentGradeRequestReasonType { get; set; }
        public virtual DbSet<StudentPlacementExam> StudentPlacementExam { get; set; }
        public virtual DbSet<StudentTutor> StudentTutor { get; set; }
        public virtual DbSet<SystemCheckComponentType> SystemCheckComponentType { get; set; }
        public virtual DbSet<SystemCheckUserStatus> SystemCheckUserStatus { get; set; }
        public virtual DbSet<TranscriptInstitute> TranscriptInstitute { get; set; }
        public virtual DbSet<TranscriptItemCost> TranscriptItemCost { get; set; }
        public virtual DbSet<TranscriptList> TranscriptList { get; set; }
        public virtual DbSet<TranscriptPayment> TranscriptPayment { get; set; }
        public virtual DbSet<TranscriptProcessing> TranscriptProcessing { get; set; }
        public virtual DbSet<TranscriptPurpose> TranscriptPurpose { get; set; }
        public virtual DbSet<TranscriptReceiver> TranscriptReceiver { get; set; }
        public virtual DbSet<TranscriptSession> TranscriptSession { get; set; }
        public virtual DbSet<UserMappingType> UserMappingType { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }
        public virtual DbSet<UserStatusFunctionality> UserStatusFunctionality { get; set; }
        public virtual DbSet<UserStatusType> UserStatusType { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorEncryptionType> VendorEncryptionType { get; set; }
        public virtual DbSet<VendorLink> VendorLink { get; set; }
        public virtual DbSet<VfsFile> VfsFile { get; set; }
        public virtual DbSet<VfsFileAcl> VfsFileAcl { get; set; }
        public virtual DbSet<VfsFileMetadata> VfsFileMetadata { get; set; }
        public virtual DbSet<VfsFolder> VfsFolder { get; set; }
        public virtual DbSet<VfsFolderAcl> VfsFolderAcl { get; set; }
        public virtual DbSet<VfsFolderMetadata> VfsFolderMetadata { get; set; }
        public virtual DbSet<VuwebAdminResources> VuwebAdminResources { get; set; }
        public virtual DbSet<VuwebResources> VuwebResources { get; set; }
        public virtual DbSet<ZmProgramCalendarEvent> ZmProgramCalendarEvent { get; set; }
        public virtual DbSet<ZmProgramCalendarEventInstance> ZmProgramCalendarEventInstance { get; set; }

        // Unable to generate entity type for table 'dbo.eform_Forms'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eform_FormType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.eform_SaveData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CvueObjectToSynonym'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LiveHelpBusinessUnit_copy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpCHARLIE_ADUsers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SyHistoryAddress'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PortalRedirection'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=mssql-dev-lms.charlie.kaplaninc.com\DEVLMS;Database=UniversityPortal_KVU;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountProvisioningProgramVersion>(entity =>
            {
                entity.Property(e => e.AccountProvisioningProgramVersionId).HasColumnName("AccountProvisioningProgramVersionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.ProgramVersionId).HasColumnName("ProgramVersionID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ActivityStreamSsislogs>(entity =>
            {
                entity.HasKey(e => e.ActivityStreamSsislogId)
                    .HasName("PK_ActivityStreamSSISLogs");

                entity.ToTable("ActivityStreamSSISLogs");

                entity.Property(e => e.ActivityStreamSsislogId).HasColumnName("ActivityStreamSSISLogID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LogInfo).HasColumnType("varchar(250)");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdAuthenticationDomain>(entity =>
            {
                entity.HasIndex(e => e.ConnectionString)
                    .HasName("IDX_NU_AdAuthenticationDomain_ConnectionString")
                    .IsUnique();

                entity.HasIndex(e => e.DomainName)
                    .HasName("IDX_NU_AdAuthenticationDomain_DomainName")
                    .IsUnique();

                entity.Property(e => e.AdAuthenticationDomainId).HasColumnName("AdAuthenticationDomainID");

                entity.Property(e => e.ConnectionString)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DisplayDomainName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DomainControllerList)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdminAccountProvisioning>(entity =>
            {
                entity.HasKey(e => e.Aaid)
                    .HasName("PK_AdminAccountProvisioning");

                entity.Property(e => e.Aaid).HasColumnName("AAID");

                entity.Property(e => e.AduserName)
                    .HasColumnName("ADUserName")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(25)");

                entity.Property(e => e.Imported).HasDefaultValueSql("0");

                entity.Property(e => e.LastName).HasColumnType("varchar(25)");

                entity.Property(e => e.Message).HasColumnType("varchar(max)");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<AttendancePostingMethod>(entity =>
            {
                entity.HasIndex(e => e.AttendancePostingMethodTypeId)
                    .HasName("IDX_N_FK_AttendancePostingMethod_PostingMethodID");

                entity.Property(e => e.AttendancePostingMethodId).HasColumnName("AttendancePostingMethodID");

                entity.Property(e => e.AttendancePostingMethodTypeId).HasColumnName("AttendancePostingMethodTypeID");

                entity.Property(e => e.CourseTypeId).HasColumnName("CourseTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(64);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AttendancePostingMethodType)
                    .WithMany(p => p.AttendancePostingMethod)
                    .HasForeignKey(d => d.AttendancePostingMethodTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AttendancePostingMethod_AttendancePostingMethodType_PostingMethodID");
            });

            modelBuilder.Entity<AttendancePostingMethodType>(entity =>
            {
                entity.Property(e => e.AttendancePostingMethodTypeId).HasColumnName("AttendancePostingMethodTypeID");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AuthenticationType>(entity =>
            {
                entity.Property(e => e.AuthenticationTypeId)
                    .HasColumnName("AuthenticationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BadgevillePlayer>(entity =>
            {
                entity.HasKey(e => e.BadgevillePlayerId)
                    .HasName("PK_BadgevillePlayer");

                entity.Property(e => e.BadgevillePlayerId).HasColumnName("BadgevillePlayerID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SiteUrl)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<BadgevilleSite>(entity =>
            {
                entity.HasKey(e => e.BadgevilleSiteId)
                    .HasName("PK_BadgevilleSite");

                entity.Property(e => e.BadgevilleSiteId).HasColumnName("BadgevilleSiteID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedAt).HasColumnType("varchar(100)");

                entity.Property(e => e.Id).HasColumnType("varchar(100)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.NetworkId).HasColumnType("varchar(100)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<BadgevilleUser>(entity =>
            {
                entity.HasKey(e => e.BadgevilleUserId)
                    .HasName("PK_BadgevilleUser");

                entity.Property(e => e.BadgevilleUserId).HasColumnName("BadgevilleUserID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<CmsAsset>(entity =>
            {
                entity.HasKey(e => e.AssetId)
                    .HasName("PK_cmsAsset");

                entity.ToTable("cmsAsset");

                entity.HasIndex(e => e.VfsFileId)
                    .HasName("IDX_N_cmsAsset_vfsFileID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Mimetype)
                    .IsRequired()
                    .HasColumnName("MIMEType")
                    .HasColumnType("varchar(128)")
                    .HasDefaultValueSql("'application/octet-stream'");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VfsFileId).HasColumnName("vfsFileID");

                entity.HasOne(d => d.VfsFile)
                    .WithMany(p => p.CmsAsset)
                    .HasForeignKey(d => d.VfsFileId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsContentBlock>(entity =>
            {
                entity.HasKey(e => e.ContentBlockId)
                    .HasName("PK_cmsContentBlock");

                entity.ToTable("cmsContentBlock");

                entity.HasIndex(e => new { e.TargetContentAreaFileId, e.ContentName })
                    .HasName("IDX_NU_cmsContentBlock_TargetContentAreaFileID_ContentName")
                    .IsUnique();

                entity.Property(e => e.ContentBlockId).HasColumnName("ContentBlockID");

                entity.Property(e => e.ContentName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.TargetContentAreaFileId).HasColumnName("TargetContentAreaFileID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CmsContentBlockAudience>(entity =>
            {
                entity.HasKey(e => e.ContentBlockAudienceId)
                    .HasName("PK_cmsContentBlockAudience");

                entity.ToTable("cmsContentBlockAudience");

                entity.HasIndex(e => new { e.ContentBlockId, e.AudienceName })
                    .HasName("IDX_NU_cmsContentBlockAudience_ContentBlockID_AudienceName")
                    .IsUnique();

                entity.Property(e => e.ContentBlockAudienceId).HasColumnName("ContentBlockAudienceID");

                entity.Property(e => e.AudienceName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ContentBlockId).HasColumnName("ContentBlockID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsUserControl).HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContentBlock)
                    .WithMany(p => p.CmsContentBlockAudience)
                    .HasForeignKey(d => d.ContentBlockId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsContentBlockAudienceCultureXhtml>(entity =>
            {
                entity.HasKey(e => e.ContentBlockAudienceCultureXhtmlid)
                    .HasName("PK_cmsContentBlockAudienceCultureXHTML");

                entity.ToTable("cmsContentBlockAudienceCultureXHTML");

                entity.HasIndex(e => e.ApprovedContentBlockAudienceCultureXhtmlversionId)
                    .HasName("IDX_N_cmsContentBlockAudienceCultureXHTML_ApprovedContentBlockAudienceCultureXHTMLVersionID");

                entity.HasIndex(e => e.CultureCodeId)
                    .HasName("IDX_N_FK_cmsContentBlockAudienceCultureXHTML_CultureCodeID");

                entity.HasIndex(e => new { e.ContentBlockAudienceId, e.CultureCodeId })
                    .HasName("IDX_NU_cmsContentBlockAudienceCultureXHTML_ContentBlockAudienceID_CultureCodeID")
                    .IsUnique();

                entity.Property(e => e.ContentBlockAudienceCultureXhtmlid).HasColumnName("ContentBlockAudienceCultureXHTMLID");

                entity.Property(e => e.ApprovedContentBlockAudienceCultureXhtmlversionId).HasColumnName("ApprovedContentBlockAudienceCultureXHTMLVersionID");

                entity.Property(e => e.ContentBlockAudienceId).HasColumnName("ContentBlockAudienceID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.CultureCodeId).HasColumnName("CultureCodeID");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovedContentBlockAudienceCultureXhtmlversion)
                    .WithMany(p => p.CmsContentBlockAudienceCultureXhtml)
                    .HasForeignKey(d => d.ApprovedContentBlockAudienceCultureXhtmlversionId)
                    .HasConstraintName("FK_cmsContentBlockAudienceCultureXHTML_cmsContentBlockAudienceCultureXHTMLVersion_7");

                entity.HasOne(d => d.ContentBlockAudience)
                    .WithMany(p => p.CmsContentBlockAudienceCultureXhtml)
                    .HasForeignKey(d => d.ContentBlockAudienceId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.CultureCode)
                    .WithMany(p => p.CmsContentBlockAudienceCultureXhtml)
                    .HasForeignKey(d => d.CultureCodeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsContentBlockAudienceCultureXhtmlversion>(entity =>
            {
                entity.HasKey(e => e.ContentBlockAudienceCultureXhtmlversionId)
                    .HasName("PK_cmsContentBlockAudienceCultureXHTMLVersion");

                entity.ToTable("cmsContentBlockAudienceCultureXHTMLVersion");

                entity.HasIndex(e => e.CreatedDate)
                    .HasName("IDX_N_cmsContentBlockAudienceCultureXHTMLVersion_CreatedDate");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IDX_N_FK_cmsContentBlockAudienceCultureXHTMLVersion_ProjectID");

                entity.HasIndex(e => e.WriteLockedEditSessionId)
                    .HasName("IDX_N_FK_cmsContentBlockAudienceCultureXHTMLVersion_WriteLockedEditSessionID");

                entity.HasIndex(e => new { e.ContentBlockAudienceCultureXhtmlid, e.ProjectId })
                    .HasName("IDX_NU_cmsContentBlockAudienceCultureXHTMLVersion_ContentBlockAudienceCultureXHTMLID_ProjectID")
                    .IsUnique();

                entity.Property(e => e.ContentBlockAudienceCultureXhtmlversionId).HasColumnName("ContentBlockAudienceCultureXHTMLVersionID");

                entity.Property(e => e.ContentBlockAudienceCultureXhtmlid).HasColumnName("ContentBlockAudienceCultureXHTMLID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsWriteLocked).HasDefaultValueSql("0");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WriteLockedEditSessionId).HasColumnName("WriteLockedEditSessionID");

                entity.Property(e => e.Xhtmlfragment).HasColumnName("XHTMLFragment");

                entity.HasOne(d => d.ContentBlockAudienceCultureXhtml)
                    .WithMany(p => p.CmsContentBlockAudienceCultureXhtmlversion)
                    .HasForeignKey(d => d.ContentBlockAudienceCultureXhtmlid)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmsContentBlockAudienceCultureXhtmlversion)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.WriteLockedEditSession)
                    .WithMany(p => p.CmsContentBlockAudienceCultureXhtmlversion)
                    .HasForeignKey(d => d.WriteLockedEditSessionId);
            });

            modelBuilder.Entity<CmsContentScheduleEntry>(entity =>
            {
                entity.HasKey(e => e.ContentScheduleEntryId)
                    .HasName("PK_cmsContentScheduleEntry");

                entity.ToTable("cmsContentScheduleEntry");

                entity.HasIndex(e => new { e.IsApproved, e.ApprovedContentScheduleEntryVersionId })
                    .HasName("IDX_N_cmsContentScheduleEntry_ApprovedContentScheduleEntryVersionID_Incl_IsApproved");

                entity.Property(e => e.ContentScheduleEntryId).HasColumnName("ContentScheduleEntryID");

                entity.Property(e => e.ApprovedContentScheduleEntryVersionId).HasColumnName("ApprovedContentScheduleEntryVersionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ApprovedContentScheduleEntryVersion)
                    .WithMany(p => p.CmsContentScheduleEntry)
                    .HasForeignKey(d => d.ApprovedContentScheduleEntryVersionId);
            });

            modelBuilder.Entity<CmsContentScheduleEntryVersion>(entity =>
            {
                entity.HasKey(e => e.ContentScheduleEntryVersionId)
                    .HasName("PK_cmsContentScheduleEntryVersion");

                entity.ToTable("cmsContentScheduleEntryVersion");

                entity.HasIndex(e => new { e.ContentScheduleEntryId, e.ProjectId })
                    .HasName("IDX_NU_cmsContentScheduleEntryVersion_ContentScheduleEntryID_ProjectID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ContentScheduleEntryId, e.ContentBlockId, e.ProjectId })
                    .HasName("IDX_N_cmsContentScheduleEntryVersion_ContentBlockID_ProjectID_Incl_ContentScheduleEntryID");

                entity.HasIndex(e => new { e.ProjectId, e.PublishStartDate, e.PublishEndDate })
                    .HasName("IDX_N_cmsContentScheduleEntryVersion_ProjectID_PublishStartDate_PublishEndDate");

                entity.HasIndex(e => new { e.PageId, e.ProjectId, e.ContentBlockId, e.ContentScheduleEntryId, e.PublishStartDate, e.PublishEndDate })
                    .HasName("IDX_N_cmsContentScheduleEntryVersion_PageID_ProjectID_ContentBlockID_ContentScheduleEntryID_PublishStartDate_PublishEndDate");

                entity.Property(e => e.ContentScheduleEntryVersionId).HasColumnName("ContentScheduleEntryVersionID");

                entity.Property(e => e.ContentBlockId).HasColumnName("ContentBlockID");

                entity.Property(e => e.ContentScheduleEntryId).HasColumnName("ContentScheduleEntryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.PublishStartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContentBlock)
                    .WithMany(p => p.CmsContentScheduleEntryVersion)
                    .HasForeignKey(d => d.ContentBlockId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ContentScheduleEntry)
                    .WithMany(p => p.CmsContentScheduleEntryVersion)
                    .HasForeignKey(d => d.ContentScheduleEntryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.CmsContentScheduleEntryVersion)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmsContentScheduleEntryVersion)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsCultureCode>(entity =>
            {
                entity.HasKey(e => e.CultureCodeId)
                    .HasName("PK_cmsCultureCode");

                entity.ToTable("cmsCultureCode");

                entity.HasIndex(e => e.CultureCode)
                    .HasName("IDX_NU_cmsCultureCode_CultureCode")
                    .IsUnique();

                entity.Property(e => e.CultureCodeId).HasColumnName("CultureCodeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.CultureCode)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.CultureName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CmsEditSession>(entity =>
            {
                entity.HasKey(e => e.EditSessionId)
                    .HasName("PK_cmsEditSession");

                entity.ToTable("cmsEditSession");

                entity.Property(e => e.EditSessionId).HasColumnName("EditSessionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.WriteLocksExpiration).HasColumnType("datetime");
            });

            modelBuilder.Entity<CmsPage>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("PK_cmsPage");

                entity.ToTable("cmsPage");

                entity.HasIndex(e => e.VfsFileId)
                    .HasName("IDX_N_FK_cmsPage_vfsFileID");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsVirtualPage).HasDefaultValueSql("1");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VfsFileId).HasColumnName("vfsFileID");

                entity.HasOne(d => d.VfsFile)
                    .WithMany(p => p.CmsPage)
                    .HasForeignKey(d => d.VfsFileId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsPageScheduleEntry>(entity =>
            {
                entity.HasKey(e => e.PageScheduleEntryId)
                    .HasName("PK_cmsPageScheduleEntry");

                entity.ToTable("cmsPageScheduleEntry");

                entity.HasIndex(e => new { e.ApprovedPageScheduleEntryVersionId, e.IsApproved })
                    .HasName("IDX_N_cmsPageScheduleEntry_ApprovedPageScheduleEntryVersionID_IsApproved");

                entity.Property(e => e.PageScheduleEntryId).HasColumnName("PageScheduleEntryID");

                entity.Property(e => e.ApprovedPageScheduleEntryVersionId).HasColumnName("ApprovedPageScheduleEntryVersionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ApprovedPageScheduleEntryVersion)
                    .WithMany(p => p.CmsPageScheduleEntry)
                    .HasForeignKey(d => d.ApprovedPageScheduleEntryVersionId);
            });

            modelBuilder.Entity<CmsPageScheduleEntryVersion>(entity =>
            {
                entity.HasKey(e => e.PageScheduleEntryVersionId)
                    .HasName("PK_cmsPageScheduleEntryVersion");

                entity.ToTable("cmsPageScheduleEntryVersion");

                entity.HasIndex(e => new { e.PageScheduleEntryId, e.ProjectId })
                    .HasName("IDX_NU_cmsPageScheduleEntryVersion_PageScheduleEntryID_ProjectID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProjectId, e.PageId, e.PageScheduleEntryId, e.PublishStartDate, e.PublishEndDate })
                    .HasName("IDX_N_cmsPageScheduleEntryVersion_ProjectID_PageID_PageScheduleEntryID_PublishStartDate_PublishEndDate");

                entity.Property(e => e.PageScheduleEntryVersionId).HasColumnName("PageScheduleEntryVersionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.PageScheduleEntryId).HasColumnName("PageScheduleEntryID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.PublishEndDate).HasColumnType("datetime");

                entity.Property(e => e.PublishStartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.CmsPageScheduleEntryVersion)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PageScheduleEntry)
                    .WithMany(p => p.CmsPageScheduleEntryVersion)
                    .HasForeignKey(d => d.PageScheduleEntryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmsPageScheduleEntryVersion)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsPhysicalPageContentAreaCache>(entity =>
            {
                entity.HasKey(e => e.PageContentAreaApprovedCacheId)
                    .HasName("PK_cmsPhysicalPageContentAreaCache");

                entity.ToTable("cmsPhysicalPageContentAreaCache");

                entity.HasIndex(e => e.ContentAreaFileId)
                    .HasName("IDX_N_FK_cmsPhysicalPageContentAreaCache_ContentAreaFileID");

                entity.HasIndex(e => new { e.PageId, e.ContentAreaFileId })
                    .HasName("IDX_NU_cmsPhysicalPageContentAreaCache_PageID_ContentAreaFileID")
                    .IsUnique();

                entity.Property(e => e.PageContentAreaApprovedCacheId).HasColumnName("PageContentAreaApprovedCacheID");

                entity.Property(e => e.ContentAreaFileId).HasColumnName("ContentAreaFileID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContentAreaFile)
                    .WithMany(p => p.CmsPhysicalPageContentAreaCache)
                    .HasForeignKey(d => d.ContentAreaFileId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.CmsPhysicalPageContentAreaCache)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsProject>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK_cmsProject");

                entity.ToTable("cmsProject");

                entity.HasIndex(e => e.ProjectName)
                    .HasName("IDX_NU_cmsProject_ProjectName")
                    .IsUnique();

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("0");

                entity.Property(e => e.IsLocked).HasDefaultValueSql("0");

                entity.Property(e => e.LastApprovalActionUsername).HasMaxLength(64);

                entity.Property(e => e.LastLockActionUsername).HasMaxLength(64);

                entity.Property(e => e.Priority).HasDefaultValueSql("0");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CmsSiteMapNode>(entity =>
            {
                entity.HasKey(e => e.SiteMapNodeId)
                    .HasName("PK_cmsSiteMapNode");

                entity.ToTable("cmsSiteMapNode");

                entity.HasIndex(e => new { e.ApprovedSiteMapNodeVersionId, e.IsApproved })
                    .HasName("IDX_N_cmsSiteMapNode_ApprovedSiteMapNodeVersionID_IsApproved");

                entity.Property(e => e.SiteMapNodeId).HasColumnName("SiteMapNodeID");

                entity.Property(e => e.ApprovedSiteMapNodeVersionId).HasColumnName("ApprovedSiteMapNodeVersionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.LastApprovalActionUsername).HasMaxLength(64);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovedSiteMapNodeVersion)
                    .WithMany(p => p.CmsSiteMapNode)
                    .HasForeignKey(d => d.ApprovedSiteMapNodeVersionId);
            });

            modelBuilder.Entity<CmsSiteMapNodeVersion>(entity =>
            {
                entity.HasKey(e => e.SiteMapNodeVersionId)
                    .HasName("PK_cmsSiteMapNodeVersion");

                entity.ToTable("cmsSiteMapNodeVersion");

                entity.HasIndex(e => e.ManagedPageId)
                    .HasName("IDX_N_FK_cmsSiteMapNodeVersion_ManagedPageID");

                entity.HasIndex(e => e.ParentSiteMapNodeId)
                    .HasName("IDX_N_cmsSiteMapNodeVersion_ParentSiteMapNodeID");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IDX_N_FK_cmsSiteMapNodeVersion_ProjectID");

                entity.HasIndex(e => new { e.SiteMapNodeId, e.ProjectId })
                    .HasName("IDX_NU_cmsSiteMapNodeVersion_SiteMapNodeID_ProjectID")
                    .IsUnique();

                entity.HasIndex(e => new { e.SiteMapNodeVersionId, e.ParentSiteMapNodeId })
                    .HasName("IDX_N_cmsSiteMapNodeVersion_SiteMapNodeVersionID_ParentSiteMapNodeID");

                entity.Property(e => e.SiteMapNodeVersionId).HasColumnName("SiteMapNodeVersionID");

                entity.Property(e => e.Action).HasMaxLength(64);

                entity.Property(e => e.Controller).HasMaxLength(64);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.HideChildren).HasDefaultValueSql("0");

                entity.Property(e => e.IsManagedReference).HasDefaultValueSql("1");

                entity.Property(e => e.IsPopUp).HasDefaultValueSql("0");

                entity.Property(e => e.ManagedPageId).HasColumnName("ManagedPageID");

                entity.Property(e => e.ParamId).HasMaxLength(64);

                entity.Property(e => e.ParentSiteMapNodeId).HasColumnName("ParentSiteMapNodeID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SiteMapNodeId).HasColumnName("SiteMapNodeID");

                entity.Property(e => e.UnmanagedUrl)
                    .HasColumnName("UnmanagedURL")
                    .HasColumnType("varchar(512)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ManagedPage)
                    .WithMany(p => p.CmsSiteMapNodeVersion)
                    .HasForeignKey(d => d.ManagedPageId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmsSiteMapNodeVersion)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.SiteMapNode)
                    .WithMany(p => p.CmsSiteMapNodeVersion)
                    .HasForeignKey(d => d.SiteMapNodeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsSiteMapNodeVersionMetadata>(entity =>
            {
                entity.HasKey(e => e.SiteMapNodeVersionMetadataId)
                    .HasName("PK_cmsSiteMapNodeVersionMetadata");

                entity.ToTable("cmsSiteMapNodeVersionMetadata");

                entity.HasIndex(e => e.CultureCodeId)
                    .HasName("IDX_N_FK_cmsSiteMapNodeVersionMetadata_CultureCodeID");

                entity.HasIndex(e => e.SiteMapNodeVersionId)
                    .HasName("IDX_N_FK_cmsSiteMapNodeVersionMetadata_SiteMapNodeVersionID");

                entity.Property(e => e.SiteMapNodeVersionMetadataId).HasColumnName("SiteMapNodeVersionMetadataID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.CultureCodeId).HasColumnName("CultureCodeID");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.SiteMapNodeVersionId).HasColumnName("SiteMapNodeVersionID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CultureCode)
                    .WithMany(p => p.CmsSiteMapNodeVersionMetadata)
                    .HasForeignKey(d => d.CultureCodeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.SiteMapNodeVersion)
                    .WithMany(p => p.CmsSiteMapNodeVersionMetadata)
                    .HasForeignKey(d => d.SiteMapNodeVersionId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsSystem>(entity =>
            {
                entity.HasKey(e => e.SystemId)
                    .HasName("PK_cmsSystem");

                entity.ToTable("cmsSystem");

                entity.Property(e => e.SystemId).HasColumnName("SystemID");

                entity.Property(e => e.ContentGeneration).HasDefaultValueSql("0");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectGeneration).HasDefaultValueSql("0");

                entity.Property(e => e.ScheduleGeneration).HasDefaultValueSql("0");

                entity.Property(e => e.SiteMapGeneration).HasDefaultValueSql("0");

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.TemplateGeneration).HasDefaultValueSql("0");

                entity.Property(e => e.VirtualPageGeneration).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CmsTemplatePage>(entity =>
            {
                entity.HasKey(e => e.TemplatePageId)
                    .HasName("PK_cmsTemplatePage");

                entity.ToTable("cmsTemplatePage");

                entity.HasIndex(e => e.VfsFileId)
                    .HasName("IDX_N_FK_cmsTemplatePage_vfsFileID");

                entity.Property(e => e.TemplatePageId).HasColumnName("TemplatePageID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.TemplateDescription).IsRequired();

                entity.Property(e => e.TemplateHtml)
                    .IsRequired()
                    .HasColumnName("TemplateHTML");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VfsFileId).HasColumnName("vfsFileID");

                entity.HasOne(d => d.VfsFile)
                    .WithMany(p => p.CmsTemplatePage)
                    .HasForeignKey(d => d.VfsFileId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsVirtualPage>(entity =>
            {
                entity.HasKey(e => e.VirtualPageId)
                    .HasName("PK_cmsVirtualPage");

                entity.ToTable("cmsVirtualPage");

                entity.HasIndex(e => e.ApprovedVirtualPageVersionId)
                    .HasName("IDX_N_FK_cmsVirtualPage_ApprovedVirtualPageVersionID");

                entity.HasIndex(e => e.CultureCodeId)
                    .HasName("IDX_N_FK_cmsVirtualPage_CultureCodeID");

                entity.HasIndex(e => new { e.PageId, e.CultureCodeId })
                    .HasName("IDX_NU_cmsVirtualPage_PageID_CultureCodeID")
                    .IsUnique();

                entity.Property(e => e.VirtualPageId).HasColumnName("VirtualPageID");

                entity.Property(e => e.ApprovedVirtualPageVersionId).HasColumnName("ApprovedVirtualPageVersionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.CultureCodeId).HasColumnName("CultureCodeID");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("0");

                entity.Property(e => e.LastApprovalActionUsername).HasMaxLength(64);

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ApprovedVirtualPageVersion)
                    .WithMany(p => p.CmsVirtualPage)
                    .HasForeignKey(d => d.ApprovedVirtualPageVersionId);

                entity.HasOne(d => d.CultureCode)
                    .WithMany(p => p.CmsVirtualPage)
                    .HasForeignKey(d => d.CultureCodeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.CmsVirtualPage)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsVirtualPageContentAreaCache>(entity =>
            {
                entity.HasKey(e => e.PageContentAreaProjectCacheId)
                    .HasName("PK_cmsVirtualPageContentAreaCache");

                entity.ToTable("cmsVirtualPageContentAreaCache");

                entity.HasIndex(e => e.ContentAreaFileId)
                    .HasName("IDX_N_FK_cmsVirtualPageContentAreaCache_ContentAreaFileID");

                entity.HasIndex(e => new { e.VirtualPageVersionId, e.ContentAreaFileId })
                    .HasName("IDX_NU_cmsVirtualPageContentAreaCache_VirtualPageVersionID_ContentAreaFileID")
                    .IsUnique();

                entity.Property(e => e.PageContentAreaProjectCacheId).HasColumnName("PageContentAreaProjectCacheID");

                entity.Property(e => e.ContentAreaFileId).HasColumnName("ContentAreaFileID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualPageVersionId).HasColumnName("VirtualPageVersionID");

                entity.HasOne(d => d.ContentAreaFile)
                    .WithMany(p => p.CmsVirtualPageContentAreaCache)
                    .HasForeignKey(d => d.ContentAreaFileId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.VirtualPageVersion)
                    .WithMany(p => p.CmsVirtualPageContentAreaCache)
                    .HasForeignKey(d => d.VirtualPageVersionId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmsVirtualPageVersion>(entity =>
            {
                entity.HasKey(e => e.VirtualPageVersionId)
                    .HasName("PK_cmsVirtualPageVersion");

                entity.ToTable("cmsVirtualPageVersion");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IDX_N_FK_cmsVirtualPageVersion_ProjectID");

                entity.HasIndex(e => e.WriteLockedEditSessionId)
                    .HasName("IDX_N_FK_cmsVirtualPageVersion_WriteLockedEditSessionID");

                entity.HasIndex(e => new { e.VirtualPageId, e.ProjectId })
                    .HasName("IDX_NU_cmsVirtualPageVersion_VirtualPageID_ProjectID")
                    .IsUnique();

                entity.Property(e => e.VirtualPageVersionId).HasColumnName("VirtualPageVersionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsWriteLocked).HasDefaultValueSql("0");

                entity.Property(e => e.LayoutXhtml)
                    .IsRequired()
                    .HasColumnName("LayoutXHTML");

                entity.Property(e => e.MasterPagePath).HasMaxLength(256);

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VirtualPageId).HasColumnName("VirtualPageID");

                entity.Property(e => e.WriteLockedEditSessionId).HasColumnName("WriteLockedEditSessionID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmsVirtualPageVersion)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.VirtualPage)
                    .WithMany(p => p.CmsVirtualPageVersion)
                    .HasForeignKey(d => d.VirtualPageId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.WriteLockedEditSession)
                    .WithMany(p => p.CmsVirtualPageVersion)
                    .HasForeignKey(d => d.WriteLockedEditSessionId);
            });

            modelBuilder.Entity<CmswfContentBlockAudienceCultureXhtmlversionApprovalState>(entity =>
            {
                entity.HasKey(e => e.ContentBlockAudienceCultureXhtmlversionApprovalStateId)
                    .HasName("PK_cmswfContentBlockAudienceCultureXHTMLVersionApprovalState");

                entity.ToTable("cmswfContentBlockAudienceCultureXHTMLVersionApprovalState");

                entity.HasIndex(e => e.ContentBlockAudienceCultureXhtmlid)
                    .HasName("IDX_N_FK_cmswfContentBlockAudienceCultureXHTMLVersionApprovalState_ContentBlockAudienceCultureXHTMLID");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IDX_N_FK_cmswfContentBlockAudienceCultureXHTMLVersionApprovalState_ProjectID");

                entity.Property(e => e.ContentBlockAudienceCultureXhtmlversionApprovalStateId).HasColumnName("ContentBlockAudienceCultureXHTMLVersionApprovalStateID");

                entity.Property(e => e.AccurateEntryOrder)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ContentBlockAudienceCultureXhtmlid).HasColumnName("ContentBlockAudienceCultureXHTMLID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StateChangedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StateEntryTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.HasOne(d => d.ContentBlockAudienceCultureXhtml)
                    .WithMany(p => p.CmswfContentBlockAudienceCultureXhtmlversionApprovalState)
                    .HasForeignKey(d => d.ContentBlockAudienceCultureXhtmlid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_cmswfContentBlockAudienceCultureXHTMLVersionApprovalState_cmsContentBlockAudienceCultureXHTML_2");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmswfContentBlockAudienceCultureXhtmlversionApprovalState)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmswfContentScheduleEntryVersionApprovalState>(entity =>
            {
                entity.HasKey(e => e.ContentScheduleEntryVersionApprovalStateId)
                    .HasName("PK_cmswfContentScheduleEntryVersionApprovalState");

                entity.ToTable("cmswfContentScheduleEntryVersionApprovalState");

                entity.HasIndex(e => e.ContentScheduleEntryId)
                    .HasName("IDX_N_FK_cmswfContentScheduleEntryVersionApprovalState_ContentScheduleEntryID");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IDX_N_FK_cmswfContentScheduleEntryVersionApprovalState_ProjectID");

                entity.Property(e => e.ContentScheduleEntryVersionApprovalStateId).HasColumnName("ContentScheduleEntryVersionApprovalStateID");

                entity.Property(e => e.AccurateEntryOrder)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ContentScheduleEntryId).HasColumnName("ContentScheduleEntryID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StateChangedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StateEntryTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.HasOne(d => d.ContentScheduleEntry)
                    .WithMany(p => p.CmswfContentScheduleEntryVersionApprovalState)
                    .HasForeignKey(d => d.ContentScheduleEntryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmswfContentScheduleEntryVersionApprovalState)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmswfPageScheduleEntryVersionApprovalState>(entity =>
            {
                entity.HasKey(e => e.PageScheduleEntryVersionApprovalStateId)
                    .HasName("PK_cmswfPageScheduleEntryVersionApprovalState");

                entity.ToTable("cmswfPageScheduleEntryVersionApprovalState");

                entity.HasIndex(e => e.PageScheduleEntryId)
                    .HasName("IDX_N_FK_cmswfPageScheduleEntryVersionApprovalState_PageScheduleEntryID");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IDX_N_FK_cmswfPageScheduleEntryVersionApprovalState_ProjectID");

                entity.Property(e => e.PageScheduleEntryVersionApprovalStateId).HasColumnName("PageScheduleEntryVersionApprovalStateID");

                entity.Property(e => e.AccurateEntryOrder)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PageScheduleEntryId).HasColumnName("PageScheduleEntryID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StateChangedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StateEntryTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.HasOne(d => d.PageScheduleEntry)
                    .WithMany(p => p.CmswfPageScheduleEntryVersionApprovalState)
                    .HasForeignKey(d => d.PageScheduleEntryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmswfPageScheduleEntryVersionApprovalState)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmswfVirtualPageVersionApprovalState>(entity =>
            {
                entity.HasKey(e => e.VirtualPageVersionApprovalStateId)
                    .HasName("PK_cmswfVirtualPageVersionApprovalState");

                entity.ToTable("cmswfVirtualPageVersionApprovalState");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IDX_N_FK_cmswfVirtualPageVersionApprovalState_ProjectID");

                entity.HasIndex(e => e.VirtualPageId)
                    .HasName("IDX_N_FK_cmswfVirtualPageVersionApprovalState_VirtualPageID");

                entity.Property(e => e.VirtualPageVersionApprovalStateId).HasColumnName("VirtualPageVersionApprovalStateID");

                entity.Property(e => e.AccurateEntryOrder)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StateChangedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StateEntryTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.VirtualPageId).HasColumnName("VirtualPageID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CmswfVirtualPageVersionApprovalState)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.VirtualPage)
                    .WithMany(p => p.CmswfVirtualPageVersionApprovalState)
                    .HasForeignKey(d => d.VirtualPageId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CmxActivityFromEventConfig>(entity =>
            {
                entity.HasKey(e => e.EnEvent)
                    .HasName("PK_cmxActivityFromEventConfig");

                entity.ToTable("cmxActivityFromEventConfig");

                entity.Property(e => e.EnEvent)
                    .HasColumnName("enEvent")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.HasOne(d => d.EnEventNavigation)
                    .WithOne(p => p.CmxActivityFromEventConfig)
                    .HasForeignKey<CmxActivityFromEventConfig>(d => d.EnEvent)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<CourseCatalogRequirements>(entity =>
            {
                entity.HasKey(e => e.CourseCatalogRequirementId)
                    .HasName("PK_CourseCatalogRequirements");

                entity.HasIndex(e => new { e.Active, e.CourseId })
                    .HasName("IX_U_CourseCatalogRequirements_CourseId")
                    .IsUnique();

                entity.Property(e => e.BlockSelfRegistration).HasDefaultValueSql("0");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasColumnType("varchar(4000)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<CourseTutor>(entity =>
            {
                entity.Property(e => e.CatalogNumber).HasColumnType("varchar(15)");

                entity.Property(e => e.LastUpdateBy).HasColumnType("varchar(100)");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CvueDatabaseMap>(entity =>
            {
                entity.HasKey(e => e.ServerInstance)
                    .HasName("PK_CvueDatabaseMap");

                entity.Property(e => e.ServerInstance).HasMaxLength(128);

                entity.Property(e => e.CvueDatabase)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<DegreePlanTicket>(entity =>
            {
                entity.Property(e => e.DegreePlanTicketId).HasColumnName("DegreePlanTicketID");

                entity.Property(e => e.Active).HasDefaultValueSql("0");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ProgramEnrollmentId).HasColumnName("ProgramEnrollmentID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");
            });

            modelBuilder.Entity<DiagCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_Categories");

                entity.ToTable("diagCategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<DiagCategoryLog>(entity =>
            {
                entity.HasKey(e => e.CategoryLogId)
                    .HasName("PK_CategoryLog");

                entity.ToTable("diagCategoryLog");

                entity.HasIndex(e => new { e.LogId, e.CategoryId })
                    .HasName("ixCategoryLog");

                entity.Property(e => e.CategoryLogId).HasColumnName("CategoryLogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DiagCategoryLog)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CategoryLog_Category");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.DiagCategoryLog)
                    .HasForeignKey(d => d.LogId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CategoryLog_Log");
            });

            modelBuilder.Entity<DiagLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_Log");

                entity.ToTable("diagLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.AppDomainName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ErrorType).HasMaxLength(512);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.IdentityName).HasMaxLength(256);

                entity.Property(e => e.InnerException).HasMaxLength(1500);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Message).HasMaxLength(1500);

                entity.Property(e => e.ProcessId)
                    .IsRequired()
                    .HasColumnName("ProcessID")
                    .HasMaxLength(256);

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Source).HasMaxLength(512);

                entity.Property(e => e.SourceApplication).HasMaxLength(256);

                entity.Property(e => e.TargetSite).HasMaxLength(512);

                entity.Property(e => e.ThreadName).HasMaxLength(512);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Win32ThreadId).HasMaxLength(128);
            });

            modelBuilder.Entity<DiagTraceLog>(entity =>
            {
                entity.HasKey(e => e.TraceLogId)
                    .HasName("PK_TraceLog");

                entity.ToTable("diagTraceLog");

                entity.Property(e => e.TraceLogId).HasColumnName("TraceLogID");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ThreadId).HasColumnName("ThreadID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<DirAffiliation>(entity =>
            {
                entity.ToTable("dirAffiliation");

                entity.HasIndex(e => e.DirAffiliationTypeId)
                    .HasName("IDX_N_FK_dirAffiliation_dirAffiliationTypeID");

                entity.Property(e => e.DirAffiliationId).HasColumnName("dirAffiliationID");

                entity.Property(e => e.AffiliationDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AffiliationName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DirAffiliationTypeId).HasColumnName("dirAffiliationTypeID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("0");

                entity.HasOne(d => d.DirAffiliationType)
                    .WithMany(p => p.DirAffiliation)
                    .HasForeignKey(d => d.DirAffiliationTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DirAffiliationType>(entity =>
            {
                entity.ToTable("dirAffiliationType");

                entity.Property(e => e.DirAffiliationTypeId).HasColumnName("dirAffiliationTypeID");

                entity.Property(e => e.AffiliationTypeDescription)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AffiliationTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<DirComplaintType>(entity =>
            {
                entity.ToTable("dirComplaintType");

                entity.Property(e => e.DirComplaintTypeId)
                    .HasColumnName("dirComplaintTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComplaintTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<DirContactRequestStatus>(entity =>
            {
                entity.ToTable("dirContactRequestStatus");

                entity.Property(e => e.DirContactRequestStatusId)
                    .HasColumnName("dirContactRequestStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DirCountry>(entity =>
            {
                entity.ToTable("dirCountry");

                entity.Property(e => e.DirCountryId)
                    .HasColumnName("dirCountryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<DirDegreeType>(entity =>
            {
                entity.ToTable("dirDegreeType");

                entity.Property(e => e.DirDegreeTypeId)
                    .HasColumnName("dirDegreeTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DegreeDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DegreeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DirEducationHistory>(entity =>
            {
                entity.ToTable("dirEducationHistory");

                entity.HasIndex(e => e.DirDegreeTypeId)
                    .HasName("IDX_N_FK_dirEducationHistory_dirDegreeTypeID");

                entity.HasIndex(e => e.DirEducationInstitutionId)
                    .HasName("IDX_N_FK_dirEducationHistory_dirEducationInstitutionID");

                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_dirEducationHistory_PortalUserID");

                entity.Property(e => e.DirEducationHistoryId).HasColumnName("dirEducationHistoryId");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateStart).HasColumnType("smalldatetime");

                entity.Property(e => e.DirDegreeTypeId).HasColumnName("dirDegreeTypeID");

                entity.Property(e => e.DirEducationInstitutionId).HasColumnName("dirEducationInstitutionID");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.Specialty)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.DirDegreeType)
                    .WithMany(p => p.DirEducationHistory)
                    .HasForeignKey(d => d.DirDegreeTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.DirEducationInstitution)
                    .WithMany(p => p.DirEducationHistory)
                    .HasForeignKey(d => d.DirEducationInstitutionId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.DirEducationHistory)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DirEducationInstitution>(entity =>
            {
                entity.ToTable("dirEducationInstitution");

                entity.HasIndex(e => e.DirCountryId)
                    .HasName("IDX_N_FK_dirEducationInstitution_dirCountryID");

                entity.HasIndex(e => e.DirInstitutionTypeId)
                    .HasName("IDX_N_FK_dirEducationInstitution_dirInstitutionTypeID");

                entity.HasIndex(e => e.DirStateProvinceId)
                    .HasName("IDX_N_FK_dirEducationInstitution_dirStateProvinceID");

                entity.Property(e => e.DirEducationInstitutionId).HasColumnName("dirEducationInstitutionID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DirCountryId).HasColumnName("dirCountryID");

                entity.Property(e => e.DirInstitutionTypeId).HasColumnName("dirInstitutionTypeID");

                entity.Property(e => e.DirStateProvinceId).HasColumnName("dirStateProvinceID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserDefined).HasDefaultValueSql("0");

                entity.HasOne(d => d.DirCountry)
                    .WithMany(p => p.DirEducationInstitution)
                    .HasForeignKey(d => d.DirCountryId);

                entity.HasOne(d => d.DirInstitutionType)
                    .WithMany(p => p.DirEducationInstitution)
                    .HasForeignKey(d => d.DirInstitutionTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.DirStateProvince)
                    .WithMany(p => p.DirEducationInstitution)
                    .HasForeignKey(d => d.DirStateProvinceId);
            });

            modelBuilder.Entity<DirInstitutionType>(entity =>
            {
                entity.ToTable("dirInstitutionType");

                entity.Property(e => e.DirInstitutionTypeId)
                    .HasColumnName("dirInstitutionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InstitutionTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DirPrivacySetting>(entity =>
            {
                entity.ToTable("dirPrivacySetting");

                entity.Property(e => e.DirPrivacySettingId).HasColumnName("dirPrivacySettingID");

                entity.Property(e => e.PrivacySettingDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PrivacySettingName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DirStateProvince>(entity =>
            {
                entity.ToTable("dirStateProvince");

                entity.HasIndex(e => e.DirCountryId)
                    .HasName("IDX_N_FK_dirStateProvince_dirCountryId");

                entity.Property(e => e.DirStateProvinceId).HasColumnName("dirStateProvinceID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasColumnType("nchar(3)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DirCountryId)
                    .HasColumnName("dirCountryId")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.DirCountry)
                    .WithMany(p => p.DirStateProvince)
                    .HasForeignKey(d => d.DirCountryId);
            });

            modelBuilder.Entity<DirTitle>(entity =>
            {
                entity.ToTable("dirTitle");

                entity.Property(e => e.DirTitleId)
                    .HasColumnName("dirTitleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("0");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DirUserAffiliation>(entity =>
            {
                entity.ToTable("dirUserAffiliation");

                entity.HasIndex(e => e.DirAffiliationId)
                    .HasName("IDX_N_FK_dirUserAffiliation_dirAffiliationID");

                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_dirUserAffiliation_PortalUserId");

                entity.Property(e => e.DirUserAffiliationId).HasColumnName("dirUserAffiliationID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DirAffiliationId).HasColumnName("dirAffiliationID");

                entity.HasOne(d => d.DirAffiliation)
                    .WithMany(p => p.DirUserAffiliation)
                    .HasForeignKey(d => d.DirAffiliationId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.DirUserAffiliation)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DirUserComplaint>(entity =>
            {
                entity.ToTable("dirUserComplaint");

                entity.HasIndex(e => e.DirComplaintTypeId)
                    .HasName("IDX_N_FK_dirUserComplaint_dirComplaintTypeID");

                entity.HasIndex(e => e.PortalUserIdDefendant)
                    .HasName("IDX_N_FK_dirUserComplaint_PortalUserID_Defendant");

                entity.Property(e => e.DirUserComplaintId).HasColumnName("dirUserComplaintID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ComplaintLink)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DirComplaintTypeId).HasColumnName("dirComplaintTypeID");

                entity.Property(e => e.PortalUserIdDefendant).HasColumnName("PortalUserID_Defendant");

                entity.Property(e => e.PortalUserIdPlantiff).HasColumnName("PortalUserID_Plantiff");

                entity.HasOne(d => d.DirComplaintType)
                    .WithMany(p => p.DirUserComplaint)
                    .HasForeignKey(d => d.DirComplaintTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PortalUserIdDefendantNavigation)
                    .WithMany(p => p.DirUserComplaint)
                    .HasForeignKey(d => d.PortalUserIdDefendant)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DirUserContactRequest>(entity =>
            {
                entity.ToTable("dirUserContactRequest");

                entity.HasIndex(e => e.DirContactRequestStatusId)
                    .HasName("IDX_N_FK_dirUserContactRequest_dirContactRequestStatusId");

                entity.HasIndex(e => e.PortalUserIdInviter)
                    .HasName("IDX_N_FK_dirUserContactRequest_PortalUserID_Inviter");

                entity.HasIndex(e => new { e.PortalUserIdContact, e.PortalUserIdInviter })
                    .HasName("IDX_NU_dirUserContactRequest_PortalUserID_Contact_PortalUserID_Inviter")
                    .IsUnique();

                entity.Property(e => e.DirUserContactRequestId).HasColumnName("dirUserContactRequestId");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DirContactRequestStatusId).HasColumnName("dirContactRequestStatusId");

                entity.Property(e => e.PortalUserIdContact).HasColumnName("PortalUserID_Contact");

                entity.Property(e => e.PortalUserIdInviter).HasColumnName("PortalUserID_Inviter");

                entity.HasOne(d => d.DirContactRequestStatus)
                    .WithMany(p => p.DirUserContactRequest)
                    .HasForeignKey(d => d.DirContactRequestStatusId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PortalUserIdInviterNavigation)
                    .WithMany(p => p.DirUserContactRequest)
                    .HasForeignKey(d => d.PortalUserIdInviter)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DirUserPrivacySetting>(entity =>
            {
                entity.ToTable("dirUserPrivacySetting");

                entity.HasIndex(e => e.DirPrivacySettingId)
                    .HasName("IDX_N_FK_dirUserPrivacySetting_dirPrivacySettingID");

                entity.HasIndex(e => new { e.PortalUserId, e.DirPrivacySettingId })
                    .HasName("IDX_CU_dirUserPrivacySetting_PortalUserID_dirPrivacySettingID")
                    .IsUnique();

                entity.Property(e => e.DirUserPrivacySettingId).HasColumnName("dirUserPrivacySettingID");

                entity.Property(e => e.DirPrivacySettingId).HasColumnName("dirPrivacySettingID");

                entity.Property(e => e.HasNetworkPermission)
                    .HasColumnName("hasNetworkPermission")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasStaffPermission)
                    .HasColumnName("hasStaffPermission")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HasStudentPermission)
                    .HasColumnName("hasStudentPermission")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.HasOne(d => d.DirPrivacySetting)
                    .WithMany(p => p.DirUserPrivacySetting)
                    .HasForeignKey(d => d.DirPrivacySettingId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.DirUserPrivacySetting)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DirUserProfile>(entity =>
            {
                entity.HasKey(e => e.PortalUserId)
                    .HasName("PK_dirUserProfile");

                entity.ToTable("dirUserProfile");

                entity.HasIndex(e => e.DirCountryIdBirth)
                    .HasName("IDX_N_FK_dirUserProfile_dirCountryID_Birth");

                entity.HasIndex(e => e.DirTitleIdPrefix)
                    .HasName("IDX_N_FK_dirUserProfile_dirTitleID_Prefix");

                entity.HasIndex(e => e.StateProvinceIdBirth)
                    .HasName("IDX_N_FK_dirUserProfile_StateProvinceID_Birth");

                entity.Property(e => e.PortalUserId).ValueGeneratedNever();

                entity.Property(e => e.Bio)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BirthCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DirCountryIdBirth).HasColumnName("dirCountryID_Birth");

                entity.Property(e => e.DirTitleIdPrefix)
                    .HasColumnName("dirTitleID_Prefix")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Im)
                    .IsRequired()
                    .HasColumnName("IM")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Interests)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.NonKaplanSocietyData)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PermitAllContacts).HasDefaultValueSql("0");

                entity.Property(e => e.PhotoFileName).HasColumnType("varchar(100)");

                entity.Property(e => e.ResumeFileName).HasColumnType("varchar(100)");

                entity.Property(e => e.StateProvinceIdBirth).HasColumnName("StateProvinceID_Birth");

                entity.HasOne(d => d.DirCountryIdBirthNavigation)
                    .WithMany(p => p.DirUserProfile)
                    .HasForeignKey(d => d.DirCountryIdBirth);

                entity.HasOne(d => d.DirTitleIdPrefixNavigation)
                    .WithMany(p => p.DirUserProfile)
                    .HasForeignKey(d => d.DirTitleIdPrefix)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PortalUser)
                    .WithOne(p => p.DirUserProfile)
                    .HasForeignKey<DirUserProfile>(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.StateProvinceIdBirthNavigation)
                    .WithMany(p => p.DirUserProfile)
                    .HasForeignKey(d => d.StateProvinceIdBirth);
            });

            modelBuilder.Entity<DirWorkHistory>(entity =>
            {
                entity.ToTable("dirWorkHistory");

                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_dirWorkHistory_PortalUserID");

                entity.Property(e => e.DirWorkHistoryId).HasColumnName("dirWorkHistoryId");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.DirWorkHistory)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DirZipInfo>(entity =>
            {
                entity.HasKey(e => e.ZipCode)
                    .HasName("PK_dirZipInfo");

                entity.ToTable("dirZipInfo");

                entity.HasIndex(e => e.Latitude)
                    .HasName("IDX_N_dirZipInfo_Latitude");

                entity.HasIndex(e => e.Longitude)
                    .HasName("IDX_N_dirZipInfo_Longitude");

                entity.Property(e => e.ZipCode).ValueGeneratedNever();

                entity.Property(e => e.City).HasColumnType("varchar(100)");

                entity.Property(e => e.ObservesDst)
                    .HasColumnName("observesDST")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State).HasColumnType("char(2)");
            });

            modelBuilder.Entity<DocumentLog>(entity =>
            {
                entity.Property(e => e.IpAddress).HasColumnType("varchar(15)");

                entity.Property(e => e.Message).HasColumnType("varchar(1000)");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<ECollegeHomeroomAuditLog>(entity =>
            {
                entity.ToTable("eCollegeHomeroomAuditLog");

                entity.Property(e => e.ECollegeHomeroomAuditLogId).HasColumnName("eCollegeHomeroomAuditLogID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ECollegeProgramVersionHomeroom>(entity =>
            {
                entity.ToTable("eCollegeProgramVersionHomeroom");

                entity.Property(e => e.ECollegeProgramVersionHomeroomId).HasColumnName("eCollegeProgramVersionHomeroomID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ECollegeCourseCallNumber)
                    .IsRequired()
                    .HasColumnName("eCollegeCourseCallNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.ECollegeRoleId).HasColumnName("eCollegeRoleId");

                entity.Property(e => e.ProgramVersionId).HasColumnName("ProgramVersionID");

                entity.Property(e => e.ResourceUrlname)
                    .IsRequired()
                    .HasColumnName("ResourceURLName")
                    .HasMaxLength(255);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ECollegeRoles>(entity =>
            {
                entity.HasKey(e => e.ECollegeRoleId)
                    .HasName("PK_eCollegeRoles");

                entity.ToTable("eCollegeRoles");

                entity.Property(e => e.ECollegeRoleId).HasColumnName("eCollegeRoleID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EnCommunicationEndpoint>(entity =>
            {
                entity.HasKey(e => e.CommunicationEndpointId)
                    .HasName("PK_enCommunicationEndpoint");

                entity.ToTable("enCommunicationEndpoint");

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_NU_enCommunicationEndpoint_Name")
                    .IsUnique();

                entity.Property(e => e.CommunicationEndpointId).HasColumnName("CommunicationEndpointID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.EndpointUrl)
                    .HasColumnName("EndpointURL")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EnCommunicationTracking>(entity =>
            {
                entity.HasKey(e => e.CommunicationTrackingId)
                    .HasName("PK_enCommunicationTracking");

                entity.ToTable("enCommunicationTracking");

                entity.HasIndex(e => e.CommunicationEndpointId)
                    .HasName("IDX_N_FK_enCommunicationTracking_CommunicationEndpointID");

                entity.Property(e => e.CommunicationTrackingId).HasColumnName("CommunicationTrackingID");

                entity.Property(e => e.CommunicationEndpointId).HasColumnName("CommunicationEndpointID");

                entity.Property(e => e.CorrelationId).HasColumnName("CorrelationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.Recipient)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.CommunicationEndpoint)
                    .WithMany(p => p.EnCommunicationTracking)
                    .HasForeignKey(d => d.CommunicationEndpointId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EnEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_enEvent");

                entity.ToTable("enEvent");

                entity.HasIndex(e => e.EventBrokerEventName)
                    .HasName("IDX_NU_enEvent_EventBrokerEventName")
                    .IsUnique();

                entity.Property(e => e.EventId)
                    .HasColumnName("EventID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DefaultEmail).HasColumnType("varchar(250)");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EventBrokerEventName)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.IsEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.IsLoggingEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.IsSubscribable).HasDefaultValueSql("1");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EnEventMessageTemplate>(entity =>
            {
                entity.HasKey(e => e.EventMessageTemplateId)
                    .HasName("PK_enEventMessageTemplate");

                entity.ToTable("enEventMessageTemplate");

                entity.HasIndex(e => e.CommunicationEndpointId)
                    .HasName("IDX_N_FK_enEventMessageTemplate_CommunicationEndpointID");

                entity.HasIndex(e => e.EventId)
                    .HasName("IDX_N_FK_enEventMessageTemplate_EventID");

                entity.Property(e => e.EventMessageTemplateId).HasColumnName("EventMessageTemplateID");

                entity.Property(e => e.CommunicationEndpointId).HasColumnName("CommunicationEndpointID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.IsRequired).HasDefaultValueSql("0");

                entity.Property(e => e.TemplatesXml)
                    .IsRequired()
                    .HasColumnName("TemplatesXML");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CommunicationEndpoint)
                    .WithMany(p => p.EnEventMessageTemplate)
                    .HasForeignKey(d => d.CommunicationEndpointId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EnEventMessageTemplate)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EnEventQueryColumnSchema>(entity =>
            {
                entity.HasKey(e => e.EventQueryColumnSchemaId)
                    .HasName("PK_enEventQueryColumnSchema");

                entity.ToTable("enEventQueryColumnSchema");

                entity.HasIndex(e => e.EventId)
                    .HasName("IDX_N_FK_enEventQueryColumnSchema_EventID");

                entity.Property(e => e.EventQueryColumnSchemaId).HasColumnName("EventQueryColumnSchemaID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EnEventQueryColumnSchema)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EnEventQueryExecutionStateHistory>(entity =>
            {
                entity.HasKey(e => e.EventQueryExecutionStateHistoryId)
                    .HasName("PK_enEventQueryExecutionStateHistory");

                entity.ToTable("enEventQueryExecutionStateHistory");

                entity.HasIndex(e => e.EventId)
                    .HasName("IDX_N_FK_enEventQueryExecutionStateHistory_EventID");

                entity.Property(e => e.EventQueryExecutionStateHistoryId).HasColumnName("EventQueryExecutionStateHistoryID");

                entity.Property(e => e.CountErrored).HasDefaultValueSql("0");

                entity.Property(e => e.CountIgnored).HasDefaultValueSql("0");

                entity.Property(e => e.CountSuccessful).HasDefaultValueSql("0");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EnEventQueryExecutionStateHistory)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EnEventStoredProcedure>(entity =>
            {
                entity.HasKey(e => e.EventStoredProcedureId)
                    .HasName("PK_enEventStoredProcedure");

                entity.ToTable("enEventStoredProcedure");

                entity.HasIndex(e => e.EventId)
                    .HasName("IDX_N_enEventStoredProcedure_EventID");

                entity.Property(e => e.EventStoredProcedureId).HasColumnName("EventStoredProcedureID");

                entity.Property(e => e.ConnectionStringName)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.ContainsDuplicateKeys).HasDefaultValueSql("0");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.JoinKeyColumnName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LastExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.Ordinal).HasDefaultValueSql("0");

                entity.Property(e => e.StoredProcedureName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EnEventStoredProcedure)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EnEventStoredProcedureParameter>(entity =>
            {
                entity.HasKey(e => e.EventStoredProcedureParameterId)
                    .HasName("PK_enEventStoredProcedureParameter");

                entity.ToTable("enEventStoredProcedureParameter");

                entity.HasIndex(e => e.EventStoredProcedureId)
                    .HasName("IDX_N_FK_enEventStoredProcedureParameter_EventStoredProcedureID");

                entity.Property(e => e.EventStoredProcedureParameterId).HasColumnName("EventStoredProcedureParameterID");

                entity.Property(e => e.EventStoredProcedureId).HasColumnName("EventStoredProcedureID");

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.ParameterType)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.ParameterValue)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.EventStoredProcedure)
                    .WithMany(p => p.EnEventStoredProcedureParameter)
                    .HasForeignKey(d => d.EventStoredProcedureId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<EnSmsprovider>(entity =>
            {
                entity.HasKey(e => e.SmsproviderId)
                    .HasName("PK_enSMSProvider");

                entity.ToTable("enSMSProvider");

                entity.Property(e => e.SmsproviderId).HasColumnName("SMSProviderID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.EmailFormat)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EnUserContactSettings>(entity =>
            {
                entity.HasKey(e => e.UserContactSettingsId)
                    .HasName("PK_enUserContactSettings");

                entity.ToTable("enUserContactSettings");

                entity.HasIndex(e => e.CommunicationEndpointId)
                    .HasName("IDX_N_FK_enUserContactSettings_CommunicationEndpointID");

                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_enUserContactSettings_PortalUserID");

                entity.HasIndex(e => e.SmsproviderId)
                    .HasName("IDX_N_FK_enUserContactSettings_SMSProviderID");

                entity.Property(e => e.UserContactSettingsId).HasColumnName("UserContactSettingsID");

                entity.Property(e => e.CommunicationEndpointId).HasColumnName("CommunicationEndpointID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.SiscontactInfoType)
                    .IsRequired()
                    .HasColumnName("SISContactInfoType")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SmsproviderId).HasColumnName("SMSProviderID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CommunicationEndpoint)
                    .WithMany(p => p.EnUserContactSettings)
                    .HasForeignKey(d => d.CommunicationEndpointId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.EnUserContactSettings)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Smsprovider)
                    .WithMany(p => p.EnUserContactSettings)
                    .HasForeignKey(d => d.SmsproviderId);
            });

            modelBuilder.Entity<EnUserEventSubscription>(entity =>
            {
                entity.HasKey(e => e.UserEventSubscriptionId)
                    .HasName("PK_enUserEventSubscription");

                entity.ToTable("enUserEventSubscription");

                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_enUserEventSubscription_PortalUserID");

                entity.Property(e => e.UserEventSubscriptionId).HasColumnName("UserEventSubscriptionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.EnUserEventSubscription)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<FacultyTutor>(entity =>
            {
                entity.HasKey(e => e.FacultTutorId)
                    .HasName("PK_FacultyTutor");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateBy).HasColumnType("varchar(100)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Functionality>(entity =>
            {
                entity.Property(e => e.FunctionalityId).HasColumnName("FunctionalityID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(2500);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IdentityVerificationLog>(entity =>
            {
                entity.HasIndex(e => new { e.SessionId, e.IStudentId, e.ActivityType, e.IsSuccessful })
                    .HasName("IDX_N_IdentityVerificationLog_SessionID_iStudentID_ActivityType_IsSuccessful");

                entity.HasIndex(e => new { e.SessionId, e.Username, e.ActivityType, e.IsSuccessful })
                    .HasName("IDX_N_IdentityVerificationLog_SessionID_Username_ActivityType_IsSuccessful");

                entity.Property(e => e.IdentityVerificationLogId).HasColumnName("IdentityVerificationLogID");

                entity.Property(e => e.ActivityType)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IStudentId).HasColumnName("iStudentID");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("SessionID")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Username).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ImImpersonatedView>(entity =>
            {
                entity.HasKey(e => e.ImpersonatedId)
                    .HasName("PK_imImpersonatedView");

                entity.ToTable("imImpersonatedView");

                entity.Property(e => e.ImpersonatedId).HasColumnName("ImpersonatedID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("char(50)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("char(100)");

                entity.Property(e => e.ImpersonatedUserId)
                    .IsRequired()
                    .HasColumnName("ImpersonatedUserID")
                    .HasColumnType("char(50)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("char(100)");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ImImpersonatingView>(entity =>
            {
                entity.HasKey(e => e.ImpersonatingId)
                    .HasName("PK_imImpersonatingView");

                entity.ToTable("imImpersonatingView");

                entity.Property(e => e.ImpersonatingId).HasColumnName("ImpersonatingID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("char(50)");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("char(100)");

                entity.Property(e => e.ImpersonatingUserId)
                    .IsRequired()
                    .HasColumnName("ImpersonatingUserID")
                    .HasColumnType("char(50)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("char(100)");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ImImpersonationAudit>(entity =>
            {
                entity.HasKey(e => e.ImpersonationAuditId)
                    .HasName("PK_imImpersonationAudit");

                entity.ToTable("imImpersonationAudit");

                entity.Property(e => e.ImpersonationAuditId).HasColumnName("ImpersonationAuditID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImpersonatedPortalUserId).HasColumnName("ImpersonatedPortalUserID");

                entity.Property(e => e.ImpersonatingPortalUserId).HasColumnName("ImpersonatingPortalUserID");
            });

            modelBuilder.Entity<InsConcern>(entity =>
            {
                entity.HasKey(e => e.ConcernId)
                    .HasName("PK_insConcern");

                entity.ToTable("insConcern");

                entity.HasIndex(e => e.ConcernType)
                    .HasName("IDX_N_FK_insConcern_ConcernType");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ConcernTypeNavigation)
                    .WithMany(p => p.InsConcern)
                    .HasForeignKey(d => d.ConcernType);
            });

            modelBuilder.Entity<InsConcernStatus>(entity =>
            {
                entity.HasKey(e => e.ConcernStatusId)
                    .HasName("PK_insConcernStatus");

                entity.ToTable("insConcernStatus");

                entity.Property(e => e.ConcernStatus).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(100)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InsConcernType>(entity =>
            {
                entity.HasKey(e => e.ConcernTypeId)
                    .HasName("PK_insConcernType");

                entity.ToTable("insConcernType");

                entity.Property(e => e.ConcernType).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasColumnType("varchar(100)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InsConcernVisualAlert>(entity =>
            {
                entity.HasKey(e => e.ConcernId)
                    .HasName("PK_insConcernVisualAlert");

                entity.ToTable("insConcernVisualAlert");

                entity.Property(e => e.ConcernId).ValueGeneratedNever();

                entity.Property(e => e.DateLastViewed).HasColumnType("datetime");
            });

            modelBuilder.Entity<InstructorAccountProvisioning>(entity =>
            {
                entity.HasKey(e => e.SyStaffId)
                    .HasName("PK_InstructorAccountProvisioning");

                entity.Property(e => e.SyStaffId)
                    .HasColumnName("syStaffID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AduserName)
                    .HasColumnName("ADUserName")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.EmailAddress).HasColumnType("varchar(50)");

                entity.Property(e => e.EmployeeNumber).HasColumnType("varchar(100)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(25)");

                entity.Property(e => e.Imported).HasDefaultValueSql("0");

                entity.Property(e => e.LastName).HasColumnType("varchar(25)");

                entity.Property(e => e.Message).HasColumnType("varchar(max)");

                entity.Property(e => e.SyCampusId).HasColumnName("syCampusID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<LiveHelp>(entity =>
            {
                entity.Property(e => e.LiveHelpId).HasColumnName("LiveHelpID");

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.Property(e => e.DisabledText).HasColumnType("varchar(255)");

                entity.Property(e => e.DisplayText).HasColumnType("varchar(255)");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.LastUpdateBy).HasColumnType("varchar(100)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LiveHelpBusinessUnit>(entity =>
            {
                entity.HasIndex(e => e.LiveHelpId)
                    .HasName("IDX_N_FK_LiveHelpBusinessUnit_LiveHelpID");

                entity.Property(e => e.LiveHelpBusinessUnitId).HasColumnName("LiveHelpBusinessUnitID");

                entity.Property(e => e.DisabledText).HasColumnType("varchar(255)");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.LastUpdateBy).HasColumnType("varchar(100)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LiveHelpId).HasColumnName("LiveHelpID");

                entity.Property(e => e.LiveHelpUrl)
                    .HasColumnName("LiveHelpURL")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.ToolTip).HasColumnType("varchar(255)");

                entity.HasOne(d => d.LiveHelp)
                    .WithMany(p => p.LiveHelpBusinessUnit)
                    .HasForeignKey(d => d.LiveHelpId);
            });

            modelBuilder.Entity<MilitaryTuitionParentRates>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description).HasColumnType("varchar(250)");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Name).HasColumnType("varchar(250)");

                entity.Property(e => e.ProgramFee)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TechnologyFee)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TuitionDiscountPercent).HasColumnType("decimal");

                entity.Property(e => e.TuitionDiscountRate).HasColumnType("decimal");

                entity.Property(e => e.TuitionDiscountType)
                    .IsRequired()
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.TuitionRate).HasColumnType("decimal");
            });

            modelBuilder.Entity<MilitaryTuitionRates>(entity =>
            {
                entity.HasKey(e => e.MilitaryTuitionRateId)
                    .HasName("PK_TuitionRates");

                entity.HasIndex(e => new { e.MilitaryStatusId, e.ProgramId, e.ProgramVersionId, e.GraduateLevel })
                    .HasName("IX_MilitaryTuitionRates");

                entity.Property(e => e.CoursePrefix).HasColumnType("varchar(2000)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.MilitaryStatus)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ProgramCode).HasColumnType("varchar(20)");

                entity.Property(e => e.ProgramFee)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProgramName).HasColumnType("varchar(250)");

                entity.Property(e => e.ProgramVersionCode).HasColumnType("varchar(50)");

                entity.Property(e => e.ProgramVersionName).HasColumnType("varchar(250)");

                entity.Property(e => e.TechnologyFee)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TuitionDiscountPercent).HasColumnType("decimal");

                entity.Property(e => e.TuitionDiscountRate).HasColumnType("decimal");

                entity.Property(e => e.TuitionDiscountType)
                    .IsRequired()
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.TuitionRate).HasColumnType("decimal");
            });

            modelBuilder.Entity<MilitaryTuitionRatesCdltracking>(entity =>
            {
                entity.ToTable("MilitaryTuitionRatesCDLTracking");

                entity.Property(e => e.Militarytuitionratescdltrackingid).HasColumnName("militarytuitionratescdltrackingid");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnName("createdby")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Documentscheduleid).HasColumnName("documentscheduleid");

                entity.Property(e => e.Modifiedby)
                    .IsRequired()
                    .HasColumnName("modifiedby")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("modifieddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Studentid).HasColumnName("studentid");

                entity.Property(e => e.Termid).HasColumnName("termid");
            });

            modelBuilder.Entity<OnlineFormsRequest>(entity =>
            {
                entity.HasIndex(e => e.RequestType)
                    .HasName("IDX_N_FK_OnlineFormsRequest_RequestType");

                entity.HasIndex(e => e.Status)
                    .HasName("IDX_N_FK_OnlineFormsRequest_Status");

                entity.Property(e => e.Communication)
                    .IsRequired()
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewGrade).HasColumnType("varchar(4)");

                entity.Property(e => e.NewLetterGrade).HasColumnType("varchar(2)");

                entity.Property(e => e.OldGrade).HasColumnType("varchar(4)");

                entity.Property(e => e.OldLetterGrade).HasColumnType("varchar(2)");

                entity.HasOne(d => d.RequestTypeNavigation)
                    .WithMany(p => p.OnlineFormsRequest)
                    .HasForeignKey(d => d.RequestType)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.OnlineFormsRequest)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<OnlineFormsRequestStatus>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<OnlineFormsRequestType>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<OrionBusinessUnitTicketType>(entity =>
            {
                entity.HasKey(e => new { e.BusinessUnitId, e.OrionTicketDescriptionId, e.TicketTypeId })
                    .HasName("PK_OrionBusinessUnitTicketType");

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrionEndSystems>(entity =>
            {
                entity.HasKey(e => e.BusinessUnitId)
                    .HasName("PK_OrionEndSystems");

                entity.Property(e => e.BusinessUnitId)
                    .HasColumnName("BusinessUnitID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndSystem)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrionTicketDescription>(entity =>
            {
                entity.Property(e => e.OrionTicketDescriptionId)
                    .HasColumnName("OrionTicketDescriptionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OutcomesReport>(entity =>
            {
                entity.HasIndex(e => e.SyStudentId)
                    .HasName("IX_OutcomesReport_StudentId");

                entity.Property(e => e.AverageScore).HasColumnType("numeric");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SISPackage'");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'SISPackage'");

                entity.Property(e => e.OutcomeCode).HasColumnType("varchar(255)");

                entity.Property(e => e.OutcomeDescription).HasColumnType("varchar(255)");

                entity.Property(e => e.SumStrength).HasColumnType("numeric");

                entity.Property(e => e.SyStudentId).HasColumnName("SyStudentID");
            });

            modelBuilder.Entity<OutcomesReportV1>(entity =>
            {
                entity.HasKey(e => e.OutcomesReportId)
                    .HasName("PK_OutcomesReportId");

                entity.ToTable("OutcomesReport_V1");

                entity.HasIndex(e => e.SyStudentId)
                    .HasName("IX_OutcomesReport_V1_syStudentID");

                entity.Property(e => e.CourseOutcomeCode).HasColumnType("varchar(56)");

                entity.Property(e => e.CourseOutcomeDescription).HasColumnType("varchar(250)");

                entity.Property(e => e.CourseOutcomeScore).HasColumnType("numeric");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PoutcomeHeadline)
                    .HasColumnName("POutcomeHeadline")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.ProgramOutcomeCode)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.ProgramOutcomeDescription).HasColumnType("varchar(250)");

                entity.Property(e => e.SyStudentId).HasColumnName("SyStudentID");
            });

            modelBuilder.Entity<PasswordChangeLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfChange)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_N_Permission_Name");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(2500);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PortalBillingStatementSubscriptions>(entity =>
            {
                entity.HasKey(e => e.PortalBillingStatementSubscriptionId)
                    .HasName("PK_PortalBillingStatementSubscriptions");

                entity.HasIndex(e => e.StudentId)
                    .HasName("IDX_PortalBillingStatementSubscriptions_StudentID");

                entity.Property(e => e.PortalBillingStatementSubscriptionId).HasColumnName("PortalBillingStatementSubscriptionID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.OptInDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OptOutDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PortalNotification>(entity =>
            {
                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_PortalNotification_PortalUserID");

                entity.Property(e => e.PortalNotificationId).HasColumnName("PortalNotificationID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.FromAddress)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.HasBeenRead).HasDefaultValueSql("0");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalNotification)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PortalUser>(entity =>
            {
                entity.HasIndex(e => e.AdAuthenticationDomainId)
                    .HasName("IDX_N_PortalUser_AdAuthenticationDomainID");

                entity.HasIndex(e => e.AuthenticationTypeId)
                    .HasName("IDX_N_PortalUser_AuthenticationTypeID");

                entity.HasIndex(e => e.FirstName)
                    .HasName("IDX_N_PortalUser_FirstName");

                entity.HasIndex(e => e.LastName)
                    .HasName("IDX_N_PortalUser_LastName");

                entity.HasIndex(e => e.Ts)
                    .HasName("IDX_PortalUser_ts");

                entity.HasIndex(e => e.Username)
                    .HasName("IDX_NU_PortalUser_Username")
                    .IsUnique();

                entity.HasIndex(e => new { e.IsActive, e.Username, e.LastLoginDate })
                    .HasName("IDX_PortalUser_LastLoginDate_INCL_Active_UserName");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.IsActive, e.Username, e.PrimaryCampusId })
                    .HasName("IDX_N_PortalUser_PrimaryCampusID_Incl_LastName_FirstName_IsActive_Username");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.AdAuthenticationDomainId).HasColumnName("AdAuthenticationDomainID");

                entity.Property(e => e.Adusername)
                    .HasColumnName("ADUsername")
                    .HasMaxLength(100);

                entity.Property(e => e.AuthenticationTypeId)
                    .HasColumnName("AuthenticationTypeID")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.FailedLoginAttemptCount).HasDefaultValueSql("0");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.IsLockedOut).HasDefaultValueSql("0");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LastTemporaryPasswordIssueDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordFormat).HasDefaultValueSql("0");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PrimaryCampusId).HasColumnName("PrimaryCampusID");

                entity.Property(e => e.RequirePasswordChange).HasDefaultValueSql("0");

                entity.Property(e => e.TemporaryPasswordExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.TimeZoneId)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AdAuthenticationDomain)
                    .WithMany(p => p.PortalUser)
                    .HasForeignKey(d => d.AdAuthenticationDomainId);

                entity.HasOne(d => d.AuthenticationType)
                    .WithMany(p => p.PortalUser)
                    .HasForeignKey(d => d.AuthenticationTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PortalUserAttribute>(entity =>
            {
                entity.HasIndex(e => new { e.Attribute, e.PortalUserId })
                    .HasName("IDX_PortalUserAttribute_PortalUserID_INCL_Attribute");

                entity.Property(e => e.PortalUserAttributeId).HasColumnName("PortalUserAttributeID");

                entity.Property(e => e.Attribute).HasColumnType("varchar(100)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.Value).HasColumnType("varchar(100)");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalUserAttribute)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PortalUserAttribute_PortalUser");
            });

            modelBuilder.Entity<PortalUserLogin>(entity =>
            {
                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_PortalUserLogin_PortalUserID");

                entity.HasIndex(e => new { e.PortalUserId, e.CreatedDate, e.AuthenticationResult })
                    .HasName("IDX_PortalUserLogin_PortalUserID_CreatedDate_AuthenticationResult");

                entity.Property(e => e.PortalUserLoginId).HasColumnName("PortalUserLoginID");

                entity.Property(e => e.AuthenticationResult)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalUserLogin)
                    .HasForeignKey(d => d.PortalUserId);
            });

            modelBuilder.Entity<PortalUserMapping>(entity =>
            {
                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_PortalUserMapping_PortalUserID");

                entity.HasIndex(e => new { e.PortalUserId, e.UserMappingTypeId })
                    .HasName("IDX_N_PortalUserMapping_PortalUserID_UserMappingTypeID");

                entity.HasIndex(e => new { e.MappedId, e.UserMappingTypeId, e.PortalUserId })
                    .HasName("IDX_N_PortalUserMapping_UserMappingTypeID_PortalUserID_Incl_MappedID");

                entity.HasIndex(e => new { e.PortalUserId, e.UserMappingTypeId, e.MappedId })
                    .HasName("IDX_N_PortalUserMapping_UserMappingTypeID_MappedID_INCL");

                entity.HasIndex(e => new { e.MappedId, e.UserMappingTypeId, e.CampusId, e.PortalUserId })
                    .HasName("IDX_NU_PortalUserMapping_UserMappingTypeID_CampusID_PortalUserID_INCL_mappedid")
                    .IsUnique();

                entity.Property(e => e.PortalUserMappingId).HasColumnName("PortalUserMappingID");

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.MappedId)
                    .IsRequired()
                    .HasColumnName("MappedID")
                    .HasColumnType("varchar(350)");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserMappingTypeId).HasColumnName("UserMappingTypeID");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalUserMapping)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UserMappingType)
                    .WithMany(p => p.PortalUserMapping)
                    .HasForeignKey(d => d.UserMappingTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PortalUserMessenger>(entity =>
            {
                entity.Property(e => e.PortalUserMessengerId).HasColumnName("PortalUserMessengerID");

                entity.Property(e => e.ConsentAuthenticationToken).HasColumnType("varchar(max)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasColumnType("varchar(24)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DelegatedAuthenticationToken).HasColumnType("varchar(max)");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");
            });

            modelBuilder.Entity<PortalUserMessengerChat>(entity =>
            {
                entity.HasKey(e => e.MessengerChatId)
                    .HasName("PK_PortalUserMessengerChat");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PortalUserMessengerChatMessage>(entity =>
            {
                entity.HasKey(e => e.MessengerChatMessageId)
                    .HasName("PK_PortalUserMessengerChatMessage");

                entity.HasIndex(e => e.MessengerChatId)
                    .HasName("IDX_N_FK_PortalUserMessengerChatMessage_MessengerChatId");

                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_PortalUserMessengerChatMessage_PortalUserId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.UtccreateDate)
                    .HasColumnName("UTCCreateDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.HasOne(d => d.MessengerChat)
                    .WithMany(p => p.PortalUserMessengerChatMessage)
                    .HasForeignKey(d => d.MessengerChatId);

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalUserMessengerChatMessage)
                    .HasForeignKey(d => d.PortalUserId);
            });

            modelBuilder.Entity<PortalUserMessengerChatParticipator>(entity =>
            {
                entity.HasKey(e => e.MessengerChatParticipatorId)
                    .HasName("PK_PortalUserMessengerChatParticipator");

                entity.HasIndex(e => e.MessengerChatId)
                    .HasName("IDX_N_FK_PortalUserMessengerChatParticipator_MessengerChatId");

                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_PortalUserMessengerChatParticipator_PortalUserId");

                entity.HasOne(d => d.MessengerChat)
                    .WithMany(p => p.PortalUserMessengerChatParticipator)
                    .HasForeignKey(d => d.MessengerChatId);

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalUserMessengerChatParticipator)
                    .HasForeignKey(d => d.PortalUserId);
            });

            modelBuilder.Entity<PortalUserMessengerSignInLog>(entity =>
            {
                entity.HasKey(e => e.MessengerSignInLog)
                    .HasName("PK_PortalUserMessengerSignInLog");

                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_FK_PortalUserMessengerSignInLog_PortalUserId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalUserMessengerSignInLog)
                    .HasForeignKey(d => d.PortalUserId);
            });

            modelBuilder.Entity<PortalUserRole>(entity =>
            {
                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_PortalUserRole_PortalUserID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IDX_N_PortalUserRole_RoleID");

                entity.HasIndex(e => new { e.RoleId, e.PortalUserId, e.IsActive })
                    .HasName("IDX_N_PortalUserRole_PortalUserID_IsActive_Incl_RoleID");

                entity.Property(e => e.PortalUserRoleId).HasColumnName("PortalUserRoleID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalUserRole)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PortalUserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PortalUserSystemActionAudit>(entity =>
            {
                entity.Property(e => e.PortalUserSystemActionAuditId).HasColumnName("PortalUserSystemActionAuditID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ModifyBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.PortalUserSystemActionAudit)
                    .HasForeignKey(d => d.PortalUserId)
                    .HasConstraintName("FK_PortalUserSystemActionAudit_PortalUser");
            });

            modelBuilder.Entity<Presentation>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EnabledChangeDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnType("varchar(64)");
            });

            modelBuilder.Entity<PresentationAnswer>(entity =>
            {
                entity.HasIndex(e => e.PresentationId)
                    .HasName("IDX_N_FK_PresentationAnswer_PresentationId");

                entity.Property(e => e.AnswerText)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.AnsweredDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionText).HasColumnType("varchar(500)");

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.PresentationAnswer)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PresentationAssignment>(entity =>
            {
                entity.HasIndex(e => e.PresentationGroupTypeId)
                    .HasName("IDX_N_FK_PresentationAssignment_PresentationGroupTypeId");

                entity.HasIndex(e => e.PresentationId)
                    .HasName("IDX_N_FK_PresentationAssignment_PresentationId");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.PresentationGroupType)
                    .WithMany(p => p.PresentationAssignment)
                    .HasForeignKey(d => d.PresentationGroupTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.PresentationAssignment)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PresentationFile>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DisplayName).HasMaxLength(150);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Subunits).HasMaxLength(500);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<PresentationGroupType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PresentationPresentationFile>(entity =>
            {
                entity.HasIndex(e => e.PresentationFileId)
                    .HasName("IDX_N_FK_PresentationPresentationFile_PresentationFileId");

                entity.HasIndex(e => e.PresentationId)
                    .HasName("IDX_N_FK_PresentationPresentationFile_PresentationId");

                entity.Property(e => e.LastUpdateBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.PresentationFile)
                    .WithMany(p => p.PresentationPresentationFile)
                    .HasForeignKey(d => d.PresentationFileId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.PresentationPresentationFile)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PresentationQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK_PresentationQuestion");

                entity.HasIndex(e => e.PresentationFileId)
                    .HasName("IDX_N_FK_PresentationQuestion_PresentationFileId");

                entity.HasIndex(e => e.PresentationId)
                    .HasName("IDX_N_FK_PresentationQuestion_PresentationId");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.PresentationFile)
                    .WithMany(p => p.PresentationQuestion)
                    .HasForeignKey(d => d.PresentationFileId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.PresentationQuestion)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PresentationQuestionAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .HasName("PK_PresentationQuestionAnswer");

                entity.HasIndex(e => e.QuestionId)
                    .HasName("IDX_N_FK_PresentationQuestionAnswer_QuestionId");

                entity.Property(e => e.AnswerText)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdateBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.PresentationQuestionAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<PresentationQuestionType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PresentationUserType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(25);
            });

            modelBuilder.Entity<PresentationViewLog>(entity =>
            {
                entity.HasKey(e => e.ViewId)
                    .HasName("PK_PresentationViewLog");

                entity.HasIndex(e => e.PresentationId)
                    .HasName("IDX_N_FK_PresentationViewLog_PresentationId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PresentationPosition)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ViewDate).HasColumnType("datetime");

                entity.HasOne(d => d.Presentation)
                    .WithMany(p => p.PresentationViewLog)
                    .HasForeignKey(d => d.PresentationId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<QbInquiry>(entity =>
            {
                entity.HasKey(e => e.InquiryId)
                    .HasName("PK_qbInquiry");

                entity.ToTable("qbInquiry");

                entity.HasIndex(e => e.InquiryTypeId)
                    .HasName("IDX_N_FK_qbInquiry_InquiryTypeID");

                entity.HasIndex(e => e.ResponseStateId)
                    .HasName("IDX_N_FK_qbInquiry_ResponseStateID");

                entity.HasIndex(e => e.Smeid)
                    .HasName("IDX_N_FK_qbInquiry_SMEID");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IDX_N_FK_qbInquiry_SubjectID");

                entity.Property(e => e.InquiryId).HasColumnName("InquiryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InquiryText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.InquiryTypeId).HasColumnName("InquiryTypeID");

                entity.Property(e => e.OtherSubject).HasMaxLength(200);

                entity.Property(e => e.ResponseStateId).HasColumnName("ResponseStateID");

                entity.Property(e => e.ResponseXhtml).HasColumnName("ResponseXHTML");

                entity.Property(e => e.ReviewerName).HasMaxLength(100);

                entity.Property(e => e.Smeid).HasColumnName("SMEID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SubmitterPortalUserId).HasColumnName("SubmitterPortalUserID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.InquiryType)
                    .WithMany(p => p.QbInquiry)
                    .HasForeignKey(d => d.InquiryTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ResponseState)
                    .WithMany(p => p.QbInquiry)
                    .HasForeignKey(d => d.ResponseStateId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Sme)
                    .WithMany(p => p.QbInquiry)
                    .HasForeignKey(d => d.Smeid);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.QbInquiry)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<QbInquiryAudit>(entity =>
            {
                entity.HasKey(e => e.InquiryAuditId)
                    .HasName("PK_qbInquiryAudit");

                entity.ToTable("qbInquiryAudit");

                entity.HasIndex(e => e.InquiryId)
                    .HasName("IDX_N_FK_qbInquiryAudit_InquiryID");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("IDX_N_FK_qbInquiryAudit_SubjectID");

                entity.Property(e => e.InquiryAuditId).HasColumnName("InquiryAuditID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InquiryId).HasColumnName("InquiryID");

                entity.Property(e => e.InquiryText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OtherSubject).HasMaxLength(200);

                entity.Property(e => e.ResponseStateId).HasColumnName("ResponseStateID");

                entity.Property(e => e.ResponseXhtml).HasColumnName("ResponseXHTML");

                entity.Property(e => e.Smeid).HasColumnName("SMEID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Inquiry)
                    .WithMany(p => p.QbInquiryAudit)
                    .HasForeignKey(d => d.InquiryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.QbInquiryAudit)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<QbInquiryType>(entity =>
            {
                entity.HasKey(e => e.InquiryTypeId)
                    .HasName("PK_qbInquiryType");

                entity.ToTable("qbInquiryType");

                entity.Property(e => e.InquiryTypeId)
                    .HasColumnName("InquiryTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QbResponseState>(entity =>
            {
                entity.HasKey(e => e.ResponseStateId)
                    .HasName("PK_qbResponseState");

                entity.ToTable("qbResponseState");

                entity.Property(e => e.ResponseStateId).HasColumnName("ResponseStateID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QbResponseStatePermission>(entity =>
            {
                entity.HasKey(e => e.ResponseStatePermissionId)
                    .HasName("PK_qbResponseStatePermission");

                entity.ToTable("qbResponseStatePermission");

                entity.HasIndex(e => e.ResponseStateId)
                    .HasName("IDX_N_FK_qbResponseStatePermission_ResponseStateID");

                entity.Property(e => e.ResponseStatePermissionId).HasColumnName("ResponseStatePermissionID");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.ResponseStateId).HasColumnName("ResponseStateID");

                entity.HasOne(d => d.ResponseState)
                    .WithMany(p => p.QbResponseStatePermission)
                    .HasForeignKey(d => d.ResponseStateId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<QbResponseStateTransition>(entity =>
            {
                entity.HasKey(e => e.ResponseStateTransitionId)
                    .HasName("PK_qbResponseStateTransition");

                entity.ToTable("qbResponseStateTransition");

                entity.HasIndex(e => e.ResponseStateId)
                    .HasName("IDX_N_FK_qbResponseStateTransition_ResponseStateID");

                entity.HasIndex(e => e.TransitionToStateId)
                    .HasName("IDX_N_FK_qbResponseStateTransition_TransitionToStateID");

                entity.Property(e => e.ResponseStateTransitionId).HasColumnName("ResponseStateTransitionID");

                entity.Property(e => e.ResponseStateId).HasColumnName("ResponseStateID");

                entity.Property(e => e.TransitionToStateId).HasColumnName("TransitionToStateID");

                entity.HasOne(d => d.ResponseState)
                    .WithMany(p => p.QbResponseStateTransitionResponseState)
                    .HasForeignKey(d => d.ResponseStateId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.TransitionToState)
                    .WithMany(p => p.QbResponseStateTransitionTransitionToState)
                    .HasForeignKey(d => d.TransitionToStateId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<QbSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId)
                    .HasName("PK_qbSubject");

                entity.ToTable("qbSubject");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<QbSubjectMatterExpert>(entity =>
            {
                entity.HasKey(e => e.Smeid)
                    .HasName("PK_qbSubjectMatterExpert");

                entity.ToTable("qbSubjectMatterExpert");

                entity.Property(e => e.Smeid).HasColumnName("SMEID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("1");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PhotoFileId).HasColumnName("PhotoFileID");
            });

            modelBuilder.Entity<ReservedUsername>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("IDX_U_ReservedUsername_UserName")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_N_Role_Name");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.IsSystemRole).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasIndex(e => e.PermissionId)
                    .HasName("IDX_N_RolePermission_PermissionID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IDX_N_RolePermission_RoleID");

                entity.HasIndex(e => new { e.RoleId, e.PermissionId, e.IsActive })
                    .HasName("IDX_N_RolePermission_RoleID_PermissionID_IsActive");

                entity.Property(e => e.RolePermissionId).HasColumnName("RolePermissionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SelfRegistrationConfiguration>(entity =>
            {
                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<SelfRegistrationSearchPreference>(entity =>
            {
                entity.HasIndex(e => new { e.StudentId, e.TermId })
                    .HasName("IX_SelfRegistrationSearchPreference_Studentid_Termid");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SelectedDays)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SelectedTimes)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<StudentAccountProvisioning>(entity =>
            {
                entity.HasKey(e => e.SyStudentId)
                    .HasName("PK_StudentAccountProvisioning");

                entity.Property(e => e.SyStudentId)
                    .HasColumnName("syStudentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(25)");

                entity.Property(e => e.Imported).HasDefaultValueSql("0");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastName).HasColumnType("varchar(25)");

                entity.Property(e => e.Message).HasColumnType("varchar(max)");

                entity.Property(e => e.Password).HasColumnType("varchar(16)");

                entity.Property(e => e.PortalUsername).HasMaxLength(50);

                entity.Property(e => e.SyCampusId).HasColumnName("syCampusID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserName).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<StudentAccountProvisioningMapping>(entity =>
            {
                entity.HasKey(e => e.SyStudentId)
                    .HasName("PK_StudentAccountProvisioningMapping");

                entity.Property(e => e.SyStudentId)
                    .HasColumnName("syStudentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IStudentId).HasColumnName("iStudentID");
            });

            modelBuilder.Entity<StudentFormsLog>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.OverAllGradePoint).HasColumnType("decimal");

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<StudentGradeRequest>(entity =>
            {
                entity.Property(e => e.StudentGradeRequestId).HasColumnName("StudentGradeRequestID");

                entity.Property(e => e.AdCourseId).HasColumnName("AdCourseID");

                entity.Property(e => e.AdTermId).HasColumnName("AdTermID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.OverallGradePoint).HasColumnType("decimal");

                entity.Property(e => e.RequestType).HasColumnType("varchar(3)");

                entity.Property(e => e.StudentGradeRequestReasonId).HasColumnName("StudentGradeRequestReasonID");

                entity.Property(e => e.SyStaffId).HasColumnName("SyStaffID");

                entity.Property(e => e.SyStudentId).HasColumnName("SyStudentID");

                entity.HasOne(d => d.StudentGradeRequestReason)
                    .WithMany(p => p.StudentGradeRequest)
                    .HasForeignKey(d => d.StudentGradeRequestReasonId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<StudentGradeRequestReason>(entity =>
            {
                entity.Property(e => e.StudentGradeRequestReasonId).HasColumnName("StudentGradeRequestReasonID");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ReasonDesc).HasColumnType("varchar(150)");

                entity.Property(e => e.StudentGradeRequestReasonTypeId).HasColumnName("StudentGradeRequestReasonTypeID");

                entity.HasOne(d => d.StudentGradeRequestReasonType)
                    .WithMany(p => p.StudentGradeRequestReason)
                    .HasForeignKey(d => d.StudentGradeRequestReasonTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<StudentGradeRequestReasonType>(entity =>
            {
                entity.Property(e => e.StudentGradeRequestReasonTypeId).HasColumnName("StudentGradeRequestReasonTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ReasonTypeDesc)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<StudentPlacementExam>(entity =>
            {
                entity.Property(e => e.StudentPlacementExamId).HasColumnName("StudentPlacementExamID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("0");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PlacementExamId).HasColumnName("PlacementExamID");

                entity.Property(e => e.Processed).HasDefaultValueSql("0");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.UpdatedBy).HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<StudentTutor>(entity =>
            {
                entity.Property(e => e.CatalogNumber).HasColumnType("varchar(15)");

                entity.Property(e => e.CourseSection).HasColumnType("varchar(10)");

                entity.Property(e => e.CreatedBy).HasColumnType("varchar(100)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasColumnType("varchar(100)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SystemCheckComponentType>(entity =>
            {
                entity.HasIndex(e => e.BrowserHawkId)
                    .HasName("IDX_N_SystemCheckComponentType_BrowserHawkID");

                entity.HasIndex(e => e.ComponentName)
                    .HasName("IDX_N_SystemCheckComponentType_ComponentName");

                entity.Property(e => e.SystemCheckComponentTypeId).HasColumnName("SystemCheckComponentTypeID");

                entity.Property(e => e.BrowserHawkId)
                    .HasColumnName("BrowserHawkID")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ComponentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Xhtmlquestion).HasColumnName("XHTMLQuestion");
            });

            modelBuilder.Entity<SystemCheckUserStatus>(entity =>
            {
                entity.HasIndex(e => e.PortalUserId)
                    .HasName("IDX_N_SystemCheckUserStatus_PortalUserID");

                entity.HasIndex(e => e.SystemCheckComponentTypeId)
                    .HasName("IDX_N_SystemCheckUserStatus_SystemCheckComponentTypeID");

                entity.Property(e => e.SystemCheckUserStatusId).HasColumnName("SystemCheckUserStatusID");

                entity.Property(e => e.ComponentDetails).HasMaxLength(400);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.PortalUserId).HasColumnName("PortalUserID");

                entity.Property(e => e.SystemCheckComponentTypeId).HasColumnName("SystemCheckComponentTypeID");

                entity.Property(e => e.TestedDateTime).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.HasOne(d => d.PortalUser)
                    .WithMany(p => p.SystemCheckUserStatus)
                    .HasForeignKey(d => d.PortalUserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.SystemCheckComponentType)
                    .WithMany(p => p.SystemCheckUserStatus)
                    .HasForeignKey(d => d.SystemCheckComponentTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<TranscriptInstitute>(entity =>
            {
                entity.HasKey(e => e.InstitutionId)
                    .HasName("PK_TranscriptInstitute");

                entity.Property(e => e.InstitutionId).HasColumnName("InstitutionID");

                entity.Property(e => e.Address1).HasColumnType("nchar(250)");

                entity.Property(e => e.Address2).HasColumnType("nchar(250)");

                entity.Property(e => e.City).HasColumnType("nchar(250)");

                entity.Property(e => e.Country).HasColumnType("nchar(250)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnType("nchar(10)");

                entity.Property(e => e.Name).HasColumnType("nchar(250)");

                entity.Property(e => e.State).HasColumnType("nchar(250)");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnType("nchar(10)");

                entity.Property(e => e.Zip).HasColumnType("nchar(250)");
            });

            modelBuilder.Entity<TranscriptItemCost>(entity =>
            {
                entity.Property(e => e.TranscriptItemCostId).HasColumnName("TranscriptItemCostID");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TranscriptList>(entity =>
            {
                entity.HasIndex(e => new { e.Amount, e.NumberOfCopies, e.TranscriptSessionId })
                    .HasName("IDX_N_TranscriptList_TranscriptSessionID_Incl_Amount_NumberOfCopies");

                entity.Property(e => e.TranscriptListId).HasColumnName("TranscriptListID");

                entity.Property(e => e.Address).HasColumnType("varchar(250)");

                entity.Property(e => e.Address2).HasColumnType("varchar(250)");

                entity.Property(e => e.Address3).HasColumnType("varchar(250)");

                entity.Property(e => e.Amount).HasColumnType("decimal");

                entity.Property(e => e.City).HasColumnType("varchar(250)");

                entity.Property(e => e.Country).HasColumnType("varchar(250)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.InstituteId)
                    .HasColumnName("InstituteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostalCode).HasColumnType("varchar(250)");

                entity.Property(e => e.ProcessingId)
                    .HasColumnName("ProcessingID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PurposeId)
                    .HasColumnName("PurposeID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recipient1).HasMaxLength(250);

                entity.Property(e => e.Recipient2).HasMaxLength(250);

                entity.Property(e => e.Region).HasColumnType("varchar(250)");

                entity.Property(e => e.SendToId).HasColumnName("SendToID");

                entity.Property(e => e.TranscriptSessionId).HasColumnName("TranscriptSessionID");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TranscriptPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeId)
                    .HasName("PK_TranscriptPayment");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TranscriptProcessing>(entity =>
            {
                entity.HasKey(e => e.ProcessingId)
                    .HasName("PK_TranscriptProcessing");

                entity.Property(e => e.ProcessingId).HasColumnName("ProcessingID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TranscriptPurpose>(entity =>
            {
                entity.HasKey(e => e.PurposeId)
                    .HasName("PK_TranscriptPurpose");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TranscriptReceiver>(entity =>
            {
                entity.HasKey(e => e.SendToId)
                    .HasName("PK_TranscriptReceiver");

                entity.Property(e => e.SendToId).HasColumnName("SendToID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.SendTo)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TranscriptSession>(entity =>
            {
                entity.HasIndex(e => e.PaymentTypeId)
                    .HasName("IDX_N_TranscriptSession_PaymentTypeID");

                entity.HasIndex(e => new { e.StudentId, e.IsSent })
                    .HasName("IDX_N_TranscriptSession_StudentID_IsSent");

                entity.Property(e => e.TranscriptSessionId).HasColumnName("TranscriptSessionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsSent).HasDefaultValueSql("0");

                entity.Property(e => e.PaymentTypeId)
                    .HasColumnName("PaymentTypeID")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.TotalFee).HasColumnType("numeric");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserMappingType>(entity =>
            {
                entity.Property(e => e.UserMappingTypeId)
                    .HasColumnName("UserMappingTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.HasIndex(e => e.UserStatusTypeId)
                    .HasName("IDX_N_FK_UserStatus_UserStatusTypeID");

                entity.HasIndex(e => new { e.CampusId, e.Status })
                    .HasName("IDX_N_UserStatus_CampusID_Status");

                entity.Property(e => e.UserStatusId).HasColumnName("UserStatusID");

                entity.Property(e => e.BlockActive).HasDefaultValueSql("0");

                entity.Property(e => e.BlockComment).HasMaxLength(250);

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserStatusTypeId).HasColumnName("UserStatusTypeID");

                entity.HasOne(d => d.UserStatusType)
                    .WithMany(p => p.UserStatus)
                    .HasForeignKey(d => d.UserStatusTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<UserStatusFunctionality>(entity =>
            {
                entity.HasIndex(e => e.FunctionalityId)
                    .HasName("IDX_N_FK_UserStatusFunctionality_FunctionalityID");

                entity.HasIndex(e => e.UserStatusId)
                    .HasName("IDX_N_FK_UserStatusFunctionality_UserStatusID");

                entity.Property(e => e.UserStatusFunctionalityId).HasColumnName("UserStatusFunctionalityID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.FunctionalityId).HasColumnName("FunctionalityID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserStatusId).HasColumnName("UserStatusID");

                entity.HasOne(d => d.Functionality)
                    .WithMany(p => p.UserStatusFunctionality)
                    .HasForeignKey(d => d.FunctionalityId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UserStatus)
                    .WithMany(p => p.UserStatusFunctionality)
                    .HasForeignKey(d => d.UserStatusId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<UserStatusType>(entity =>
            {
                entity.Property(e => e.UserStatusTypeId)
                    .HasColumnName("UserStatusTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasIndex(e => e.VendorCode)
                    .HasName("IDX_N_Vendor_VendorCode");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VendorCode)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<VendorEncryptionType>(entity =>
            {
                entity.Property(e => e.VendorEncryptionTypeId).HasColumnName("VendorEncryptionTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VendorLink>(entity =>
            {
                entity.HasIndex(e => e.LinkCode)
                    .HasName("IDX_N_VendorLink_LinkCode");

                entity.HasIndex(e => e.VendorEncryptionTypeId)
                    .HasName("IDX_N_VendorLink_VendorEncryptionTypeID");

                entity.HasIndex(e => e.VendorId)
                    .HasName("IDX_N_VendorLink_VendorID");

                entity.Property(e => e.VendorLinkId).HasColumnName("VendorLinkID");

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Href)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.LinkCode).HasColumnType("varchar(10)");

                entity.Property(e => e.LinkText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VendorEncryptionTypeId).HasColumnName("VendorEncryptionTypeID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorKey)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.VendorPassword).HasColumnType("varchar(100)");

                entity.HasOne(d => d.VendorEncryptionType)
                    .WithMany(p => p.VendorLink)
                    .HasForeignKey(d => d.VendorEncryptionTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorLink)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<VfsFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_vfsFile");

                entity.ToTable("vfsFile");

                entity.HasIndex(e => new { e.FolderId, e.FileName })
                    .HasName("IDX_NU_vfsFile_FolderID_FileName")
                    .IsUnique();

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Folder)
                    .WithMany(p => p.VfsFile)
                    .HasForeignKey(d => d.FolderId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<VfsFileAcl>(entity =>
            {
                entity.HasKey(e => e.FileAclid)
                    .HasName("PK_vfsFileACL");

                entity.ToTable("vfsFileACL");

                entity.HasIndex(e => e.Rolename)
                    .HasName("IDX_N_vfsFileACL_Rolename");

                entity.HasIndex(e => new { e.FileId, e.AppliesToType })
                    .HasName("IDX_N_vfsFileACL_FileID_AppliesToType");

                entity.Property(e => e.FileAclid).HasColumnName("FileACLID");

                entity.Property(e => e.AllowDenyPermission).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.PermissionSet).HasDefaultValueSql("0");

                entity.Property(e => e.Rolename).HasMaxLength(64);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.VfsFileAcl)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<VfsFileMetadata>(entity =>
            {
                entity.HasKey(e => e.FileMetadataId)
                    .HasName("PK_vfsFileMetadata");

                entity.ToTable("vfsFileMetadata");

                entity.HasIndex(e => new { e.FileId, e.MetadataKey })
                    .HasName("IDX_NU_vfsFileMetadata_FileID_MetadataKey")
                    .IsUnique();

                entity.Property(e => e.FileMetadataId).HasColumnName("FileMetadataID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.MetadataKey)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.File)
                    .WithMany(p => p.VfsFileMetadata)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<VfsFolder>(entity =>
            {
                entity.HasKey(e => e.FolderId)
                    .HasName("PK_vfsFolder");

                entity.ToTable("vfsFolder");

                entity.HasIndex(e => new { e.InheritPermissions, e.ParentFolderId, e.FolderName })
                    .HasName("IDX_NU_vfsFolder_ParentFolderID_FolderName_Incl_InheritPermissions")
                    .IsUnique();

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.FolderName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.InheritPermissions).HasDefaultValueSql("1");

                entity.Property(e => e.ParentFolderId)
                    .IsRequired()
                    .HasColumnName("ParentFolderID");

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ParentFolder)
                    .WithMany(p => p.InverseParentFolder)
                    .HasForeignKey(d => d.ParentFolderId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<VfsFolderAcl>(entity =>
            {
                entity.HasKey(e => e.FolderAclid)
                    .HasName("PK_vfsFolderACL");

                entity.ToTable("vfsFolderACL");

                entity.HasIndex(e => e.Rolename)
                    .HasName("IDX_N_vfsFolderACL_Rolename");

                entity.HasIndex(e => new { e.FolderId, e.AppliesToType })
                    .HasName("IDX_N_vfsFolderACL_FolderID_AppliesToType");

                entity.Property(e => e.FolderAclid).HasColumnName("FolderACLID");

                entity.Property(e => e.AllowDenyPermission).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.PermissionSet).HasDefaultValueSql("0");

                entity.Property(e => e.Rolename).HasMaxLength(64);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Folder)
                    .WithMany(p => p.VfsFolderAcl)
                    .HasForeignKey(d => d.FolderId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<VfsFolderMetadata>(entity =>
            {
                entity.HasKey(e => e.FolderMetadataId)
                    .HasName("PK_vfsFolderMetadata");

                entity.ToTable("vfsFolderMetadata");

                entity.HasIndex(e => new { e.FolderId, e.MetadataKey })
                    .HasName("IDX_NU_vfsFolderMetadata_FolderID_MetadataKey")
                    .IsUnique();

                entity.Property(e => e.FolderMetadataId).HasColumnName("FolderMetadataID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.MetadataKey)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Folder)
                    .WithMany(p => p.VfsFolderMetadata)
                    .HasForeignKey(d => d.FolderId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<VuwebAdminResources>(entity =>
            {
                entity.HasKey(e => e.Pk)
                    .HasName("PK_VUWebAdminResources");

                entity.ToTable("VUWebAdminResources");

                entity.Property(e => e.Pk).HasColumnName("pk");

                entity.Property(e => e.BinFile).HasColumnType("image");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LocaleId)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ResourceId)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ResourceSet)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TextFile).HasColumnType("ntext");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VuwebResources>(entity =>
            {
                entity.HasKey(e => e.Pk)
                    .HasName("PK_VUWebResources");

                entity.ToTable("VUWebResources");

                entity.Property(e => e.Pk).HasColumnName("pk");

                entity.Property(e => e.BinFile).HasColumnType("image");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LocaleId)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ResourceId)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ResourceSet)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TextFile).HasColumnType("ntext");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ZmProgramCalendarEvent>(entity =>
            {
                entity.HasKey(e => e.ProgramCalendarEventId)
                    .HasName("PK_zmProgramCalendarEvent");

                entity.ToTable("zmProgramCalendarEvent");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Details).HasMaxLength(1000);

                entity.Property(e => e.IsActive).HasDefaultValueSql("1");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZmProgramCalendarEventInstance>(entity =>
            {
                entity.HasKey(e => e.ProgramCalendarEventInstanceId)
                    .HasName("PK_zmProgramCalendarEventInstance");

                entity.ToTable("zmProgramCalendarEventInstance");

                entity.HasIndex(e => e.ProgramCalendarEventId)
                    .HasName("IDX_N_FK_zmProgramCalendarEventInstance_ProgramCalendarEventId");

                entity.Property(e => e.CalendarEventInviteId).HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .IsRequired()
                    .HasColumnName("ts")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedBy).HasMaxLength(64);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProgramCalendarEvent)
                    .WithMany(p => p.ZmProgramCalendarEventInstance)
                    .HasForeignKey(d => d.ProgramCalendarEventId);
            });
        }
    }
}
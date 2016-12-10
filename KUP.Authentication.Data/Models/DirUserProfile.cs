using System;
using System.Collections.Generic;

namespace KUP.Authentication.Data.Models
{
    public partial class DirUserProfile
    {
        public DirUserProfile()
        {
            DirEducationHistory = new HashSet<DirEducationHistory>();
            DirUserAffiliation = new HashSet<DirUserAffiliation>();
            DirUserComplaint = new HashSet<DirUserComplaint>();
            DirUserContactRequest = new HashSet<DirUserContactRequest>();
            DirUserPrivacySetting = new HashSet<DirUserPrivacySetting>();
            DirWorkHistory = new HashSet<DirWorkHistory>();
        }

        public int PortalUserId { get; set; }
        public byte DirTitleIdPrefix { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string BirthCity { get; set; }
        public int? StateProvinceIdBirth { get; set; }
        public short? DirCountryIdBirth { get; set; }
        public string Im { get; set; }
        public string Bio { get; set; }
        public string Interests { get; set; }
        public string NonKaplanSocietyData { get; set; }
        public string ResumeFileName { get; set; }
        public bool? IsUserAgreementAccepted { get; set; }
        public string PhotoFileName { get; set; }
        public bool? IsPhotoAgreementAccepted { get; set; }
        public bool? IsPhotoApproved { get; set; }
        public bool PermitAllContacts { get; set; }
        public int? LanguageId { get; set; }
        public DateTime DateCreated { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<DirEducationHistory> DirEducationHistory { get; set; }
        public virtual ICollection<DirUserAffiliation> DirUserAffiliation { get; set; }
        public virtual ICollection<DirUserComplaint> DirUserComplaint { get; set; }
        public virtual ICollection<DirUserContactRequest> DirUserContactRequest { get; set; }
        public virtual ICollection<DirUserPrivacySetting> DirUserPrivacySetting { get; set; }
        public virtual ICollection<DirWorkHistory> DirWorkHistory { get; set; }
        public virtual DirCountry DirCountryIdBirthNavigation { get; set; }
        public virtual DirTitle DirTitleIdPrefixNavigation { get; set; }
        public virtual PortalUser PortalUser { get; set; }
        public virtual DirStateProvince StateProvinceIdBirthNavigation { get; set; }
    }
}

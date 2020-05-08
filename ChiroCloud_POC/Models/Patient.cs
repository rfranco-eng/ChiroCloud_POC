using System;
using System.Collections.Generic;

namespace ChiroCloud_POC.Models
{
    public partial class Patient
    {
        public int Id { get; set; }
        public int? EmployerId { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string NameMiddle { get; set; }
        public string NamePreferred { get; set; }
        public string NamePrefix { get; set; }
        public string NameSuffix { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Gender { get; set; }
        public string SocialSecurityNo { get; set; }
        public string DoctorName { get; set; }
        public string PreferredComm { get; set; }
        public string CommLanguage { get; set; }
        public string PreferredPronouns { get; set; }
        public string SexualOrientation { get; set; }
        public string Active { get; set; }
        public string DriversLicense { get; set; }
        public string DriversLicenseState { get; set; }
        public string MaritalStatus { get; set; }
        public string Race { get; set; }
        public string Ethnicity { get; set; }
    }
}

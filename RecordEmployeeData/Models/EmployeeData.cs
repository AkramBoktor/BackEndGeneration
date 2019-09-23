using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecordEmployeeData.Models
{
    public class EmployeeData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string EmployeeCode‏ { get; set; }

        public string EmployeeName { get; set; }

        public int? BirthPlace { get; set; }

        public string MotherName { get; set; }

        public int? Gender { get; set; }

        public string IDNumber { get; set; }

        public string IssuerCode { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? Nationality { get; set; }

        public int? Religion { get; set; }

        public string EmployeeAddress { get; set; }

        public int? SectionCenter { get; set; }

        public int? Governorate { get; set; }

        public string TelephoneNumber { get; set; }

        public int? SocialStatus { get; set; }

        public string LastQualifiedCode { get; set; }

        public DateTime? LastQualifiedDate { get; set; }

        public int? Specialization { get; set; }

        public int? JobTitle { get; set; }

        public int? JobGroup { get; set; }

        public int? FanaticalDegree { get; set; }

        public int? AppointmentType { get; set; }

        public string DecisionNumber { get; set; }

        public DateTime? DecisionDate { get; set; }

        public DateTime? ReceiptDate { get; set; }

        public int? CentralAdministration { get; set; }

        public int? SubAdministration { get; set; }

        public DateTime? SeniorityHistoryDate { get; set; }

        public int? EmployeeStatus { get; set; }

        public DateTime? LevelDate { get; set; }

        public DateTime? CurrentJobDate { get; set; }

        public DateTime? LastFinancialDisclosure { get; set; }
    }
}

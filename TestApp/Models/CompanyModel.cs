using System.ComponentModel.DataAnnotations;

namespace TestApp.Models {
    public class CompanyModel {
        [Key]
        public int employeeId { get; set; }

        [StringLength(200)]
        public string employeeName { get; set; }
    }
}

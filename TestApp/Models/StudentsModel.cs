using System.ComponentModel.DataAnnotations;

namespace TestApp.Models {
    public class StudentsModel {
        [Key]
        public int Id { get; set; }

        public string Names { get; set; }

        public string Last { get; set; }
    }
}

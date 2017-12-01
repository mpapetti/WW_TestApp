using System.ComponentModel.DataAnnotations;

namespace TestApp.Models {
    public class NewTableModel {
        [Key]
        public int id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}

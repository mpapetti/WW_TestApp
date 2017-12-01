using System.ComponentModel.DataAnnotations;

namespace TestApp.Models {
    public class TestTableModel {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
    }
}

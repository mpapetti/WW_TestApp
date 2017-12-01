using System.ComponentModel.DataAnnotations;

namespace TestApp.Models {
    class TestTableModel {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
    }
}

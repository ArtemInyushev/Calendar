using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Models {
    [Table("tasks")]
    public class Task {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Time { get; set; }
        public string Desc { get; set; }
    }
}

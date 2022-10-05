using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Labs.Models
{
    public class Student
    {
        [DisplayName("Mã sinh viên")]
        [MaxLength(10, ErrorMessage = "Tối đa 10 kí tự")]
        [RegularExpression(@"\d{2}0110[34]\d{3}", ErrorMessage = "Chưa đúng định dạng mã sinh viên")]
        public string Id { get;set; }

        [DisplayName("Họ tên sinh viên")]
        public string FullName{ get; set; }

        [DisplayName("Điểm sinh viên")]
        public float Mark { get; set; }

        [DisplayName("Loại")]
        public string Grade { 
            get {
                if (Mark >= 8.5) return "A";
                if (Mark >= 7.8) return "B";
                if (Mark >= 5) return "C";
                return "D"; 
            } 
        }


    }
}

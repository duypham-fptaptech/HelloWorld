using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Models
{
    public class StudentList
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Image { get; set; }
    }
    public class StudenListManager
    {
        public static List<StudentList> GetBooks()
        {
            var studentList = new List<StudentList>();
            studentList.Add(new StudentList { Name = "Phạm Đức Duy", Year = "2002", Image = "Assets/male.png" });
            studentList.Add(new StudentList { Name = "Nguyễn Tiến Nhật", Year = "2002", Image = "Assets/male.png" });
            studentList.Add(new StudentList { Name = "Nguyễn Văn Hùng", Year = "2001", Image = "Assets/male.png" });
            studentList.Add(new StudentList { Name = "Trần Anh ĐỨc", Year = "2001", Image = "Assets/male.png" });

            return studentList;
        }
    }
}

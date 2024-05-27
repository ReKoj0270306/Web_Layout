using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class StudentDetails
    {
        public Student GetStudentDetails(int StudentId)
        {
            Student employee = new Student()
            {
                StudentID = StudentID,
                StudentName = "HoTenSinhVien",
                StudentAge = 21,
                Gender = "Nam",
                ClassStudent = "20DTH2B",
                StudentCource = "K20",
                StudentAddress = "DiachiSinhvien"
            };
            return Student;
        }
    }
}
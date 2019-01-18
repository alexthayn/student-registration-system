using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electro.StudentAggregate
{
    public class Student
    {
        private StudentId studentId;
        public StudentId StudentId { get; } 

        private PersonalInfo personalInfo;
        public PersonalInfo PersonalInfo { get; set; }

        private ContactInfo contactInfo;
        public ContactInfo ContactInfo { get; set; }

        private AddressInfo addressInfo;
        public AddressInfo AddressInfo { get; set; }

        private Courses courses;
        public Courses Courses { get; set; }

        private StudentType studentType;
        public StudentType StudentType { get; set; }

        public Student(PersonalInfo personalInfo, ContactInfo contactInfo, AddressInfo addressInfo, Courses courses, StudentType studentType)
        {
            StudentId.Id = StudentId.Generate();
            PersonalInfo = personalInfo;
            ContactInfo = contactInfo;
            AddressInfo = addressInfo;
            Courses = courses;
            StudentType = studentType;
        }
    }

    public class StudentId
    {
        public int Id { get; set; } //Unique Id

        public int Generate()
        {
            Id = 5;
            return Id;
        }
    }
}

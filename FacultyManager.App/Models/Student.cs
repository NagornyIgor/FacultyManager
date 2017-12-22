using FacultyManager.Applicatiion.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Applicatiion.Models
{
    public class Student : ObservableObject
    {
        private int? _id;
        public int? Id
        {
            get
            { return _id; }
            set
            {
                _id = value;
                RisePropertyChangedEvent("Id");
            }
        }

        private string _name;
        public string Name
        {
            get
            { return _name; }
            set
            {
                _name = value;
                RisePropertyChangedEvent("Name");
            }
        }

        private string _surname;
        public string Surname
        {
            get
            { return _surname; }
            set
            {
                _surname = value;
                RisePropertyChangedEvent("Surname");
            }
        }

        private int _age;
        public int Age
        {
            get
            { return _age; }
            set
            {
                _age = value;
                RisePropertyChangedEvent("Age");
            }
        }

        private int _departmentId;
        public int DepartmentId
        {
            get
            { return _departmentId; }
            set
            {
                _departmentId = value;
                RisePropertyChangedEvent("DepartmentId");
            }
        }


        private int _teacherId;
        public int TeacherId
        {
            get
            { return _teacherId; }
            set
            {
                _teacherId = value;
                RisePropertyChangedEvent("TeacherId");
            }
        }
    }
}

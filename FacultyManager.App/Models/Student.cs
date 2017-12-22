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
        public int _id;
        public int Id
        {
            get
            { return _id; }
            set
            {
                _id = value;
                RisePropertyChangedEvent("Id");
            }
        }

        public string _name;
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

        public string _surname;
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

        public int _age;
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

        public int _departmentId;
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


        public int _teacherId;
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

        public void DoSomth()
        {

        }
    }
}

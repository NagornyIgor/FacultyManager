using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacultyManager.Applicatiion;
using FacultyManager.Applicatiion.Common;

namespace FacultyManager.Applicatiion.Models
{
    public class Department : ObservableObject
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

        public int _departmentCode;
        public int DepartmentCode
        {
            get
            { return _departmentCode; }
            set
            {
                _departmentCode = value;
                RisePropertyChangedEvent("DepartmentCode");
            }
        }
    }
}

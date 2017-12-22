using FacultyManager.Applicatiion.Common;
using FacultyManager.Applicatiion.Models;
using FacultyManager.Applicatiion.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Applicatiion.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public readonly string[] getDataMethods = { "Get all students", "Get ordered by teacher", "Get ordered by department" };

        public GetData getData = new GetData();

        private ObservableCollection<Teacher> _teachers { get; set; }
        private ObservableCollection<Student> _students { get; set; }
        private ObservableCollection<Department> _departments { get; set; }

        public MainWindowViewModel()
        {
            teachers = new ObservableCollection<Teacher>();
            students = new ObservableCollection<Student>();
            departments = new ObservableCollection<Department>();
        }

        public ObservableCollection<Teacher> teachers
        {
            get { return _teachers; }
            set
            {
                _teachers = value;
                RisePropertyChangedEvent("teachers");
            }
        }

        public ObservableCollection<Student> students
        {
            get { return _students; }
            set
            {
                _students = value;
                RisePropertyChangedEvent("students");
            }
        }

        public ObservableCollection<Department> departments
        {
            get { return _departments; }
            set
            {
                _departments = value;
                RisePropertyChangedEvent("departments");
            }
        }



    }
}

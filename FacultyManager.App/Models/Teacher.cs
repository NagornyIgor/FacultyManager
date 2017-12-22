using FacultyManager.Applicatiion.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Applicatiion.Models
{
    public class Teacher : ObservableObject
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

        public string _rank;
        public string Rank
        {
            get
            { return _rank; }
            set
            {
                _rank = value;
                RisePropertyChangedEvent("Rank");
            }
        }

        public string _course;
        public string Сourse
        {
            get
            { return _course; }
            set
            {
                _course = value;
                RisePropertyChangedEvent("Сourse");
            }
        }
    }
}

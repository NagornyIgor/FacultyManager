using FacultyManager.Applicatiion.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Applicatiion.Models
{
    public class Departments : ObservableCollection<Department>
    {
        public Departments()
        {
            this.AddRange(GetData.GetDepartments());
        }
    }
}

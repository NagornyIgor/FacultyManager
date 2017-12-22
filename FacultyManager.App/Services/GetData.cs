using FacultyManager.Applicatiion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FacultyManager.Applicatiion.Services
{
    public class GetData
    {
        private static ApiService apiService;

        public GetData()
        {
            apiService = new ApiService();
        }

        public static async Task<ObservableCollection<Department>> GetDepartments()
        {
            var dataDepartment = await apiService.GetAsync<ObservableCollection<Department>>("department");

            if (!dataDepartment.Succeeded)
            {
                MessageBox.Show(dataDepartment.Errors.ToString());
            }
            return dataDepartment.Data;
        }

        public static async Task<ObservableCollection<Teacher>> GetTeachers()
        {
            var dataDepartment = await apiService.GetAsync<ObservableCollection<Teacher>>("teacher");

            if (!dataDepartment.Succeeded)
            {
                MessageBox.Show(dataDepartment.Errors.ToString());
            }
            return dataDepartment.Data;
        }

        public static async Task<ObservableCollection<Student>> GetStudents()
        {
            var dataDepartment = await apiService.GetAsync<ObservableCollection<Student>>("student");

            if (!dataDepartment.Succeeded)
            {
                MessageBox.Show(dataDepartment.Errors.ToString());
            }
            return dataDepartment.Data;
        }

        public static async Task<ObservableCollection<Student>> GetStudentsOrderedByDepartment(int id)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add(nameof(id), id.ToString());

            var dataDepartment = await apiService.GetAsync<ObservableCollection<Student>>("student/OrderByCurator/", parameters);

            if (!dataDepartment.Succeeded)
            {
                MessageBox.Show(dataDepartment.Errors.ToString());
            }
            return dataDepartment.Data;
        }

        public static async Task<ObservableCollection<Student>> GetStudentsOrderedByTeacher(int id)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add(nameof(id), id.ToString());

            var dataDepartment = await apiService.GetAsync<ObservableCollection<Student>>("student/OrderByDepartment/", parameters);

            if (!dataDepartment.Succeeded)
            {
                MessageBox.Show(dataDepartment.Errors.ToString());
            }
            return dataDepartment.Data;
        }
    }
}

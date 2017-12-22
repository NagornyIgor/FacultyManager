using FacultyManager.Applicatiion.Common;
using FacultyManager.Applicatiion.Models;
using FacultyManager.Applicatiion.Services;
using FacultyManager.Applicatiion.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FacultyManager.Applicatiion
{
    /// <summary>
    /// Interaction logic for AddStudentDialog.xaml
    /// </summary>
    public partial class AddStudentDialog : Window
    {
        private ApiService apiService;

        public AddStudentDialog(MainWindowViewModel viewModel)
        {

            InitializeComponent();

            apiService = new ApiService();
            departmentComboBox.ItemsSource = viewModel.departments.Select(d => d.Id);
            teacherComboBox.ItemsSource = viewModel.teachers.Select(t => t.Id);
        }

        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            var student = new PostStudent
            {
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                Age = int.Parse(ageTexBox.Text),
                DepartmentId = int.Parse(departmentComboBox.SelectedItem.ToString()),
                TeacherId = int.Parse(teacherComboBox.SelectedItem.ToString())
            };

            var result = apiService.PostAsync<Student, PostStudent>("student/add", student).Result;

            if (!result.Succeeded)
            {
                MessageBox.Show(result.Errors.ToString());
            };

            this.Close();
        }
    }
}

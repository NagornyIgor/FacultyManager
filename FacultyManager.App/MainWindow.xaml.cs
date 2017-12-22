using FacultyManager.Applicatiion.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FacultyManager.Applicatiion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowViewModel();
            getStudentMethodsComboBox.ItemsSource = viewModel.getDataMethods;
        }

        private async void getDepartmentsButton_Click(object sender, RoutedEventArgs e)
        {
            tableLable.Content = "Departments";
            viewModel.departments = await viewModel.getData.GetDepartments();
            MainWindowDataGrid.ItemsSource = viewModel.departments;
        }

        private async void getTeachersButton_Click(object sender, RoutedEventArgs e)
        {
            tableLable.Content = "Teachers";
            viewModel.teachers = await viewModel.getData.GetTeachers();
            MainWindowDataGrid.ItemsSource = viewModel.teachers;
        }

        private async void getStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            tableLable.Content = "Students";
            if (getStudentMethodsComboBox.SelectedItem != null)
            {
                if (getStudentMethodsComboBox.SelectedItem.ToString() == viewModel.getDataMethods[0])
                {
                    MainWindowDataGrid.ItemsSource = await viewModel.getData.GetStudents();
                }
                if(!string.IsNullOrWhiteSpace(idTextBox.Text))
                {
                    var id = int.Parse(idTextBox.Text);

                    if (getStudentMethodsComboBox.SelectedItem.ToString() == viewModel.getDataMethods[1])
                    {
                        MainWindowDataGrid.ItemsSource = await viewModel.getData.GetStudentsOrderedByDepartment(id);
                    }
                    if (getStudentMethodsComboBox.SelectedItem.ToString() == viewModel.getDataMethods[2])
                    {
                        MainWindowDataGrid.ItemsSource = await viewModel.getData.GetStudentsOrderedByTeacher(id);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the query!");
            }
        }

        private async void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if(!viewModel.departments.Any())
            {
                viewModel.departments = await viewModel.getData.GetDepartments();
            }
            if(!viewModel.teachers.Any())
            {
                viewModel.teachers = await viewModel.getData.GetTeachers();
            }

            AddStudentDialog addStudentDialog = new AddStudentDialog(viewModel);
            addStudentDialog.Show();
        }
    }
}

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
        public AddStudentDialog(MainWindowViewModel viewModel)
        {

            InitializeComponent();

            departmentComboBox.ItemsSource = viewModel.departments.Select(d => d.Id);
        }
    }
}

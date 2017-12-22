using AutoMapper;
using FacultyManager.Services.Dto;
using FacultyManager.Data;
using FacultyManager.Data.Models;
using FacultyManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Services.Services
{
    public interface IStudentService
    {
        IList<StudentDto> GetAll();
        IList<StudentDto> OrderByCurator(int curatorId);
        IList<StudentDto> OrderByDepartment(int departmentId);
        StudentDto CreateStudent(StudentDto newStudentDto);
    }

    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public IList<StudentDto> GetAll()
        {
            var students = studentRepository.GetAll();

            return Mapper.Map<IList<StudentDto>>(students);
        }

        public IList<StudentDto> OrderByCurator(int curatorId)
        {
            var orderedStudents = studentRepository.OrderByCurator(curatorId);

            return Mapper.Map<IList<StudentDto>>(orderedStudents);
        }

        public IList<StudentDto> OrderByDepartment(int departmentId)
        {
            var orderedStudents = studentRepository.OrderByDepartment(departmentId);

            return Mapper.Map<IList<StudentDto>>(orderedStudents);
        }

        public StudentDto CreateStudent(StudentDto newStudentDto)
        {
            var newStudent = Mapper.Map<Student>(newStudentDto);

            var result = studentRepository.Create(newStudent);
            studentRepository.Save();

            return Mapper.Map<StudentDto>(result);
        }
    }
}

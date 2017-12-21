using AutoMapper;
using FacultyManager.Services.Dto;
using FacultyManager.Data;
using FacultyManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Services.Services
{
    public interface ITeacherService
    {
        IList<TeacherDto> GetAll();
    }

    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> teacherRepository;

        public TeacherService(IRepository<Teacher> teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        public IList<TeacherDto> GetAll()
        {
            var teachers = teacherRepository.GetAll();

            return Mapper.Map<IList<TeacherDto>>(teachers);
        }
    }
}

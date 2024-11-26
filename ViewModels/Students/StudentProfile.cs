using AutoMapper;
using ExaminationSystem.Models;

using ExaminationSystem.ViewModels.Students;


namespace ExaminationSystem;

public class StudentProfile : AutoMapper.Profile
{
    public StudentProfile()
    {
        CreateMap<Student, StudentCreateViewModel>().ReverseMap();
        CreateMap<Student, StudentEditViewModel>().ReverseMap();
        CreateMap<Student, StudentViewModel>();

    }
}

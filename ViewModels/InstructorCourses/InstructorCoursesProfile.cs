﻿
using ExaminationSystem.Models;

using ExaminationSystem.ViewModels.InstructorCourses;

namespace ExaminationSystem;

public class InstructorCoursesProfile : AutoMapper.Profile
{
    public InstructorCoursesProfile()
    {
        CreateMap<InstructorCourse, InstructorCoursesViewModel>().ReverseMap();
    }
}
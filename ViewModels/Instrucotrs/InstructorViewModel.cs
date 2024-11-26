﻿using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.InstructorCourses;

namespace ExaminationSystem.ViewModels.Instrucotrs
{
    public class InstructorViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Adress { get; set; }

        public ICollection<InstructorCoursesViewModel> InstructorCourses { get; set; }
    }
}

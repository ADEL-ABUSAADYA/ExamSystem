﻿namespace ExaminationSystem.Models
{
    public class Course : BaseModel
    {
        public Course()
        {
            InstructorCourses = new List<InstructorCourse>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; }

    }
}

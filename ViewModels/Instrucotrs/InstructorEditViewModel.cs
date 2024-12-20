﻿using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Instrucotrs
{
    public class InstructorEditViewModel : InstructorCreateViewModel, IUpdatable
    {
        public int ID { get; set; }
        public string[] GetPropertyNames()
        {
            string[] propertyNames = {nameof(Name), nameof(Email), nameof(Adress), nameof(Mobile), nameof(Birthdate)};
            return propertyNames;
        }

        public int GetPropertyCount()
        {
            return GetPropertyNames().Count();
        }
    }
}

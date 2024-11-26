namespace ExaminationSystem.ViewModels.Courses;

public class CourseEditViewModel : CourseCreateViewModel, IUpdatable
{
    public int ID { get; set; }
    public string[] GetPropertyNames()
    {
        string[] propertyNames = { nameof(Name), nameof(Title), nameof(Description), nameof(StartDate), nameof(EndDate)};
        return propertyNames;
    }

    public int GetPropertyCount()
    {
        return GetPropertyNames().Count();
    }
}
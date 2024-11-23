namespace ExaminationSystem.ViewModels;

public class BaseViewModel : IUpdatable
{
    public int ID { get; set; }
    public bool Deleted { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string Name {get; set;}

    public virtual string[] GetPropertyNames()
    {
        return new string[0];
    }

    public virtual int GetPropertyCount()
    {
        return 0;
    }

}
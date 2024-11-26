using ExaminationSystem.ViewModels.Groups;

namespace ExaminationSystem.Services.Groups;

public interface IGroupService
{
    int Create(GroupCreateViewModel Group);
    GroupViewModel GetById(int id);
    IQueryable<GroupViewModel> GetAll();
    GroupViewModel GetByName(string name);
    bool UpdateGroup(GroupEditViewModel GroupEditViewModel);
    bool Delete(int id);
}
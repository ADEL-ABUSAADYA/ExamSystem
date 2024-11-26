using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Groups;
using ExaminationSystem.ViewModels.Groups;

namespace ExaminationSystem;

public class GroupService : IGroupService
{
    IRepository<Group> _GroupRepository;
    public GroupService(IRepository<Group> GroupRepository)
    {
        _GroupRepository = GroupRepository;
    }
    public int Create(GroupCreateViewModel GroupCreateViewModel)
    {
        var Group = GroupCreateViewModel.Map<Group>();
        _GroupRepository.Add(Group);
        _GroupRepository.SaveChanges();
        return Group.ID;
    }

    public GroupViewModel GetById(int id)
    {
       return  _GroupRepository.GetByID(id).MapFirstOrDefault<GroupViewModel>();
    }

    public IQueryable<GroupViewModel> GetAll()
    {
        return _GroupRepository.GetAll().ProjectTo<GroupViewModel>();
    }
    public GroupViewModel GetByName(string name)
    {
        return  _GroupRepository.Get(x => x.Name.Contains(name)).MapFirstOrDefault<GroupViewModel>();
    }

    public bool UpdateGroup(GroupEditViewModel GroupEditViewModel)
    {
        var Group = GroupEditViewModel.Map<Group>();
        var savedGroup = _GroupRepository.SaveInclude(Group, GroupEditViewModel.GetPropertyNames());
        _GroupRepository.SaveChanges();

        return savedGroup;
    }

    public bool Delete(int id)
    {
        bool isDeleted = _GroupRepository.Delete(new Group() { ID = id });
        _GroupRepository.SaveChanges();
        return isDeleted;
    }
}

using ExaminationSystem.Services.Groups;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Groups;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GroupController : ControllerBase
    {
        IGroupService _GroupService;

        public GroupController(IGroupService GroupService)
        {
            _GroupService = GroupService;
        }
        #region Group Actions
        [HttpPost]
        public ResponseViewModel<int> Create(GroupCreateViewModel viewModel)
        {
            int GroupID = _GroupService.Create(viewModel);
            
            return new ResponseViewModel<int>(){Data = GroupID, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<GroupViewModel> GetByName(string name)
        {
            var Group = _GroupService.GetByName(name);
            
            return new ResponseViewModel<GroupViewModel>(){Data = Group, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<GroupViewModel> GetByID(int id)
        {
            var Group = _GroupService.GetById(id);

            return new ResponseViewModel<GroupViewModel>(){Data = Group, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<IEnumerable<GroupViewModel>> GetAll()
        {
            var GroupsList = _GroupService.GetAll().ProjectTo<GroupViewModel>();
            return new ResponseViewModel<IEnumerable<GroupViewModel>>(){Data = GroupsList, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpPut]
        public ResponseViewModel<bool> Update(GroupEditViewModel viewModel)
        {
            var isUpdateGroup = _GroupService.UpdateGroup(viewModel);
            return new ResponseViewModel<bool>(){Data = isUpdateGroup, Message = "Saved", ErrorCode = 0, IsSuccess = true};
        }

        [HttpDelete]
        public ResponseViewModel<bool> Delete(int id)
        {
            _GroupService.Delete(id);
            return new ResponseViewModel<bool>(){Message = "Deleted", ErrorCode = 0, IsSuccess = true};
        }
        #endregion
    }
}


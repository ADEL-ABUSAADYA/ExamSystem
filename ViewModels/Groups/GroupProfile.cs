using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Groups;



namespace ExaminationSystem;

public class GroupProfile : AutoMapper.Profile
{
    public GroupProfile()
    {
        // Assuming you want to map from Group to GroupViewModel
        CreateMap<Group, GroupCreateViewModel>().ReverseMap();
        CreateMap<Group, GroupViewModel>();
            // .IncludeBase<Group, BaseViewModel>();

        // Assuming BaseViewModel is a parent class of GroupViewModel
        // CreateMap<Group, BaseViewModel>()
        //     .IncludeBase<Group, GroupViewModel>();
        // // CreateMap<Group, BaseViewModel>().IncludeBase<Group, GroupViewModel>();
        // // .ForMember(dest => dest.Birthdate, ops => ops.MapFrom(src => DateTime.Parse(src.Birthdate)));
    }
}

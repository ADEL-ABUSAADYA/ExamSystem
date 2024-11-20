using Bogus;
using Bogus.DataSets;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instrucotrs;

namespace ExaminationSystem;

public class FakeDataService
{
    Faker<InstructorViewModel> _faker;
    public FakeDataService()
    {
        _faker = new Faker<InstructorViewModel>()
        .RuleFor<int>(x => x.ID, d => d.IndexFaker + 1)
        .RuleFor<string>(x => x.Name, d => d.Name.FullName())
        .RuleFor<DateTime>(x => x.Birthdate, d => d.Date.Between(new DateTime(1980,1,1), new DateTime(2024,1,1)))
        .RuleFor<string> (x => x.Adress, d => d.Address.FullAddress());
    }

    public IEnumerable<InstructorViewModel> GetData()
    {
        return _faker.Generate(20);
    }   
}


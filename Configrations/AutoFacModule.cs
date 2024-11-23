using Autofac;
using ExaminationSystem.Data;
using ExaminationSystem.Data.Repository;
using ExaminationSystem.Services.GenaricService;

namespace ExaminationSystem;

public class AutoFacModule : Module
{
    public AutoFacModule()
    {

    }

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<FakeDataService>().SingleInstance();
        builder.RegisterType<Context>().InstancePerLifetimeScope();
        builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
        builder.RegisterGeneric(typeof(Service<,>))
            .As(typeof(IService<,>))
            .InstancePerLifetimeScope();
        builder.RegisterAssemblyTypes(typeof(Program).Assembly)
        .Where(c => c.Name.EndsWith("Service") || c.Name.EndsWith("Repository"))
        .AsImplementedInterfaces().InstancePerLifetimeScope();
    }
}

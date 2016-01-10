namespace AspNetDependencyInjectionCli
{
    using Autofac;

    public class MyOtherServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MyOtherService>().As<IOtherService>().InstancePerLifetimeScope();
        }
    }
}
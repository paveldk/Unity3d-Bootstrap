using Adic;
using Bootstrap.Interfaces.Models;
using Bootstrap.Interfaces.Services;
using Bootstrap.Core.Services;
using Bootstrap.Core.Models;

public class GameRoot : ContextRoot
{
    public override void SetupContainers()
    {
        //Create the container.
        this.AddContainer<InjectionContainer>()
            .RegisterExtension<UnityBindingContainerExtension>()
            .Bind<ISampleModel>().To(new SampleModel(5))
            .Bind<ISampleService>().To<SampleService>();
    }

    public override void Init()
    {
        //Init the game.
    }
}

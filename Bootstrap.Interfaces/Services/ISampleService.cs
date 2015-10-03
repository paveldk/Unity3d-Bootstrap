using System;

namespace Bootstrap.Interfaces.Services
{
    public interface ISampleService
    {
        event EventHandler SomethingHappened;

        void DoSomething();
    }
}

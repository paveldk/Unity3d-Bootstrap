using System;
using Bootstrap.Interfaces.Services;
using Bootstrap.Interfaces.Models;
using Adic;

namespace Bootstrap.Core.Services
{
    public class SampleService : ISampleService
    {
        [Inject]
        ISampleModel MyModel;

        public event EventHandler SomethingHappened;

        public virtual void OnSomethingHappened(EventArgs e)
        {
            EventHandler handler = this.SomethingHappened;

            if(handler == null)
            {
                return;
            }

            handler(this, e);
        }

        public void DoSomething()
        {
            OnSomethingHappened(EventArgs.Empty);
        }
    }
}
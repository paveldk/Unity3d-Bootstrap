using System;
using Bootstrap.Interfaces.Models;

namespace Bootstrap.Core.Models
{
    public class SampleModel : ISampleModel
    {
        public int MyProperty { get; set; }

        public SampleModel(int myValue)
        {
            this.MyProperty = myValue;
        }
    }
}

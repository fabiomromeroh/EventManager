using Business.Contracts;
using Business.Implementations;
using Data;
using Data.Contracts;
using System.ComponentModel.Composition;

namespace Business.Base
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : Core.DI.IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {

        }
    }
}

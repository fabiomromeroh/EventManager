using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business
{
    public interface IBaseLogic<T>
        where T: class, new()
    {
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample.Interfaces
{
    public interface IValidator<TModel>
    {

        bool IsValid(TModel model);

        string GetMessage();

    }
}

using FactoryPatternExample.Interfaces;
using FactoryPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample.Validators.PersonValidators
{
    public class LastNameIsNotNull : IValidator<Person>
    {
        public string GetMessage()
        {
            return "The last name is a required field";
        }

        public bool IsValid(Person model)
        {
            return model.LastName != null;
        }
    }
}

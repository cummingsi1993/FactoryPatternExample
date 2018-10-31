using FactoryPatternExample.Interfaces;
using FactoryPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample.Validators.PersonValidators
{
    public class FirstNameIsNotNull : IValidator<Person>
    {
        public string GetMessage()
        {
            return "The first name is a required field";
        }

        public bool IsValid(Person model)
        {
            return model.FirstName != null;
        }
    }
}

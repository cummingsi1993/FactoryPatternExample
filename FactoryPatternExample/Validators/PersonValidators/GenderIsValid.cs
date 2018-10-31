using FactoryPatternExample.Interfaces;
using FactoryPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample.Validators.PersonValidators
{
    public class GenderIsValid : IValidator<Person>
    {
        public string GetMessage()
        {
            return "The gender is not valid. The gender must be 'M' or 'F'";
        }

        public bool IsValid(Person model)
        {
            return model.Gender != "M" && model.Gender != "F";
        }
    }
}

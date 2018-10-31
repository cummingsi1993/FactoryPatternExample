using FactoryPatternExample.Interfaces;
using FactoryPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FactoryPatternExample.Validators.PersonValidators
{
    public class FaxNumberIsValid : IValidator<Person>
    {
        public string GetMessage()
        {
            return "The fax number is not valid";
        }

        public bool IsValid(Person model)
        {
            return Regex.IsMatch(model.FaxNumber, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
        }
    }
}

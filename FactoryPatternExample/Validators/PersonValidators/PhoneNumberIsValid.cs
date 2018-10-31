using FactoryPatternExample.Interfaces;
using FactoryPatternExample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FactoryPatternExample.Validators.PersonValidators
{
    public class PhoneNumberIsValid : IValidator<Person>
    {
        public string GetMessage()
        {
            return "The phone number is not valid";
        }

        public bool IsValid(Person model)
        {
            return Regex.IsMatch(model.PhoneNumber, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
        }
    }
}

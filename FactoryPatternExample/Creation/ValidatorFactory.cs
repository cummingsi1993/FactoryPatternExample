using FactoryPatternExample.Interfaces;
using FactoryPatternExample.Models;
using FactoryPatternExample.Validators.PersonValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample.Creation
{
    public class ValidatorFactory
    {

        public IEnumerable<IValidator<Person>> CreatePersonValidators()
        {
            List<IValidator<Person>> validators = new List<IValidator<Person>>();

            validators.Add(new FirstNameIsNotNull());
            validators.Add(new LastNameIsNotNull());
            validators.Add(new GenderIsValid());
            validators.Add(new FaxNumberIsValid());
            validators.Add(new PhoneNumberIsValid());

            return validators;
        }
    }
}

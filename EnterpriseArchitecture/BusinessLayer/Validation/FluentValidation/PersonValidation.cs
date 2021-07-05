using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation.FluentValidation
{
    public class PersonValidation:AbstractValidator<Person>
    {
        public PersonValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty();
        }
    }
}

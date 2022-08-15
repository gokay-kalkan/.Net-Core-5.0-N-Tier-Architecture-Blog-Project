using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactInformationValidation : AbstractValidator<ContactInformation>
    {
        public ContactInformationValidation()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email formatı uygun değil");
            RuleFor(x => x.PhoneNumber).Matches(new Regex(@"([\+]90?)([ ]?)(\([0-9]{3}\))([ ]?)([0-9]{3})(\s*[\-]?)([0-9]{2})(\s*[\-]?)([0-9]{2})"));
        }
    }
}

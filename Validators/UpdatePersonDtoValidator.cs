using FluentValidation;
using PersonsApi.Dto;

namespace PersonsApi.Validators
{
    public class UpdatePersonDtoValidator : AbstractValidator<UpdatePersonDto>
    {
        public UpdatePersonDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MinimumLength(5);
        }
    }
}

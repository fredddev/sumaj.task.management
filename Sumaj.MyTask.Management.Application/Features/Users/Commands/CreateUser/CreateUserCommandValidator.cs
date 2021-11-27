﻿using FluentValidation;
using Sumaj.MyTask.Management.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sumaj.MyTask.Management.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.")
                .NotNull();

            RuleFor(e => e)
                .MustAsync(IsUserNameUnique).WithMessage("Another user already has the name that tries to register.");
                


            RuleFor(p => p.Type)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                 .MaximumLength(50).WithMessage("{PropertyName} must not exceed 20 characters.")
                .NotNull();

            
            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                 .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.")
                .NotNull();

            RuleFor(p => p.Enabled)                
                .NotNull().WithMessage("{PropertyName} is required.");
        }

        private async Task<bool> IsUserNameUnique(CreateUserCommand e,CancellationToken token) {            
            
            return (await _userRepository.IsUserNameUnique(e.Name));
            
        }
        
    }
}

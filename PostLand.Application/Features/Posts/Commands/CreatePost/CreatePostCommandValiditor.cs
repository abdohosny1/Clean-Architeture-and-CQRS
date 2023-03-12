using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandValiditor :AbstractValidator<CreatePostCommand>
    {


        public CreatePostCommandValiditor()
        {
            RuleFor(p => p.Title).NotEmpty().NotNull().MaximumLength(100);
            RuleFor(p => p.Content).NotEmpty().NotNull();
        }
    }
}

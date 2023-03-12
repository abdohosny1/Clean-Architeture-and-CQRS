using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLand.Domainn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Guid>
    {

        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);

            CreatePostCommandValiditor validations = new CreatePostCommandValiditor();

            var result = await validations.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Post is not valid");

            }

            post = await _postRepository.AddAsync(post);

            return post.Id;
        }
    }
}

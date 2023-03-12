using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLand.Domainn;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand>
    {

        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public UpdatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {

            var post =  _mapper.Map<Post>(request);

            await _postRepository.UpdateAsync(post);

            return Unit.Value;
        }
    }
}

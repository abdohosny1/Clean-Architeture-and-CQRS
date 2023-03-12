using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostDetails
{
    public class GetPostDetailsQueryHandler : IRequestHandler<GetPostDetailsQuery, GetPostDetailsViewModel>
    {

        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostDetailsQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<GetPostDetailsViewModel> Handle(GetPostDetailsQuery request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetPostByIdAsync(request.PostId, true);

            return _mapper.Map<GetPostDetailsViewModel>(post);
        }
    }

}

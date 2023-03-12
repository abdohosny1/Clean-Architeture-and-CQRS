using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostList
{
    public class GetPostListQueryHandler : IRequestHandler<GetPostListQuery, List<GetPostListViewModel>>
    {


        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostListQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<List<GetPostListViewModel>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {
            var ALLpPosts = await _postRepository.GetALLPostAsync(true);
            return _mapper.Map<List<GetPostListViewModel>>(ALLpPosts);
        }
    }
}

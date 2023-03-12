using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostList
{
   public class GetPostListQuery :IRequest<List<GetPostListViewModel>>
    {
    }
}

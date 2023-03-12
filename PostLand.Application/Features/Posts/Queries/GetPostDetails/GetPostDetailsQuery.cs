using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostDetails
{
   public class GetPostDetailsQuery : IRequest<GetPostDetailsViewModel>
    {
        public Guid PostId { get; set; }
    }
}

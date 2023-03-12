using PostLand.Domainn;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostLand.Application.Contracts
{
    public   interface IPostRepository:IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetALLPostAsync(bool includerCategory);

        Task<Post> GetPostByIdAsync(Guid id, bool includerCategory);
    }
}

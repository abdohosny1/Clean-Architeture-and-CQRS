using AutoMapper;
using PostLand.Application.Features.Posts.Commands.CreatePost;
using PostLand.Application.Features.Posts.Commands.DeletePost;
using PostLand.Application.Features.Posts.Commands.UpdatePost;
using PostLand.Application.Features.Posts.Queries.GetPostDetails;
using PostLand.Application.Features.Posts.Queries.GetPostList;
using PostLand.Domainn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Profiles
{
  public  class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Post, GetPostListViewModel>().ReverseMap();
            CreateMap<Post, GetPostDetailsViewModel>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();
        }
    }
}

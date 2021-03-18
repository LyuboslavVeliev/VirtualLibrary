namespace VirtualLibrary.Web.ViewModels.Book
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using VirtualLibrary.Services.Mapping;
    using VirtualLibrary.Data.Models;
    using AutoMapper;

    public class BookDetailsModel : IMapFrom<Book>, IHaveCustomMappings
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string AuthorFullName { get; set; }

        public List<string> Genres { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Book, BookDetailsModel>()
                .ForMember(x => x.Title, y => y.MapFrom(x => x.Title))
                .ForMember(x => x.Description, y => y.MapFrom(x => x.Description)).ForMember(x => x.Image, y => y.MapFrom(x => x.Image))
                .ForMember(x => x.ReleaseDate, y => y.MapFrom(x => x.ReleaseDate))
                .ForMember(x => x.AuthorFullName, y => y.MapFrom(x => (x.Author.FirstName + " " + x.Author.LastName)))
                .ForMember(x => x.Genres, y => y.MapFrom(x => x.Genres.Select(g => g.Genre.Name)));
        }
    }
}

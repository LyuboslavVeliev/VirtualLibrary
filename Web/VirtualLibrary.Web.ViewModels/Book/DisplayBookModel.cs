namespace VirtualLibrary.Web.ViewModels.Book
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using VirtualLibrary.Services.Mapping;
    using VirtualLibrary.Data.Models;
    using AutoMapper;

    public class DisplayBookModel : IMapFrom<Book>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Book, DisplayBookModel>()
                .ForMember(x => x.Id, y => y.MapFrom(x => x.Id))
                .ForMember(x => x.Title, y => y.MapFrom(x => x.Title))
                .ForMember(x => x.Image, y => y.MapFrom(x => x.Image));
        }
    }
}

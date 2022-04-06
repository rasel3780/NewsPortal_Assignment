using AutoMapper;
using BLL.Entites;
using DLL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class NewsService
    {
        public static bool Add(NewsModel newsModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NewsModel, News>());
            var mapper = new Mapper(config);
            var news = mapper.Map<News>(newsModel);

            var check = DataAccessFactory.NewsDataAccess().Add(news);
            return check;
        }
    }
}

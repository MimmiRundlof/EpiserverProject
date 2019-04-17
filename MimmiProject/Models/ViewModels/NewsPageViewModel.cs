using EPiServer.Core;
using MimmiProject.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MimmiProject.Models.ViewModels
{

    public class NewsPageViewModel : PageViewModel<NewsPage>
    {
        public IEnumerable<ArticlePage> ArticlePages { get; set; }

        public NewsPageViewModel(NewsPage currentPage) : base(currentPage)
        {
        }
        

    }
   
}

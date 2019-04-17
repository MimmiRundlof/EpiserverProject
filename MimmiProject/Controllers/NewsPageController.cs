using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AlloyTraining.Business;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using MimmiProject.Models.Pages;
using MimmiProject.Models.ViewModels;

namespace MimmiProject.Controllers
{
    public class NewsPageController : PageControllerBase<NewsPage>
    {
        public NewsPageController(IContentLoader loader) : base(loader)
        {
        }
        public ActionResult Index(NewsPage currentPage)
        {
            var model = new NewsPageViewModel(currentPage)
            {
                StartPage = loader.Get<StartPage>(ContentReference.StartPage),
            RootPage = loader.Get<SysRoot>(ContentReference.RootPage),
            MenuPages = FilterForVisitor.Filter(
            loader.GetChildren<SitePageData>(ContentReference.StartPage))
            .Cast<SitePageData>().Where(page => page.VisibleInMenu),
            Section = currentPage.ContentLink.GetSection(),
            ArticlePages = loader.GetChildren<ArticlePage>(currentPage.ContentLink)
            };
            return View(model);

        }
    }
}
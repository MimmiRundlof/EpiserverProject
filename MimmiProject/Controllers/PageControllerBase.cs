using System.Linq;
using AlloyTraining.Business;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using MimmiProject.Models.Pages;
using MimmiProject.Models.ViewModels;

namespace MimmiProject.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        protected readonly IContentLoader loader;
        public PageControllerBase(IContentLoader loader)
        {
            this.loader = loader;
        }
        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(
        TPage currentPage) where TPage : SitePageData
        {
            var viewmodel = PageViewModel.Create(currentPage);
            viewmodel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);
            viewmodel.RootPage = loader.Get<SysRoot>(ContentReference.RootPage);
            viewmodel.MenuPages = FilterForVisitor.Filter(
            loader.GetChildren<SitePageData>(ContentReference.StartPage))
            .Cast<SitePageData>().Where(page => page.VisibleInMenu);
            viewmodel.Section = currentPage.ContentLink.GetSection();  
            

            return viewmodel;
        }
    }
}
using MimmiProject.Models.Pages;
using EPiServer.Core;
using System.Collections.Generic;

namespace MimmiProject.Models.ViewModels
{

    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        StartPage StartPage { get; }
        SysRoot RootPage { get; set; }
        IEnumerable<SitePageData> MenuPages { get; }
        IContent Section { get; }

    }
}

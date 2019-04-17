using MimmiProject.Models.Pages;
using System;
using System.Collections.Generic;
using EPiServer.Core;
using EPiServer.SpecializedProperties;

namespace MimmiProject.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; set; }
        public StartPage StartPage { get; set; }
        public IEnumerable<SitePageData> MenuPages { get; set; }
        public IContent Section { get; set; }


        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
        
        public SysRoot RootPage { get; set; }
    }
    public static class PageViewModel
    {
        public static PageViewModel<T> Create<T>(T currentPage)
        where T : SitePageData
        {
            return new PageViewModel<T>(currentPage);
        }
    }


}
using EPiServer.DataAnnotations;
using EPiServer.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MimmiProject
{

    [GroupDefinitions]
    public static class SiteTabNames
    {
        [Display(Order = 10)] 
        [RequiredAccess(AccessLevel.Edit)]
        public const string SEO = "SEO";
        [Display(Order = 20)]
        [RequiredAccess(AccessLevel.Administer)]
        public const string SiteSettings = "Site Settings";
        [Display(Order = 30)]
        [RequiredAccess(AccessLevel.Administer)]
        public const string Footer = "Footer";
        [Display(Order = 40)]
        [RequiredAccess(AccessLevel.Administer)]
        public const string Header = "Header";

    }
}

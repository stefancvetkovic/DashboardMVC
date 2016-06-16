using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(MVCDefault.App_Start.AdminLteBundle), "RegisterBundles")]

namespace MVCDefault.App_Start
{
    public class AdminLteBundle
    {
        private static string color = "blue";
        public static void RegisterBundles()
        {
            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/dist").
                Include(
                //"~/Scripts/dist/app.js",
                "~/Scripts/dist/app.min.js",
                "~/Scripts/dist/dashboard.js",
                "~/Scripts/dist/dashboard2.js",
                "~/Scripts/dist/demo.js"));


            BundleTable.Bundles.Add(new StyleBundle("~/Content/dist").
                Include("~/Content/dist/AdminLTE.min.css",
                "~/Content/dist/skins/_all-skins.min.css"
                //"~/Content/dist/skins/skin-" + color + ".min.css"
                ));
        }
    }
}
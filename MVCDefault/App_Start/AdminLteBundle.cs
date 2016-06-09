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
            // Add @Styles.Render("~/Content/bootstrap/base") in the <head/> of your _Layout.cshtml view
            // For Bootstrap theme add @Styles.Render("~/Content/bootstrap/theme") in the <head/> of your _Layout.cshtml view
            // Add @Scripts.Render("~/bundles/bootstrap") after jQuery in your _Layout.cshtml view
            // When <compilation debug="true" />, MVC4 will render the full readable version. When set to <compilation debug="false" />, the minified version will be rendered automatically
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
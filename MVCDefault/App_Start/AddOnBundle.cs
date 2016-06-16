using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(MVCDefault.App_Start.AddOnBundle), "RegisterBundles")]

namespace MVCDefault.App_Start
{
    public class AddOnBundle
    {
        public static void RegisterBundles()
        {
            BundleTable.Bundles.Add(new ScriptBundle("~/Additional/JsAddOns").
                         Include(
                         "~/Additional/raphael-min.js",
                         "~/Additional/plugins/morris/morris.min.js",
                         "~/Additional/plugins/sparkline/jquery.sparkline.min.js",
                         "~/Additional/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                         "~/Additional/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                         "~/Additional/plugins/knob/jquery.knob.js",
                         "~/Additional/plugins/select2/select2.full.min.js",
                         "~/Additional/plugins/input-mask/jquery.inputmask.js",
                         "~/Additional/plugins/input-mask/jquery.inputmask.date.extensions.js",
                         "~/Additional/plugins/input-mask/jquery.inputmask.extensions.js",
                         "~/Additional/moment.min.js",
                         "~/Additional/plugins/daterangepicker/daterangepicker.js",
                         "~/Additional/plugins/datepicker/bootstrap-datepicker.js",
                         "~/Additional/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                         "~/Additional/plugins/slimScroll/jquery.slimscroll.min.js",
                         "~/Additional/plugins/iCheck/icheck.min.js",
                //"~/Additional/plugins/iCheck/icheck.js",
                         "~/Additional/plugins/fastclick/fastclick.js"
                         ));

            BundleTable.Bundles.Add(new StyleBundle("~/Additional/CssAddOns").
                        Include(
                //"~/Additional/plugins/iCheck/flat/blue.css",
                        "~/Additional/plugins/skins/morris/morris.css",
                        "~/Additional/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                        "~/Additional/plugins/daterangepicker/daterangepicker-bs3.css",
                        "~/Additional/plugins/datepicker/datepicker3.css",
                        "~/Additional/plugins/iCheck/all.css",
                        "~/Additional/plugins/colorpicker/bootstrap-colorpicker.min.css",
                        "~/Additional/plugins/timepicker/bootstrap-timepicker.min.css",
                        "~/Additional/plugins/select2/select2.min.css",
                        "~/Additional/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"));

            BundleTable.Bundles.Add(new StyleBundle("~/Additional/CssCalendar").Include(
                "~/Additional/plugins/fullcalendar/fullcalendar.min.css"
                //"~/Additional/plugins/fullcalendar/fullcalendar.print.css"
                ));

            BundleTable.Bundles.Add(new ScriptBundle("~/Additional/JSCalendar").
                Include(
                 "~/Additional/jquery-ui.min.js",
                  "~/Additional/plugins/slimScroll/jquery.slimscroll.min.js",
                  "~/Additional/plugins/fastclick/fastclick.js",
                  "~/Scripts/dist/app.min.js",
                  //"~/Scripts/dist/demo.js",
                  "~/Additional/moment.min.js",
                  "~/Additional/plugins/fullcalendar/fullcalendar.min.js"
                ));

        }
    }
}
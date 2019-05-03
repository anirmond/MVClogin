using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace MVCwithlogin.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/customjs/custom.js"
                        ));

            //bundles.Add(new ScriptBundle("~/bundles/jquerymin").Include(
            //            "~/Scripts/jquery-1.10.2.min.js")
            //            //.IncludeDirectory("~/Scripts", ".js")
            //            );

            //bundles.Add(new ScriptBundle("~/bundles/jquerycustom").Include(
            //            "~/Scripts/customjs/custom.js")
            //            //.IncludeDirectory("~/Scripts", ".js")
                        //);

        }

    }
}
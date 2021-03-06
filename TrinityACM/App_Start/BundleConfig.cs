﻿using System.Web;
using System.Web.Optimization;

namespace TrinityACM
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                        "~/Scripts/bootstrap.min.js"));

            //bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
            //            "~/Content/bootstrap.min.css",
            //            "~/Content/bootstrap-responsive.min.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                        "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/customcss").Include(
                        "~/Content/custom.css"));

        }
    }
}
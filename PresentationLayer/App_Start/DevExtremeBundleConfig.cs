using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace HIS
{

    public class DevExtremeBundleConfig {

        public static void RegisterBundles(BundleCollection bundles) {

            var styleBundle = new StyleBundle("~/Content/DevExtremeBundle");
            var scriptBundle = new ScriptBundle("~/Scripts/DevExtremeBundle");


            // CLDR scripts
            scriptBundle
                .Include("~/Scripts/cldr.js")
                .Include("~/Scripts/cldr/event.js")
                .Include("~/Scripts/cldr/supplemental.js")
                .Include("~/Scripts/cldr/unresolved.js");

            // Globalize 1.x
            scriptBundle
                .Include("~/Scripts/globalize.js")
                .Include("~/Scripts/globalize/message.js")
                .Include("~/Scripts/globalize/number.js")
                .Include("~/Scripts/globalize/currency.js")
                .Include("~/Scripts/globalize/date.js");

            // Adding the UTF-8 charset to display icons correctly
            styleBundle.Include("~/Content/Charset.css");

            // Uncomment to use the Gantt control
            //styleBundle.Include("~/Content/dx-gantt.css");

            // Uncomment to use the Diagram control
            //styleBundle.Include("~/Content/dx-diagram.css");

            styleBundle.Include("~/Content/dx.common.css");

            // Predefined themes: https://js.devexpress.com/DevExtreme/Guide/Themes_and_Styles/Predefined_Themes/
            styleBundle.Include("~/Content/dx.light.css");

            // Uncomment to use the Gantt control
            //scriptBundle.Include("~/Scripts/dx-gantt.js");

            // Uncomment to use the Diagram control
            //scriptBundle.Include("~/Scripts/dx-diagram.js");

            // NOTE: jQuery may already be included in the default script bundle. Check the BundleConfig.cs file.
            //scriptBundle.Include("~/Scripts/jquery-3.3.1.js");

            // Uncomment to use Globalize for localization
            // Docs: https://docs.devexpress.com/DevExtremeAspNetMvc/400706#globalize
            //scriptBundle.Include("~/Scripts/cldr.js");
            //scriptBundle.Include("~/Scripts/cldr/event.js");
            //scriptBundle.Include("~/Scripts/cldr/supplemental.js");
            //scriptBundle.Include("~/Scripts/cldr/unresolved.js");
            //scriptBundle.Include("~/Scripts/globalize.js");
            //scriptBundle.Include("~/Scripts/globalize/message.js");
            //scriptBundle.Include("~/Scripts/globalize/number.js");
            //scriptBundle.Include("~/Scripts/globalize/currency.js");
            //scriptBundle.Include("~/Scripts/globalize/date.js");

            // Uncomment to enable client-side export
            //scriptBundle.Include("~/Scripts/jszip.js");

            //Se comenta para eliminar el error de DevExpress E0024 DevExtreme bundle already included
            //scriptBundle.Include("~/Scripts/dx.all.js");

            // Uncomment to provide geo-data for the VectorMap control
            // Docs: https://js.devexpress.com/DevExtreme/Guide/Widgets/VectorMap/Providing_Data/#Data_for_Areas
            //scriptBundle.Include("~/Scripts/vectormap-data/world.js");

            scriptBundle.Include("~/Scripts/aspnet/dx.aspnet.mvc.js");
            scriptBundle.Include("~/Scripts/aspnet/dx.aspnet.data.js");

            // Idioma Espa�ol
            scriptBundle
                .Include("~/Scripts/localization/dx.messages.es.js");

            bundles.Add(styleBundle);
            bundles.Add(scriptBundle);

#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
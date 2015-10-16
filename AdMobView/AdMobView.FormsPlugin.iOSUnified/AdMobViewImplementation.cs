using AdMobView.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using AdMobView.FormsPlugin.iOSUnified;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AdMobView.FormsPlugin.Abstractions.AdMobView), typeof(AdMobViewRenderer))]
namespace AdMobView.FormsPlugin.iOSUnified
{
    /// <summary>
    /// AdMobView Renderer
    /// </summary>
    public class AdMobViewRenderer //: TRender (replace with renderer type
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
        }
    }
}

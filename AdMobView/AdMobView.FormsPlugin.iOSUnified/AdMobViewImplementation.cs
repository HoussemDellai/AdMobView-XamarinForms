
using System;
using Xamarin.Forms;
using Xam.FormsPlugin.iOSUnified;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Xam.FormsPlugin.Abstractions.AdMobView), typeof(AdMobViewRenderer))]
namespace Xam.FormsPlugin.iOSUnified
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

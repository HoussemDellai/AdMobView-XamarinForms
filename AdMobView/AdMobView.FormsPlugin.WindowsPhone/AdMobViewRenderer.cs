using System.Diagnostics;
using System.Threading;
using System.Windows;
using Xamarin.Forms;

using GoogleAds;
using Xam.FormsPlugin.Abstractions;
using Xam.FormsPlugin.WinPhone;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(AdMobView),
                          typeof(AdMobViewRenderer))]

namespace Xam.FormsPlugin.WinPhone
{
    /// <summary>
    /// AdMobView renderer implementation for Google AdView ads for Windows Phone.
    /// </summary>
    public class AdMobViewRenderer : ViewRenderer
    {

        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init()
        {
        }

        /// <summary>
        /// reload the view and hit up google admob 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            //convert the element to the control we want
            var adMobElement = Element as AdMobView;

            if ((adMobElement != null) && (e.OldElement == null))
            {
                var bannerAd = new AdView
                {
                    Format = AdFormats.Banner,
                    AdUnitID = adMobElement.AdUnitId,
                };

                var adRequest = new AdRequest();

                bannerAd.LoadAd(adRequest);

                bannerAd.DismissingOverlay += (sender, args) =>
                {
                };

                bannerAd.FailedToReceiveAd += (sender, args) =>
                {
                };

                bannerAd.ReceivedAd += (sender, args) =>
                {
                };

                bannerAd.ShowingOverlay += (sender, args) =>
                {
                };

                Children.Add(bannerAd);
            }
        }
    }
}
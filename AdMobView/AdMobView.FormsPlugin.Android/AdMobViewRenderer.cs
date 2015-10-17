using Xamarin.Forms;
using Android.Gms.Ads;
using Xam.FormsPlugin.Abstractions;
using Xam.FormsPlugin.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdMobView), typeof(AdMobViewRenderer))]

namespace Xam.FormsPlugin.Android
{
    /// <summary>
    /// AdMobView renderer implementation for Google AdView ads for Xamarin.Android.
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
                var ad = new AdView(Context)
                {
                    AdSize = AdSize.Banner,
                    AdUnitId = adMobElement.AdUnitId
                };

                var requestbuilder = new AdRequest.Builder();

                ad.LoadAd(requestbuilder.Build());

                SetNativeControl(ad);
            }
        }
    }
}
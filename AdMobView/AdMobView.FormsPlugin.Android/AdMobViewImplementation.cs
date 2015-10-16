using Xamarin.Forms;
using AdMobView.FormsPlugin.Android;
using Android.Gms.Ads;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdMobView.FormsPlugin.Abstractions.AdMobView), typeof(AdMobViewRenderer))]

namespace AdMobView.FormsPlugin.Android
{
    /// <summary>
    /// AdMobView Renderer
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
            var adMobElement = Element as Abstractions.AdMobView;

            if ((adMobElement != null) && (e.OldElement == null))
            {
                var ad = new AdView(this.Context)
                {
                    AdSize = AdSize.Banner,
                    AdUnitId = adMobElement.AdUnitId
                };

                var requestbuilder = new AdRequest.Builder();

                ad.LoadAd(requestbuilder.Build());

                this.SetNativeControl(ad);
            }
        }
    }
}
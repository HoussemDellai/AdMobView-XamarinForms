using Xamarin.Forms;
using EntrepreneursTips.WinPhone.Renderers;
using GoogleAds;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(AdMobView.FormsPlugin.Abstractions.AdMobView),
                          typeof(AdMobViewRenderer))]

namespace EntrepreneursTips.WinPhone.Renderers
{
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
            var adMobElement = Element as AdMobView.FormsPlugin.Abstractions.AdMobView;

            if ((adMobElement != null) && (e.OldElement == null))
            {
                AdView bannerAd = new AdView
                {
                    Format = AdFormats.Banner,
                    AdUnitID = adMobElement.AdUnitId,
                };
                AdRequest adRequest = new AdRequest();
                bannerAd.LoadAd(adRequest);
                Children.Add(bannerAd);
            }
        }
    }
}
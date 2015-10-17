using Xamarin.Forms;

namespace Xam.FormsPlugin.Abstractions
{
    /// <summary>
    /// AdMobView is Google's AdMob ads control implementation for Xamarin.Forms.
    /// </summary>
    public class AdMobView : View
    {
        /// <summary>
        /// The ID of the AdMob ad to display
        /// This is the string Id from your Google Play account
        /// </summary>
        public static readonly BindableProperty AdUnitIdProperty =
            BindableProperty.Create<AdMobView, string>(p => p.AdUnitId, "");
        //AdUnitId example : ca-app-pub-5796681800623607/8623940979

        /// <summary>
        /// The ID of the AdMob ad to display
        /// This is the string Id from your Google Play account
        /// </summary>
        public string AdUnitId
        {
            get
            {
                return (string)GetValue(AdUnitIdProperty);
            }
            set
            {
                SetValue(AdUnitIdProperty, value);
            }
        }
    }
}

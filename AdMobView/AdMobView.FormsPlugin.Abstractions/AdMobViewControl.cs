using System;
using Xamarin.Forms;

namespace AdMobView.FormsPlugin.Abstractions
{
    /// <summary>
    /// AdMobView Interface
    /// </summary>
    public class AdMobView : View
    {
        /// <summary>
        /// The ID of the AdMob ad to display
        /// This is the string Id from your Google Play account
        /// </summary>
        public static readonly BindableProperty AdUnitIdProperty =
            BindableProperty.Create<AdMobView, string>
                (p => p.AdUnitId, "");

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

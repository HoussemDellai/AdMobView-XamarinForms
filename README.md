# AdMobView-XamarinForms
This project shows how to develop a plugin that shows Google AdMob ads for Windows Phone and Xamarin.Android from a Xamarin.Forms project.

Supported projects: Xamarin.Android and Windows Phone 8 (Silverlight).

The resulted nuget package is available on: https://www.nuget.org/packages/Xam.FormsPlugin.AdMobView/

Don't forget to add the following to your Android.Manifest inside <application>:

< activity android:theme="@android:style/Theme.Translucent" 
          android:name="com.google.android.gms.ads.AdActivity" 
          android:configChanges="keyboard|keyboardHidden|orientation|screenLayout|uiMode|screenSize|smallestScreenSize" />
          
And add the following capabilities inside your Windows Phone WMAppManifest:

ID_CAP_NETWORKING	Access to network services is required when requesting ads.

ID_CAP_WEBBROWSERCOMPONENT	Required since the AdView is a web browser.

ID_CAP_MEDIALIB_PLAYBACK	Provides access for currently playing media items.

ID_CAP_MEDIALIB_AUDIO	Provides read access to audio items in media library.


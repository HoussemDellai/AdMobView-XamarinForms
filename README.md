# AdMobView-XamarinForms
This project shows how to develop a plugin that shows Google AdMob ads for Windows Phone and Xamarin.Android from a Xamarin.Forms project.

Supported projects: Xamarin.Android and Windows Phone 8 (Silverlight).

The resulted nuget package is available on: https://www.nuget.org/packages/Xam.FormsPlugin.AdMobView/

Here is a video on how to install the plugin for your Xamarin Forms project: </br>
https://www.youtube.com/watch?v=RE4IbyLJtX0

</br>
<img src="https://github.com/HoussemDellai/AdMobView-XamarinForms/blob/master/Screenshots/AdMobView-Android.png" width="30%"/>
<img src="https://github.com/HoussemDellai/AdMobView-XamarinForms/blob/master/Screenshots/AdMobView-WindowsPhone.png" width="30%"/>

Don't forget to add the following to your Android.Manifest inside <application>:

< activity android:name="com.google.android.gms.ads.AdActivity" 
           android:configChanges="keyboard|keyboardHidden|orientation|screenLayout|uiMode|screenSize|smallestScreenSize" />

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdpoleSdk{


    public class AdpoleInterstitial : MonoBehaviour
    {

        public static void init(){

            var activityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            //getting context of unity activity
            var activityContext = activityClass.GetStatic<AndroidJavaObject>("currentActivity");
            //calling plugin class by package name
            var pluginClass = new AndroidJavaClass("com.adpole.sdk.InterstitialActivity");
            //calling initialize static method
            var context = activityContext.Call<AndroidJavaObject>("getApplicationContext");
            pluginClass.CallStatic("init", context);
        }

        public static void loadAd(){
            var pluginClass = new AndroidJavaClass("com.adpole.sdk.InterstitialActivity");
            //calling loadAd static method
            pluginClass.CallStatic("loadAd");
        }

        public static bool isLoaded(){
            //calling plugin class by package name
            var pluginClass = new AndroidJavaClass("com.adpole.sdk.InterstitialActivity");
            //calling isLoaded static method
           return pluginClass.CallStatic<bool>("isLoaded");
        }

        public static void show(){
            //calling plugin class by package name
            var pluginClass = new AndroidJavaClass("com.adpole.sdk.InterstitialActivity");
            //calling show static method
            pluginClass.CallStatic("show");
        }

    }

}


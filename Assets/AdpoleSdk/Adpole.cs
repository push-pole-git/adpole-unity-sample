using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdpoleSdk{


    public class Adpole : MonoBehaviour
    {
        public static void initialize(string adPoleAppId){

             var activityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            //getting context of unity activity
            var activityContext = activityClass.GetStatic<AndroidJavaObject>("currentActivity");
            //calling plugin class by package name
            var pluginClass = new AndroidJavaClass("com.adpole.sdk.AdPole");
            //calling initialize static method
            var context = activityContext.Call<AndroidJavaObject>("getApplicationContext");
            pluginClass.CallStatic("initialize", context, adPoleAppId);
        }

    }

}


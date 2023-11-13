using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AdpoleSdk;

public class ShowAd : MonoBehaviour
{
    // Start is called before the first frame update

    public void button_pressed()
    {
        Debug.Log("Button Pressed");
         if (AdpoleInterstitial.isLoaded()){
                AdpoleInterstitial.show();
                
        }

    }



    
}

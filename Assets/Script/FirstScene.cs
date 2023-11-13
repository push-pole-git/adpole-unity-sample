using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AdpoleSdk;

public class FirstScene : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
    {
        Adpole.initialize("YourID");
        AdpoleInterstitial.init();
        AdpoleInterstitial.loadAd();
        
    }

   

}

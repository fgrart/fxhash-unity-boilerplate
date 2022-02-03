using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices; // we use this in order to DllImport at line 9

public class RandomExample : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern float GetRandomFromFxhash(); // this is the function that returns the fxhash's random from index.html

    [SerializeField]
    private Text randomNumTxt;

    private void Start() 
    {
        GetRandomNum();
    }

    private void GetRandomNum()
    {
        #if UNITY_WEBGL && !UNITY_EDITOR
        float randomValue = GetRandomFromFxhash();
        randomNumTxt.text = randomValue.ToString();
        print("Random value from fxhash is: " + randomValue);
        #elif UNITY_EDITOR
        randomNumTxt.text = "Once you upload the build to fxhash you will get the value here.";
        #endif
    }
}

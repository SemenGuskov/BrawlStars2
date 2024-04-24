////////////////////////////////////////////////////////////////////////////////
//  
// @author Benoît Freslon @benoitfreslon
// https://github.com/BenoitFreslon/Vibration
// https://benoitfreslon.com
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class VibrationExample_214BS : MonoBehaviour
{
    public Text inputTime;
    public Text inputPattern;
    public Text inputRepeat;
    public Text txtAndroidVersion;

    // Use this for initialization
    void Start ()
    {
        Vibration_214BS.Init ();
        Debug.Log ( "Application.isMobilePlatform: " + Application.isMobilePlatform );
        txtAndroidVersion.text = "Android Version: " + Vibration_214BS.AndroidVersion.ToString ();
    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void TapVibrate ()
    {
        Vibration_214BS.Vibrate ();
    }

    public void TapVibrateCustom ()
    {
        Vibration_214BS.Vibrate ( int.Parse ( inputTime.text ) );
    }

    public void TapVibratePattern ()
    {
        string[] patterns = inputPattern.text.Replace ( " ", "" ).Split ( ',' );
        long[] longs = Array.ConvertAll<string, long> ( patterns, long.Parse );

        Debug.Log ( longs.Length );
        //Vibration.Vibrate ( longs, int.Parse ( inputRepeat.text ) );

        Vibration_214BS.Vibrate ( longs, int.Parse ( inputRepeat.text ) );
    }

    public void TapCancelVibrate ()
    {

        Vibration_214BS.Cancel ();
    }

    public void TapPopVibrate ()
    {
        Vibration_214BS.VibratePop ();
    }

    public void TapPeekVibrate ()
    {
        Vibration_214BS.VibratePeek ();
    }

    public void TapNopeVibrate ()
    {
        Vibration_214BS.VibrateNope ();
    }
}

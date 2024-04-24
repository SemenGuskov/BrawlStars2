using UnityEngine;
using UnityEngine.Video;
using System.IO.IsolatedStorage;

public class MyVideoChecker_214BS : MonoBehaviour
{
     [SerializeField]
    private VideoPlayer my_videoPlayer_214BS;
    private void Start()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        Application.focusChanged += OnApplicationFocus_214BS;
    }

    private void OnDestroy()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        Application.focusChanged -= OnApplicationFocus_214BS;
    }

    private void OnApplicationFocus_214BS(bool hasFocus)
    {
        if (hasFocus)
            my_videoPlayer_214BS.Prepare();
        StopAllCoroutines();
        StartCoroutine(MyCheckVideo_214BS());
    }

    System.Collections.IEnumerator MyCheckVideo_214BS()
    {
        if (my_videoPlayer_214BS.isPaused)
            my_videoPlayer_214BS.Play();


        yield return new WaitForSeconds(.2f);
        StartCoroutine(MyCheckVideo_214BS());
    }
}
















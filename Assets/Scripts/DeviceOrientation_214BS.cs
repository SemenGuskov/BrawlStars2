using System.Collections;
using UnityEngine;

public class DeviceOrientation_214BS : MonoBehaviour
{
     [SerializeField] private GameObject _blocker_214BS;
    private void Awake()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StartCoroutine(WaitChangeOrientation_214BS());
    }

    private IEnumerator WaitChangeOrientation_214BS()
    {
        _blocker_214BS.SetActive(true);
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        yield return new WaitForEndOfFrame();
        _blocker_214BS.SetActive(false);
    }
}

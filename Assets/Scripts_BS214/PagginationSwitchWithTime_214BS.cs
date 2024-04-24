using System.Collections;
using DanielLochner.Assets.SimpleScrollSnap;
using UnityEngine;
using System.IO.IsolatedStorage;

public class PagginationSwitchWithTime_214BS : MonoBehaviour
{
     [SerializeField] private SimpleScrollSnap _mySnap_214BS;
     [SerializeField] private float my_myDelay_214BS = 1.25f;
     [SerializeField] private float _myUserInactiveDelay_214BS = 1.5f;
    private bool my_isUserActive_214BS = false;
    void Start()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StartCoroutine(ChangePanelWithDelay_214BS(my_myDelay_214BS));
    }

    private IEnumerator ChangePanelWithDelay_214BS(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (my_isUserActive_214BS == false)
            _mySnap_214BS.GoToNextPanel();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StartCoroutine(ChangePanelWithDelay_214BS(my_myDelay_214BS));
    }

    private IEnumerator SetUserActive_214BS(float my_delay)
    {
        yield return new WaitForSeconds(my_delay);
        my_isUserActive_214BS = false;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StartCoroutine(ChangePanelWithDelay_214BS(my_myDelay_214BS));
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch my_touch_214BS = Input.GetTouch(0);
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            if (my_touch_214BS.phase == TouchPhase.Moved || my_touch_214BS.phase == TouchPhase.Began || my_touch_214BS.phase == TouchPhase.Stationary)
            {
                my_isUserActive_214BS = true;
                  StopAllCoroutines();
                      StartCoroutine(SetUserActive_214BS(_myUserInactiveDelay_214BS));
            }

        }
    }
}

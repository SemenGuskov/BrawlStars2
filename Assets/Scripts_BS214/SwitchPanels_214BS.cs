using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO.IsolatedStorage;

public class SwitchPanels_214BS : MonoBehaviour
{
     [SerializeField] private Transform _panel_1_214BS;
     [SerializeField] private Transform _panel_2_214BS;
     [SerializeField] private Transform _panel_3_214BS;
    
     [SerializeField] private Transform _target_214BS;
    

     [SerializeField] private IAPManager_214BS _iapManager_214BS;

    private int _counter_214BS = 0;

    void Start()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        GetComponent<Button>().onClick.AddListener(OnClickHandler_214BS);
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
        GetComponent<Button>().onClick.RemoveListener(OnClickHandler_214BS);
    }

    void OnClickHandler_214BS()
    {
        _counter_214BS++;
        switch (_counter_214BS)
        {
            case 1:
                _panel_1_214BS.gameObject.SetActive(false);
                _panel_2_214BS.gameObject.SetActive(true);
                break;

            case 2:
                _panel_2_214BS.gameObject.SetActive(false);
                _panel_3_214BS.gameObject.SetActive(true);
                transform.SetParent(_target_214BS);
                StartCoroutine(Wait_214BS(0.5f, () =>
                {
                    var layout_214BS = _target_214BS.parent.GetComponent<VerticalLayoutGroup>();
                    layout_214BS.enabled = false;
                    layout_214BS.enabled = true;
                }));
                _iapManager_214BS.MakeButtonWithIAP_214BS();
                break;

        }
    }
    
    private IEnumerator Wait_214BS(float seconds, Action onCompleated)
    {
        yield return new WaitForSeconds(seconds);
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        onCompleated?.Invoke();
    }
}

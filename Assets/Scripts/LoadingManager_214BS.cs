using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class LoadingManager_214BS : MonoBehaviour
{
     [SerializeField] private List<Image> _loadImages_214BS;
    [SerializeField] private float LoadSpeedBS;
    [SerializeField] private GameObject  GameInitializationPanelBS;
    [SerializeField] private GameObject loadingPanelBS;
    [SerializeField] private GameObject  pnelControllerBS;
    public static  bool internetConnectionBS;

     [SerializeField] private MessageExtension_214BS messageExtension214Bs;
    
    private bool SliderLoadingStart_214BS;
    private void Start()
    {
        loadingPanelBS.transform.GetChild(0).gameObject.SetActive(true);
        loadingPanelBS.transform.GetChild(1).gameObject.SetActive(true);
        Input.multiTouchEnabled = false;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            internetConnectionBS = false;
            Debug.Log("Error Not internet connection!  Plaese check internet connection for continue_214BS".Replace("_214BS", ""));
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
        {
            internetConnectionBS = true;
            Debug.Log("Download file can be more 100 Mb Plaese enter wi-fi connection and push continue(continue button)_214BS".Replace("_214BS", ""));
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            internetConnectionBS = true;
            Debug.Log("Internet Connection Wi-fi/Local: Success_214BS".Replace("_214BS", ""));
        }
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        DataLoader_214BS.OnLoaded_214BS += () => SliderLoadingStart_214BS = true;
    }
    
    private async void Update()
    {
        if (SliderLoadingStart_214BS)
        {
            for (int i = 0; i < _loadImages_214BS.Count; i++)
            {
                while (_loadImages_214BS[i].fillAmount < 1)
                {
                    _loadImages_214BS[i].fillAmount += 0.01f;
                    await Task.Delay(1000);
                    if (_loadImages_214BS[i].fillAmount >= 1)
                    {
                        break;
                    }
                }
            }
        
            if (_loadImages_214BS[_loadImages_214BS.Count-1].fillAmount >= 1)
            {
                if (Application.internetReachability == NetworkReachability.NotReachable)
                {
                    messageExtension214Bs.ShowMessage_214BS("Error Not internet connection!  Please check internet connection for continue_214BS".Replace("_214BS", ""));
                }
                else
                {
                    Invoke("OffLoadPanelBS",0.8f);
                    SliderLoadingStart_214BS = false;
                }
            }
        }
        
    }
    private void OffLoadPanelBS()
    {
        GameInitializationPanelBS.SetActive(true);
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        loadingPanelBS.SetActive(false);
        pnelControllerBS.SetActive(true);
    }
}

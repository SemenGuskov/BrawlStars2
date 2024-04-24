using UnityEngine;

public class NetworkHandler_214BS : MonoBehaviour
{
     [SerializeField] private GameObject _networkBlocker_214BS;

    private void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            _networkBlocker_214BS.SetActive(true);
            IOSBridge.IOStoUnityBridge.ShowAlert("Not internet connection!BS214".Replace("BS214", ""), "Please check internet connection for continue_214BS".Replace("_214BS", ""));
        }
        else
        {
            _networkBlocker_214BS.SetActive(false);
        }
    }
}

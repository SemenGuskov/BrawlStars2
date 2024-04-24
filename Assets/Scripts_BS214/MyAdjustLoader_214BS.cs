using com.adjust.sdk;
using UnityEngine;
using System.IO.IsolatedStorage;

[DisallowMultipleComponent]
public class MyAdjustLoader_214BS : MonoBehaviour {

     [SerializeField] string appToken_214BS;
    
    
    
    [Tooltip("Sandbox - for test release.\nProduction - for release.\n\nSelect any for editor. 214BS")]
    [SerializeField] AdjustEnvironment environment_214BS;
    
    
    
    [Tooltip("The following log levels are available:\n* Verbose - full logging.\n* Debug - detailed logging.\n* Info - return info, warnings, errors and assert logs.\n* Warn - return warnings, errors and assert logs.\n* Error - return only error and assert logs.\n* Assert - return only assert logs.\n* Suppress - disable all logging. 214BS")]
    [SerializeField] AdjustLogLevel logLevel_214BS = AdjustLogLevel.Verbose;
    
    private void Start() {
        if (string.IsNullOrEmpty(appToken_214BS)) {
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            Debug.Log("[Adjust WARN] Adjust not enabled. Reason: empty app token. 214BS");
            return;
        }
        //AdjustConfig config_my_CV_256 = new AdjustConfig(appToken_my_CV_256, environment_my_CV_256, true);
        //config_my_CV_256.setLogLevel(logLevel_my_CV_256);
        Adjust.requestTrackingAuthorizationWithCompletionHandler((status_my) =>
        {
            switch (status_my)
            {
                case 0:
                    // ATTrackingManagerAuthorizationStatusNotDetermined case
                    break;
                case 1:
                    // ATTrackingManagerAuthorizationStatusRestricted case
                    break;
                case 2:
                    // ATTrackingManagerAuthorizationStatusDenied case
                    break;
                case 3:
                    // ATTrackingManagerAuthorizationStatusAuthorized case
                    break;
            }
        });
        //Adjust.setDeviceToken(Pushwoosh.Instance.PushToken);
        //Adjust.start(config_my_CV_256);
    }
}
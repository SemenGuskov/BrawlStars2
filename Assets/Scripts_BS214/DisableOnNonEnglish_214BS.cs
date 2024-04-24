using UnityEngine;
using System.IO.IsolatedStorage;

public class DisableOnNonEnglish_214BS : MonoBehaviour
{
    void Start()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        if (Application.systemLanguage != SystemLanguage.English)
            gameObject.SetActive(false);
    }
}

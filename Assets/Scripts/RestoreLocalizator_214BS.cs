using UnityEngine;
using I2.Loc;
using System.Linq;

public class RestoreLocalizator_214BS : MonoBehaviour
{
    private RectTransform _rect_214BS;
    private readonly string[] reverseLanguage_214BS = { "Arabic_214BS".Replace("_214BS", ""), "Hebrew_214BS".Replace("_214BS", "") };
    public bool IsReversed_214BS => reverseLanguage_214BS.Contains(LocalizationManager.CurrentLanguage);

    private void Awake()
    {
        _rect_214BS = GetComponent<RectTransform>();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        LocalizationManager.OnLocalizeEvent += OnLocalizeEvent_214BS;
        OnLocalizeEvent_214BS();
    }

    private void OnLocalizeEvent_214BS()
    {
        _rect_214BS.anchorMin = new Vector2(IsReversed_214BS? 0 : 1, 1);
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _rect_214BS.anchorMax = new Vector2(IsReversed_214BS? 0 : 1, 1);
        _rect_214BS.anchoredPosition = new Vector3(IsReversed_214BS? 200 : 0, _rect_214BS.anchoredPosition.y);
    }
}

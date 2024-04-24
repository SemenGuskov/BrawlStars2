using System.Linq;
using I2.Loc;
using UnityEngine;

public class RectTransformLocalizator_214BS : MonoBehaviour
{
    public static bool IsReversed_214BS => reverseLanguage_214BS.Contains(LocalizationManager.CurrentLanguage);
    private static readonly string[] reverseLanguage_214BS = new string[] { "Arabic_214BS".Replace("_214BS", ""), "Hebrew_214BS".Replace("_214BS", "") };

    private RectTransform rectTransform_214BS;
    private float anchorMin_214BS;
    private float anchorMax_214BS;
    private float pivot_214BS;
    
    void Awake()
    {
        rectTransform_214BS = this.GetComponent<RectTransform>();
        anchorMin_214BS = rectTransform_214BS.anchorMin.x;
        anchorMax_214BS = rectTransform_214BS.anchorMax.x;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        pivot_214BS = rectTransform_214BS.pivot.x;
        LocalizationManager.OnLocalizeEvent += OnLocalizeEvent_214BS;
        OnLocalizeEvent_214BS();
    }

    private void OnLocalizeEvent_214BS()
    {
        rectTransform_214BS.anchorMin = new Vector2(IsReversed_214BS ? 1 - anchorMin_214BS : anchorMin_214BS, rectTransform_214BS.anchorMin.y);
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        rectTransform_214BS.anchorMax = new Vector2(IsReversed_214BS ? 1 - anchorMax_214BS : anchorMax_214BS, rectTransform_214BS.anchorMax.y);
        rectTransform_214BS.pivot = new Vector2(IsReversed_214BS ? 1 - pivot_214BS : pivot_214BS, rectTransform_214BS.pivot.y);
    }
}

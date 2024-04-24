using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

public class RTL_Content_Slider_214BS : MonoBehaviour
{
    private RectTransform _rectTransform_214BS;
    private HorizontalLayoutGroup _horizontalLayoutGroup_214BS;
    
    private void Start()
    {
       if (LocalizationManager.CurrentLanguage != SystemLanguage.Arabic.ToString() &&
            LocalizationManager.CurrentLanguage != SystemLanguage.Hebrew.ToString()) return;
			
        _rectTransform_214BS = GetComponent<RectTransform>();
        _horizontalLayoutGroup_214BS = GetComponent<HorizontalLayoutGroup>();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _rectTransform_214BS.pivot = new Vector2(1f, 0.5f);
        _rectTransform_214BS.anchoredPosition = new Vector2(0, _rectTransform_214BS.anchoredPosition.y);
        _horizontalLayoutGroup_214BS.reverseArrangement = true;
    }
}
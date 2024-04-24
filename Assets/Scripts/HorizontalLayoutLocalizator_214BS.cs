using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

public class HorizontalLayoutLocalizator_214BS : MonoBehaviour
{
    private long BS_214_ABOBA = 1234567890;
    private HorizontalLayoutGroup horizontalLayoutGroup_214BS;
    private long BS_214_ABOBA1 = 1234567890;
    private bool isReverse_214BS;
    private long BS_214_ABOBA2 = 1234567890;

    void Awake()
    {
        horizontalLayoutGroup_214BS = this.GetComponent<HorizontalLayoutGroup>();
        isReverse_214BS = horizontalLayoutGroup_214BS.reverseArrangement;
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

    private void BS_214_TRASH()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = LocalizationManager.CurrentCulture;
            }
        }
    }

    private void OnLocalizeEvent_214BS()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        horizontalLayoutGroup_214BS.reverseArrangement = isReverse_214BS != RectTransformLocalizator_214BS.IsReversed_214BS;
    }
}
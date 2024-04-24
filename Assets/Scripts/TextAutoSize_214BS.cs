using UnityEngine;
using UnityEngine.UI;
using I2.Loc;

[RequireComponent(typeof(Text))]
public class TextAutoSize_214BS : MonoBehaviour
{
     [SerializeField, Min(1)] private int maxSize_214BS = 40;
    private Text _text_214BS;
    private float _calculatedPermissibleWidth_214BS = -1;

    private void Awake()
    {
        if(TryGetComponent<Text>(out var text))
        {
            _text_214BS = text;
            SetDefaultProperty_214BS();
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            LocalizationManager.OnLocalizeEvent += () =>
            {
                SetDefaultProperty_214BS();
                PickUpSize_214BS(_text_214BS);
            };
            PickUpSize_214BS(_text_214BS);
        }
    }
    

    private void Update()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        PickUpSize_214BS(_text_214BS);
    }

    private void SetDefaultProperty_214BS()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _text_214BS.fontSize = maxSize_214BS;
    }
    
    private void PickUpSize_214BS(Text text)
    {
        if (IsOverflowingHorizontal_214BS(text))
        {
            text.fontSize--;
            PickUpSize_214BS(text);
        }

        if (SystemInfo.deviceModel.Contains("iPhone_214BS".Replace("_214BS", "")))
        {
            text.fontSize = 20;
        }
        else
        {
            text.fontSize = maxSize_214BS;
        }
    }

    private bool IsOverflowingHorizontal_214BS(Text text)
    {
        return LayoutUtility.GetPreferredWidth(text.rectTransform) > GetCalculatedPermissibleWidth_214BS(text);
    }

    private float GetCalculatedPermissibleWidth_214BS(Text text)
    {
        if (_calculatedPermissibleWidth_214BS != -1) return _calculatedPermissibleWidth_214BS;

        _calculatedPermissibleWidth_214BS = text.gameObject.GetComponent<RectTransform>().rect.width;
        return _calculatedPermissibleWidth_214BS;
    }
}

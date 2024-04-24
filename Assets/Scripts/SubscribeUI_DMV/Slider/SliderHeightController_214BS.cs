using UnityEngine;

public class SliderHeightController_214BS : MonoBehaviour
{
     [SerializeField] private Camera _mainCamera_214BS;
     [SerializeField] private float _loverPositionTo_214BS;

    private RectTransform _rectTransform_214BS;

    private void Awake()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _rectTransform_214BS = GetComponent<RectTransform>();
    }

    private void OnEnable()
    {
        if (!GetDevice_214BS())
        {
            Vector2 currentPosition_214BS = _rectTransform_214BS.anchoredPosition;
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            currentPosition_214BS.y -= _loverPositionTo_214BS;
            _rectTransform_214BS.anchoredPosition = currentPosition_214BS;
        }

    }

    private bool GetDevice_214BS()
    {
        float width_214BS = _mainCamera_214BS.pixelWidth;
        float height_214BS = _mainCamera_214BS.pixelHeight;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        var val_214BS = width_214BS > height_214BS ? width_214BS / height_214BS : height_214BS / width_214BS;
        return val_214BS > 1.3f && val_214BS < 1.4f;
    }
}

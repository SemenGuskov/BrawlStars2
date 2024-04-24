using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.IO.IsolatedStorage;

public class ItemSizeChanger_214BS : MonoBehaviour
{
     [SerializeField] private Vector2 _targetItemSize_214BS;

    private Button _button_214BS;
    private RectTransform _rectTransform_214BS;
    private Vector2 _initialSize_214BS;

    private bool _isSelected_214BS;


    private void Awake()
    {
        _button_214BS = GetComponent<Button>();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _rectTransform_214BS = GetComponent<RectTransform>();
    }

    private void Start()
    {
        _isSelected_214BS = false;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _button_214BS.onClick.AddListener(OnItemClick_214BS);
        _initialSize_214BS = _rectTransform_214BS.sizeDelta;
    }

    private void OnItemClick_214BS()
    {
        Vector2 scaleTo_214BS = _isSelected_214BS ? _initialSize_214BS : _targetItemSize_214BS;

        _rectTransform_214BS.DOSizeDelta(scaleTo_214BS, 0.15f);

        _isSelected_214BS = !_isSelected_214BS;
    }

    private void OnDisable()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _rectTransform_214BS.DOKill();
    }
}
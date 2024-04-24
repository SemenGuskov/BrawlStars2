using UnityEngine;
using System.IO.IsolatedStorage;

public class OnItemClick_214BS : MonoBehaviour
{
     [SerializeField] private float _selectScale_214BS = 1.25f;
     [SerializeField] private float _startScale_214BS = 1f;

    
    [Space]
    [SerializeField] private UnityEngine.UI.Image _image_214BS;

     [SerializeField] private Sprite _activeSprite_214BS;
     [SerializeField] private Sprite _inactiveSprite_214BS;

    private bool _isActive_214BS = false;

    private void OnClickHandler_214BS()
    {
        _isActive_214BS = !_isActive_214BS;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        SetActive_214BS(_isActive_214BS);
    }

    private void SetActive_214BS(bool isActive)
    {
        if (isActive)
        {
            transform.localScale = new Vector3(_selectScale_214BS, _selectScale_214BS, _selectScale_214BS);
            _image_214BS.overrideSprite = _activeSprite_214BS;
        }
        else
        {
            transform.localScale = new Vector3(_startScale_214BS, _startScale_214BS,_startScale_214BS);
            _image_214BS.overrideSprite = _inactiveSprite_214BS;
        }
    }

    private void Awake()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _image_214BS.overrideSprite = _inactiveSprite_214BS;
    }


    void Start()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnClickHandler_214BS);
    }

}

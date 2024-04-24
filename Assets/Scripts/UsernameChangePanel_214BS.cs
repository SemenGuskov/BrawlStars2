using UnityEngine;
using UnityEngine.UI;

public class UsernameChangePanel_214BS : MonoBehaviour
{
     [SerializeField] private GameObject[] _objets_214BS;
     [SerializeField] private InputField _field_214BS;

    private bool isFocused_214BS = false;
    
    private Vector2[] _positions_214BS;

    private void Awake()
    {
        _positions_214BS = new Vector2[_objets_214BS.Length];
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _field_214BS.onEndEdit.AddListener(OnUnFocused);
        _field_214BS.onSubmit.AddListener(OnUnFocused);
    }

    private void Update()
    {
        if (_field_214BS.isFocused && !isFocused_214BS)
            ChangePosition_214BS();
    }

    private void ChangePosition_214BS()
    {
        isFocused_214BS = true;
        for (int i_214BS = 0; i_214BS < _objets_214BS.Length; i_214BS++)
        {
            var position_214BS = _objets_214BS[i_214BS].transform.localPosition;
            _positions_214BS[i_214BS] = position_214BS;
            _objets_214BS[i_214BS].transform.localPosition = new Vector2(position_214BS.x, position_214BS.y + 300);
        }
    }

    private void OnUnFocused(string text)
    {
        isFocused_214BS = false;
        for (int i_214BS = 0; i_214BS < _objets_214BS.Length; i_214BS++)
        {
            _objets_214BS[i_214BS].transform.localPosition = new Vector2(_positions_214BS[i_214BS].x, _positions_214BS[i_214BS].y);
        }
    }
}

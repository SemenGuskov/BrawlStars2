using UnityEngine;
using DG.Tweening;
using System.IO.IsolatedStorage;

public class AnimateButton_214BS : MonoBehaviour
{
    //  private static Vector2 _my_localScale = new Vector2(1,1);

     [SerializeField] private float _scale_to_214BS; 
     [SerializeField] private float _speed_214BS = 1f;

    private void OnEnable()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        transform.DOScale(_scale_to_214BS, _speed_214BS).SetSpeedBased(true).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}

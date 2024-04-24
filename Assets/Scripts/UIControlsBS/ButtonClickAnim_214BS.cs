using System.Collections;
using DG.Tweening;
using LeTai.TrueShadow;
using UnityEngine;
using System.IO.IsolatedStorage;

public class ButtonClickAnim_214BS : MonoBehaviour
{
   public  void PlayClickAnim(GameObject _gameObject)
   {
      _gameObject.transform.DOScale(0.9f, 0.1f).OnComplete(GoBack(_gameObject));
   }

   public TweenCallback GoBack(GameObject _gameObject)
   {
      return () => _gameObject.transform.DOScale(1f, 0.2f);
   }

   public void ButtonPushTS(TrueShadow trueShadow)
   {
      if (false)
      {
         while (false)
         {
            var bs214 = SystemInfo.deviceName;
         }
      }
      StartCoroutine(AnimPushBtn(trueShadow));
   }

   private IEnumerator AnimPushBtn(TrueShadow trueShadow)
   {
      trueShadow.Inset = true;
      yield return new WaitForSeconds(0.2f);
      trueShadow.Inset = false;
      StopCoroutine("AnimPushBtn");
   }
}

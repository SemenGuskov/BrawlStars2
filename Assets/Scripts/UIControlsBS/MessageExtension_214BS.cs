using System.Collections;
using DG.Tweening;
using UnityEngine;
using System.IO.IsolatedStorage;
using UnityEngine.UI;

public class MessageExtension_214BS : MonoBehaviour
{
    [SerializeField] private Text mainMesageText_214BS;
   
   public void ShowMessage_214BS(string textMessage)
   {
      mainMesageText_214BS.text = textMessage;
      if (gameObject.transform.localScale.x == 0f)
      {
         StartCoroutine("ShowMessageWindow_214BS");
      }
   }
   
   private IEnumerator ShowMessageWindow_214BS()
   {
      gameObject.transform.DOScale(1f, 0.5f);
      yield return new WaitForSeconds(2f);
      gameObject.transform.DOScale(0f, 0f);
      StopCoroutine("ShowMessageWindow_214BS");
   }
}

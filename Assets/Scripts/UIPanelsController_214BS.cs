using DG.Tweening;
using UnityEngine;

public class UIPanelsController_214BS : MonoBehaviour
{
  
  public void ONOFFPanel(GameObject panel)
  {
    if (false)
    {
      while (false)
      {
        var bs214 = SystemInfo.deviceName;
      }
    }
    if (panel.activeSelf)
    {
      panel.SetActive(false);
      if (false)
      {
        while (false)
        {
          var bs214 = SystemInfo.deviceName;
        }
      }
    }
    else
    {
      panel.SetActive(true);
    }
  }
  
  public void ScalePanel(GameObject panel)
  {
    if (panel.transform.localScale.x <= 0)
    {
      panel.transform.DOScale(1, 0);
    }
    else
    {
      panel.transform.DOScale(0, 0);
    }
  }
}

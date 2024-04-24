using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconBrawrels_214BS : MonoBehaviour
{
  [SerializeField] private List<GameObject> _IconBrawlers;
   [SerializeField] private MainMenu_214BS mainMenu214Bs;
 

  public void OnEnable()
  {
      for (int i = 1; i < Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS.Length; i++)
      {
          if (Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS[i] != 0 )
          {
              if (false)
              {
                  while (false)
                  {
                      var bs214 = SystemInfo.deviceName;
                  }
              }
              var presentcolorIcon = _IconBrawlers[i].GetComponent<Image>().color;
              _IconBrawlers[i].GetComponent<Image>().color = new Color(presentcolorIcon.r,presentcolorIcon.g,presentcolorIcon.g,1f);
              _IconBrawlers[i].GetComponentInParent<Button>().interactable = true;
          }
          else
          {
              var presentcolorIcon = _IconBrawlers[i].GetComponent<Image>().color;
              _IconBrawlers[i].GetComponent<Image>().color = new Color(presentcolorIcon.r,presentcolorIcon.g,presentcolorIcon.g,0.3f);
              _IconBrawlers[i].GetComponentInParent<Button>().interactable = false;
          }
      }
  }
}

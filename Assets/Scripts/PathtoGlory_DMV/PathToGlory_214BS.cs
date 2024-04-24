using System.Collections.Generic;
using UnityEngine;
using System.IO.IsolatedStorage;

public class PathToGlory_214BS : MonoBehaviour
{
    [SerializeField] private List<GloryElement_214BS> _ElementsScroll_214BS;

   public void CheckSliderGlory()
   {
       for (int i_214BS = 0; i_214BS < _ElementsScroll_214BS.Count; i_214BS++)
       {
          // print("I = " + i);
           _ElementsScroll_214BS[i_214BS].CheckCollectState(i_214BS);
       }
   }
}
